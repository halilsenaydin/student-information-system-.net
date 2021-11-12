using Core.Utilities.Results;
using Entities.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface IPersonService
    {
        IResult Add(AbstractPerson entity);
        IResult Delete(AbstractPerson entity);
        IResult Update(AbstractPerson entity);
    }
}
