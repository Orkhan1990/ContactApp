using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesslayer.Abstract
{
    public interface IPhoneNumberDal:IGenericDal<PhoneNumber>
    {
        List<PhoneNumber> GetPhoneNumberWithContacts();
       PhoneNumber GetWithContactById(int id);
    }
}
