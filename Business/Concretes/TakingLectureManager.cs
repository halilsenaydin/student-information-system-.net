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
    public class TakingLectureManager : ITakingLectureService
    {
        ITakingLectureDal _dal;
        ITakingLectureViewDal _viewDal;

        public TakingLectureManager(ITakingLectureDal dal, ITakingLectureViewDal viewDal)
        {
            _dal = dal;
            _viewDal = viewDal;
        }

        public IResult Add(TakingLecture entity)
        {
            _dal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(TakingLecture entity)
        {
            _dal.Delete(entity);
            return new SuccessResult();
        }

        public IResult Update(TakingLecture entity)
        {
            _dal.Update(entity);
            return new SuccessResult();
        }
        public IDataResult<TakingLecture> Get(int id)
        {
            return new SuccessDataResult<TakingLecture>(_dal.Get(a => a.Id == id));
        }

        public IDataResult<List<TakingLecture>> GetAll()
        {
            return new SuccessDataResult<List<TakingLecture>>(_dal.GetAll());
        }

        public IDataResult<List<TakingLectureDetailDto>> GetAllDto()
        {
            return new SuccessDataResult<List<TakingLectureDetailDto>>(_dal.GetAllDto());
        }

        public IDataResult<TakingLectureDetailDto> GetDto(int id)
        {
            return new SuccessDataResult<TakingLectureDetailDto>(_dal.GetDto(a => a.Id == id));
        }

        public IDataResult<List<TakingLectureView>> GetAllViewByTeacherIdAndSemesterId(int teacherId, int semesterId)
        {
            return new SuccessDataResult<List<TakingLectureView>>(_viewDal.GetAll(t => t.TeacherId == teacherId && t.SemesterId == semesterId));
        }

        public IDataResult<TakingLectureView> GetViewByTeacherIdAndSemesterId(int teacherId, int semesterId)
        {
            return new SuccessDataResult<TakingLectureView>(_viewDal.Get(t => t.TeacherId == teacherId && t.SemesterId == semesterId));
        }
    }
}
