using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstracts;
using Business.Concretes;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstracts;
using DataAccess.Abstracts.Views;
using DataAccess.Concretes.EntityFramework;
using DataAccess.Concretes.EntityFramework.Views;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AcademicUnitManager>().As<IAcademicUnitService>().SingleInstance();
            builder.RegisterType<EfAcademicUnitDal>().As<IAcademicUnitDal>().SingleInstance();

            builder.RegisterType<StudentManager>().As<IStudentService>().SingleInstance();
            builder.RegisterType<EfStudentDal>().As<IStudentDal>().SingleInstance();

            builder.RegisterType<ForeignStudentManager>().As<IForeignStudentService>().SingleInstance();
            builder.RegisterType<EfForeignStudentDal>().As<IForeignStudentDal>().SingleInstance();

            builder.RegisterType<PersonManager>().As<IPersonService>().SingleInstance();
            builder.RegisterType<EfPersonDal>().As<IPersonDal>().SingleInstance();

            builder.RegisterType<PersonOperationClaimManager>().As<IPersonOperationClaimService>().SingleInstance();
            builder.RegisterType<EfPersonOperationClaimDal>().As<IPersonOperationClaimDal>().SingleInstance();

            builder.RegisterType<AcademicUnitManager>().As<IAcademicUnitService>().SingleInstance();
            builder.RegisterType<EfAcademicUnitDal>().As<IAcademicUnitDal>().SingleInstance();

            builder.RegisterType<ContactManager>().As<IContactService>().SingleInstance();
            builder.RegisterType<EfContactDal>().As<IContactDal>().SingleInstance();

            builder.RegisterType<DepartmentManager>().As<IDepartmentService>().SingleInstance();
            builder.RegisterType<EfDepartmentDal>().As<IDepartmentDal>().SingleInstance();

            builder.RegisterType<DenotationManager>().As<IDenotationService>().SingleInstance();
            builder.RegisterType<EfDenotationDal>().As<IDenotationDal>().SingleInstance();

            builder.RegisterType<ExamManager>().As<IExamService>().SingleInstance();
            builder.RegisterType<EfExamDal>().As<IExamDal>().SingleInstance();
            builder.RegisterType<EfExamViewDal>().As<IExamViewDal>().SingleInstance();

            builder.RegisterType<TakingLectureManager>().As<ITakingLectureService>().SingleInstance();
            builder.RegisterType<EfTakingLectureDal>().As<ITakingLectureDal>().SingleInstance();

            builder.RegisterType<OpenLectureManager>().As<IOpenLectureService>().SingleInstance();
            builder.RegisterType<EfOpenLectureDal>().As<IOpenLectureDal>().SingleInstance();
            builder.RegisterType<EfOpenLectureViewDal>().As<IOpenLectureViewDal>().SingleInstance();

            builder.RegisterType<LectureManager>().As<ILectureService>().SingleInstance();
            builder.RegisterType<EfLectureDal>().As<ILectureDal>().SingleInstance();

            builder.RegisterType<SemesterManager>().As<ISemesterService>().SingleInstance();
            builder.RegisterType<EfSemesterDal>().As<ISemesterDal>().SingleInstance();

            builder.RegisterType<TeacherManager>().As<ITeacherService>().SingleInstance();
            builder.RegisterType<EfTeacherDal>().As<ITeacherDal>().SingleInstance();

            builder.RegisterType<LoginManager>().As<ILoginService>().SingleInstance();
            builder.RegisterType<EfLoginDal>().As<ILoginDal>().SingleInstance();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
