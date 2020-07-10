using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IContactService:IGenericService<Contact>
    {
        List<Contact> GetIdWithPhoneNumbers();
    }
}
