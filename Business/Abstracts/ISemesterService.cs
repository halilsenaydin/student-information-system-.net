using Core.Utilities.Results;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface ISemesterService
    {
        IResult Add(Semester entity);
        IResult Delete(Semester entity);
        IResult Update(Semester entity);

        IDataResult<List<Semester>> GetAll();
        IDataResult<Semester> Get(int id);
    }
}
