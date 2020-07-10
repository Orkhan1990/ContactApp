using DataAccesslayer.Abstract;
using DataAccesslayer.EntityFramework.Context;
using EntitiesLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccesslayer.EntityFramework.Repository
{
    public class EfPhoneNumberRepository : EfGenericRepository<PhoneNumber>, IPhoneNumberDal
    {
        public List<PhoneNumber> GetPhoneNumberWithContacts()
        {
            using var context = new ContactContext();
            return context.PhoneNumbers.Include(i => i.Contact).ToList();
        }

      

        public PhoneNumber GetWithContactById(int id)
        {
            using var context = new ContactContext();
            return context.PhoneNumbers.Include(i => i.Contact).Where(i => i.Id == id).OrderByDescending(i=>i.Contact.LastModifiedDate).FirstOrDefault();
        }
    }
}
