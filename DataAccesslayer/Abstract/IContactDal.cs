using EntitiesLayer;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccesslayer.Abstract
{
    public interface IContactDal:IGenericDal<Contact>
    {
       List<Contact> GetIdWithPhoneNumbers();
    }
}
