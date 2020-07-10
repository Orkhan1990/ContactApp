using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUIApp.Models
{
    public class ContactEditViewModel
    {

        public int Id { get; set; }

        public string MobilNumber { get; set; }

        public string WorkNumber { get; set; }

        public string HomeNumber { get; set; }


        public int ContactId { get; set; }
        public Contact Contact { get; set; }
    }
}
