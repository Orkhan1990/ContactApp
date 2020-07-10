using EntitiesLayer;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUIApp.Models
{
    public class ContactAddViewModel
    {
        public int Id { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "MobileNumber:")]
        public string MobilNumber { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "WorkNumber:")]
        public string WorkNumber { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "HomeNumber:")]
        public string HomeNumber { get; set; }


        public int ContactId { get; set; }
        public Contact Contact { get; set; }



    }
}
