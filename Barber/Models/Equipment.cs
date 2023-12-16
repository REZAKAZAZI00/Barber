using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Barber.Models
{
    public class Equipment
    {
        [Key]
        public int EquipmentId { get; set; }
        public int RoomId { get; set; }
        [Required]
        public int PersonId { get; set; }
        [Required]
        public string Nmae { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public int Count { get; set; }
        #region Relations
        public List<Person>? person { get; set; }
        public List<Room>? Rooms { get; set; }
        #endregion

    }
} 