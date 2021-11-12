using Core.Utilities.Results;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface IAcademicUnitService
    {
        IResult Add(AcademicUnit entity);
        IResult Delete(AcademicUnit entity);
        IResult Update(AcademicUnit entity);

        IDataResult<List<AcademicUnit>> GetAll();
        IDataResult<AcademicUnit> Get(int id);

        IDataResult<List<AcademicUnitDetailDto>> GetAllDto();
        IDataResult<AcademicUnitDetailDto> GetDto(int id);
    }
}
