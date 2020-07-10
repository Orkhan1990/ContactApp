using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IPhoneNumberService:IGenericService<PhoneNumber>
    {
        List<PhoneNumber> GetPhoneNumberWithContacts();
        PhoneNumber GetWithContactById(int id);
    }
}
