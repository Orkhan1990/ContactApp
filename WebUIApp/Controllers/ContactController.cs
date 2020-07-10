using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using EntitiesLayer;
using EntitiesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using WebUIApp.Models;

namespace WebUIApp.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService contactService;
        private readonly IPhoneNumberService phoneNumberService;

        public ContactController(IContactService contactService, IPhoneNumberService phoneNumberService)
        {
            this.contactService = contactService;
            this.phoneNumberService = phoneNumberService;
        }
        public async Task<IActionResult> Index()
        {
            var listcontacts = phoneNumberService.GetPhoneNumberWithContacts();
            List<ContactListViewModel> models = new List<ContactListViewModel>();
            foreach (var item in listcontacts)
            {
                ContactListViewModel model = new ContactListViewModel()
                {
                    Id = item.Id,
                    FirstName = item.Contact.FirstName,
                    LastName = item.Contact.LastName,
                    HomeNumber = item.HomeNumber,
                    MobileNumber = item.MobilNumber,
                    WorkNumber = item.WorkNumber


                };
                models.Add(model);
            }
            return View(models);
        }

        public IActionResult Create()
        {
            return View(new ContactAddViewModel());
        }
        [HttpPost]
        public IActionResult Create(ContactAddViewModel model)
        {
            phoneNumberService.NewAdd(new PhoneNumber()
            {
                Contact = model.Contact,
                HomeNumber = model.HomeNumber,
                ContactId = model.ContactId,
                Id = model.Id,
                MobilNumber = model.MobilNumber,
                WorkNumber = model.WorkNumber
            });
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {


            var phone = phoneNumberService.GetWithContactById(id);
            ContactDetailsViewModel model = new ContactDetailsViewModel();
            model.Contact = phone.Contact;
            model.HomeNumber = phone.HomeNumber;
            model.MobilNumber = phone.MobilNumber;
            model.WorkNumber = phone.WorkNumber;
            model.ContactId = phone.ContactId;
            model.Id = phone.Id;


            return View(model);

        }

        public IActionResult Edit(int id)
        {
            var phone = phoneNumberService.GetWithContactById(id);
            ContactEditViewModel model = new ContactEditViewModel();
            model.Contact = phone.Contact;
            model.HomeNumber = phone.HomeNumber;
            model.MobilNumber = phone.MobilNumber;
            model.WorkNumber = phone.WorkNumber;
            model.ContactId = phone.ContactId;
            model.Id = phone.Id;


            return View(model);

        }
        [HttpPost]
        public IActionResult Edit(ContactEditViewModel model)
        {
            DateTime lastModifiedDate = DateTime.Now;
            var phone = phoneNumberService.GetWithContactById(model.Id);

            phone.Id = model.Id;

            phone.HomeNumber = model.HomeNumber;
            phone.MobilNumber = model.MobilNumber;
            phone.WorkNumber = model.WorkNumber;
            phone.Contact.LastModifiedDate = DateTime.Now;
            phoneNumberService.Update(phone);



            return RedirectToAction("Details", model);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            phoneNumberService.Delete(new PhoneNumber()
            {
                Id = id
            });
            return Json(true);
        }

    }
}