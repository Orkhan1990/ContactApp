using BusinessLayer.Abstract;
using DataAccesslayer.Abstract;
using EntitiesLayer;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal personalDal;

        public ContactManager(IContactDal personalDal)
        {
            this.personalDal = personalDal;
        }
        public void Delete(Contact entity)
        {
            personalDal.Delete(entity);
        }

        public Contact GetId(int id)
        {
            return personalDal.GetById(id);
        }

        public List<Contact> GetIdWithPhoneNumbers()
        {
            return personalDal.GetIdWithPhoneNumbers();
        }

        public List<Contact> GetList()
        {
            return personalDal.GetList();

        }

        public void NewAdd(Contact entity)
        {
            personalDal.NewAdd(entity);
        }

        public void Update(Contact entity)
        {
            personalDal.Update(entity);
        }
    }
}
