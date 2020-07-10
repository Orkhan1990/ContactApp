using BusinessLayer.Abstract;
using DataAccesslayer.Abstract;
using EntitiesLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class PhoneNumberManager : IPhoneNumberService
    {
        private readonly IPhoneNumberDal phoneNumberDal;

        public PhoneNumberManager(IPhoneNumberDal phoneNumberDal)
        {
            this.phoneNumberDal = phoneNumberDal;
        }
        public void Delete(PhoneNumber entity)
        {
            phoneNumberDal.Delete(entity);
        }

        public PhoneNumber GetId(int id)
        {
            return phoneNumberDal.GetById(id);
        }

        public List<PhoneNumber> GetList()
        {
            return phoneNumberDal.GetList();
        }

        public List<PhoneNumber> GetPhoneNumberWithContacts()
        {
            return phoneNumberDal.GetPhoneNumberWithContacts();
        }


        public PhoneNumber GetWithContactById(int id)
        {
            return phoneNumberDal.GetWithContactById(id);
        }

        public void NewAdd(PhoneNumber entity)
        {
            phoneNumberDal.NewAdd(entity);
        }

        public void Update(PhoneNumber entity)
        {
            phoneNumberDal.Update(entity);

        }
    }
}
