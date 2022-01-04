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

        public TakingLectureManager(ITakingLectureDal dal)
        {
            _dal = dal;
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
    }
}
