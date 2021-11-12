using Core.Utilities.Results;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstracts
{
    public interface IContactService
    {
        IResult Add(Contact entity);
        IResult Delete(Contact entity);
        IResult Update(Contact entity);

        IDataResult<List<Contact>> GetAll();
        IDataResult<Contact> Get(int id);

        IDataResult<List<ContactDetaiDto>> GetAllDto();
        IDataResult<ContactDetaiDto> GetDto(int id);
    }
}
