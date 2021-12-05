using Business.Abstracts;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using DataAccess.Abstracts.Views;
using Entities.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using Entities.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concretes
{
    public class OpenLectureManager : IOpenLectureService
    {
        IOpenLectureDal _dal;
        IOpenLectureViewDal _viewDal;

        public OpenLectureManager(IOpenLectureDal dal, IOpenLectureViewDal viewDal)
        {
            _dal = dal;
            _viewDal = viewDal;
        }

        public IResult Add(OpenLecture entity)
        {
            _dal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(OpenLecture entity)
        {
            _dal.Delete(entity);
            return new SuccessResult();
        }

        public IResult Update(OpenLecture entity)
        {
            _dal.Update(entity);
            return new SuccessResult();
        }
        public IDataResult<OpenLecture> Get(int id)
        {
            return new SuccessDataResult<OpenLecture>(_dal.Get(a => a.Id == id));
        }

        public IDataResult<List<OpenLecture>> GetAll()
        {
            return new SuccessDataResult<List<OpenLecture>>(_dal.GetAll());
        }

        public IDataResult<List<OpenLectureDetailDto>> GetAllDto()
        {
            return new SuccessDataResult<List<OpenLectureDetailDto>>(_dal.GetAllDto());
        }

        public IDataResult<OpenLectureDetailDto> GetDto(int id)
        {
            return new SuccessDataResult<OpenLectureDetailDto>(_dal.GetDto(a => a.Id == id));
        }

        public IDataResult<List<OpenLectureView>> GetAllViewByTeacherIdAndSemesterId(int teacherId, int semesterId)
        {
            return new SuccessDataResult<List<OpenLectureView>>(_viewDal.GetAll(t => t.TeacherId == teacherId && t.SemesterId == semesterId));
        }

        public IDataResult<OpenLectureView> GetViewByTeacherIdAndSemesterId(int teacherId, int semesterId)
        {
            return new SuccessDataResult<OpenLectureView>(_viewDal.Get(t => t.TeacherId == teacherId && t.SemesterId == semesterId));
        }
    }
}
