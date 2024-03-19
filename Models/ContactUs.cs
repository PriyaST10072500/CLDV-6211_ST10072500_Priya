using System.ComponentModel.DataAnnotations;

namespace MVC_IceTask_1_ST10072500_Priya.Models
{
    public class ContactUs
    {

        public string Name { get; set; }

        public string Surname { get; set; }

        public double Email { get; set; }


        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public string Description { get; set; }

    }
}
