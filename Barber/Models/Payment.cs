using System.ComponentModel.DataAnnotations;

namespace Barber.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        public int OrdersId { get; set; }
        [Required]
        public int BookingId { get; set; }
        [Required]
        public string Invoice { get; set; }
       
        public DateTime Created { get; set; }


        #region Relations
        public Person? Person { get; set; }

        public Booking?  Booking { get; set; }
        #endregion

    }
}
