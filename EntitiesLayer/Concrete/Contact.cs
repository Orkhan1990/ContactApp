using EntitiesLayer.Abstract;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntitiesLayer
{
   public class Contact:IContact
    {
        public int Id { get; set; }
        [Display(Name ="FirstName:")]
        public string FirstName { get; set; }
        [Display(Name = "LastName:")]
        public string LastName { get; set; }
        public List<PhoneNumber> PhoneNumbers { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;


    }
}
