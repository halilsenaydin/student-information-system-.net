using Core.Utilities.Results;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface ILetterGradeService
    {
        IResult Add(LetterGrade entity);
        IResult Delete(LetterGrade entity);
        IResult Update(LetterGrade entity);

        IDataResult<List<LetterGrade>> GetAll();
        IDataResult<LetterGrade> Get(int id);

        IDataResult<List<LetterGradeDetailDto>> GetAllDto();
        IDataResult<LetterGradeDetailDto> GetDto(int id);
    }
}
