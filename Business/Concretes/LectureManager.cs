using Business.Abstracts;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concretes
{
    public class LectureManager : ILectureService
    {
        ILectureDal _dal;
        public LectureManager(ILectureDal dal)
        {
            _dal = dal;
        }

        public IResult Add(Lecture entity)
        {
            _dal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(Lecture entity)
        {
            _dal.Delete(entity);
            return new SuccessResult();
        }

        public IResult Update(Lecture entity)
        {
            _dal.Update(entity);
            return new SuccessResult();
        }
        public IDataResult<Lecture> Get(int id)
        {
            return new SuccessDataResult<Lecture>(_dal.Get(a => a.Id == id));
        }

        public IDataResult<List<Lecture>> GetAll()
        {
            return new SuccessDataResult<List<Lecture>>(_dal.GetAll());
        }

        public IDataResult<List<LectureDetailDto>> GetAllDto()
        {
            return new SuccessDataResult<List<LectureDetailDto>>(_dal.GetAllDto());
        }

        public IDataResult<LectureDetailDto> GetDto(int id)
        {
            return new SuccessDataResult<LectureDetailDto>(_dal.GetDto(a => a.Id == id));
        }
    }
}
