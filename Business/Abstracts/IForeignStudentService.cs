using Core.Utilities.Results;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface IForeignStudentService
    {
        IResult Add(ForeignStudent entity);
        IResult Delete(ForeignStudent entity);
        IResult Update(ForeignStudent entity);

        IDataResult<List<ForeignStudent>> GetAll();
        IDataResult<ForeignStudent> Get(int id);

        IDataResult<List<ForeignStudentDetailDto>> GetAllDto();
        IDataResult<ForeignStudentDetailDto> GetDto(int id);

        IDataResult<int> GetAllCount();
    }
}
