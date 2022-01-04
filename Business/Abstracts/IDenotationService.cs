using Core.Utilities.Results;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface IDenotationService
    {
        IResult Add(Denotation entity);
        IResult Delete(Denotation entity);
        IResult Update(Denotation entity);

        IDataResult<List<Denotation>> GetAll();
        IDataResult<Denotation> Get(int id);
    }
}
