using EntitiesLayer.Abstract;
using System.ComponentModel.DataAnnotations;

namespace EntitiesLayer.Concrete
{
    public  class PhoneNumber:IContact
    {
        //Bunu Enumlada qurmaq olar
        [Key]
        public int Id { get; set; }
       
        public string MobilNumber { get; set; }
       
        public string WorkNumber { get; set; }
       
        public string HomeNumber { get; set; }


        public int ContactId { get; set; }
        public Contact Contact { get; set; }


    }
}
