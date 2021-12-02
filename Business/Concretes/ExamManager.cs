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
    public class ExamManager : IExamService
    {
        IExamDal _dal;
        public ExamManager(IExamDal dal)
        {
            _dal = dal;
        }

        public IResult Add(Exam entity)
        {
            _dal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(Exam entity)
        {
            _dal.Delete(entity);
            return new SuccessResult();
        }

        public IResult Update(Exam entity)
        {
            _dal.Update(entity);
            return new SuccessResult();
        }

        public IDataResult<Exam> Get(int id)
        {
            return new SuccessDataResult<Exam>(_dal.Get(a => a.Id == id));
        }

        public IDataResult<List<Exam>> GetAll()
        {
            return new SuccessDataResult<List<Exam>>(_dal.GetAll());
        }

        public IDataResult<List<ExamDetailDto>> GetAllDto()
        {
            return new SuccessDataResult<List<ExamDetailDto>>(_dal.GetAllDto());
        }

        public IDataResult<ExamDetailDto> GetDto(int id)
        {
            return new SuccessDataResult<ExamDetailDto>(_dal.GetDto(a => a.Id == id));
        }

        public IDataResult<List<ExamDetailDto>> GetAllDtoByStudentId(int id)
        {
            return new SuccessDataResult<List<ExamDetailDto>>(_dal.GetAllDto(e=>e.StudentId == id));
        }

        public IDataResult<ExamDetailDto> GetDtoByStudentId(int id)
        {
            return new SuccessDataResult<ExamDetailDto>(_dal.GetDto(a => a.StudentId == id));
        }
    }
}
