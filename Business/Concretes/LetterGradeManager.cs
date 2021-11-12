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
    public class LetterGradeManager : ILetterGradeService
    {
        ILetterGradeDal _dal;
        public LetterGradeManager(ILetterGradeDal dal)
        {
            _dal = dal;
        }

        public IResult Add(LetterGrade entity)
        {
            _dal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(LetterGrade entity)
        {
            _dal.Delete(entity);
            return new SuccessResult();
        }

        public IResult Update(LetterGrade entity)
        {
            _dal.Update(entity);
            return new SuccessResult();
        }
        public IDataResult<LetterGrade> Get(int id)
        {
            return new SuccessDataResult<LetterGrade>(_dal.Get(a => a.Id == id));
        }

        public IDataResult<List<LetterGrade>> GetAll()
        {
            return new SuccessDataResult<List<LetterGrade>>(_dal.GetAll());
        }

        public IDataResult<List<LetterGradeDetailDto>> GetAllDto()
        {
            return new SuccessDataResult<List<LetterGradeDetailDto>>(_dal.GetAllDto());
        }

        public IDataResult<LetterGradeDetailDto> GetDto(int id)
        {
            return new SuccessDataResult<LetterGradeDetailDto>(_dal.GetDto(a => a.Id == id));
        }
    }
}
