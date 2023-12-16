using System.ComponentModel.DataAnnotations;

namespace Barber.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }

        public int CustomerId { get; set; }
        [Required]
        public int Type { get; set; }

        public bool Nights  { get; set; }

        public DateTime Date { get; set; }

        #region Relations
        public Customer? Customers { get; set; }
        public List<Orders>? Orders { get; set; }
        #endregion

    }
}
