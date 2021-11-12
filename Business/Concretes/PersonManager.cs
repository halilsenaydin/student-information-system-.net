using Business.Abstracts;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concretes
{
    public class PersonManager : IPersonService
    {
        IPersonDal _dal;
        public PersonManager(IPersonDal dal)
        {
            _dal = dal;
        }

        public IResult Add(AbstractPerson entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(AbstractPerson entity)
        {
            throw new NotImplementedException();
        }

        public IResult Update(AbstractPerson entity)
        {
            throw new NotImplementedException();
        }
    }
}
