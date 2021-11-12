using Core.Utilities.Results;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface IDepartmentService
    {
        IResult Add(Department entity);
        IResult Delete(Department entity);
        IResult Update(Department entity);

        IDataResult<List<Department>> GetAll();
        IDataResult<Department> Get(int id);

        IDataResult<List<DepartmentDetailDto>> GetAllDto();
        IDataResult<DepartmentDetailDto> GetDto(int id);
    }
}
