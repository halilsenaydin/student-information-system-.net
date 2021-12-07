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
    public class ContactManager : IContactService
    {
        IContactDal _dal;
        public ContactManager(IContactDal dal)
        {
            _dal = dal;
        }

        public IResult Add(Contact entity)
        {
            _dal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(Contact entity)
        {
            _dal.Delete(entity);
            return new SuccessResult();
        }

        public IResult Update(Contact entity)
        {
            _dal.Update(entity);
            return new SuccessResult();
        }
        public IDataResult<Contact> Get(int id)
        {
            return new SuccessDataResult<Contact>(_dal.Get(a => a.Id == id));
        }

        public IDataResult<Contact> GetByPersonId(int personId)
        {
            return new SuccessDataResult<Contact>(_dal.Get(a => a.PersonId == personId));
        }

        public IDataResult<List<Contact>> GetAll()
        {
            return new SuccessDataResult<List<Contact>>(_dal.GetAll());
        }

        public IDataResult<List<ContactDetaiDto>> GetAllDto()
        {
            return new SuccessDataResult<List<ContactDetaiDto>>(_dal.GetAllDto());
        }

        public IDataResult<ContactDetaiDto> GetDto(int id)
        {
            return new SuccessDataResult<ContactDetaiDto>(_dal.GetDto(a => a.Id == id));
        }
    }
}
