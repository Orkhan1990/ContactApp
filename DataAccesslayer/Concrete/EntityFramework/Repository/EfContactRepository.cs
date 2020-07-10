using DataAccesslayer.Abstract;
using DataAccesslayer.EntityFramework.Context;
using EntitiesLayer;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataAccesslayer.EntityFramework.Repository
{
    public class EfContactlRepository : EfGenericRepository<Contact>, IContactDal
    {
        public List<Contact> GetIdWithPhoneNumbers()
        {
            using var context = new ContactContext();
            return context.Contacts.Include(i => i.PhoneNumbers).ToList();
        }
    }
}
