using System.ComponentModel.DataAnnotations;

namespace Barber.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string FirstName { get; set; }
        
        [Required]  
        public string LastName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string CodeMelli { get; set; }
        public DateTime BirthDate { get; set; }
        public string Age { get; set; }
        public int address { get; set; }
        [Required]
        public bool Sex { get; set; }

        #region Relations
        public List<Booking>? Booking  { get; set; }
        public List<Orders>? Orders { get; set; }
       
        #endregion

    }
}
