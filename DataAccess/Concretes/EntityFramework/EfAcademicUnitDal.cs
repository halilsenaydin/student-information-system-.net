using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfAcademicUnitDal : EfEntityRepositoryBase<AcademicUnit, MSSQLContext>, IAcademicUnitDal
    {
        public List<AcademicUnitDetailDto> GetAllDto(Expression<Func<AcademicUnit, bool>> filter = null)
        {
            using (MSSQLContext context = new MSSQLContext())
            {
                var result = from academicUnit in filter == null ? context.AcademicUnits : context.AcademicUnits.Where(filter)
                             join academicUnitType in context.AcademicUnitTypes
                             on academicUnit.AcademicUnitTypeId equals academicUnitType.Id

                             select new AcademicUnitDetailDto
                             {
                                 Id = academicUnit.Id,
                                 AcademicUnitName = academicUnit.AcademicUnitName,
                                 AcademicUnitType = academicUnitType
                             };

                return result.ToList();
            }
        }

        public AcademicUnitDetailDto GetDto(Expression<Func<AcademicUnit, bool>> filter)
        {
            using (MSSQLContext context = new MSSQLContext())
            {
                var result = from academicUnit in context.AcademicUnits.Where(filter)
                             join academicUnitType in context.AcademicUnitTypes
                             on academicUnit.AcademicUnitTypeId equals academicUnitType.Id

                             select new AcademicUnitDetailDto
                             {
                                 Id = academicUnit.Id,
                                 AcademicUnitName = academicUnit.AcademicUnitName,
                                 AcademicUnitType = academicUnitType
                             };

                return result.SingleOrDefault();
            }
        }
    }
}
