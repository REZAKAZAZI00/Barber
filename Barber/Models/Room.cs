using System.ComponentModel.DataAnnotations;

namespace Barber.Models
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        public int CustomerId { get; set; }
        public int BookingId { get; set; }
        public string Type { get; set; }
        public string NameRoom { get; set; }
        public int rate { get; set; }
        public DateTime Date { get; set; }

        #region Relations
        public Booking?  Booking { get; set; }
        public List<Equipment>? Equipment { get; set; }
        #endregion

    }
}
