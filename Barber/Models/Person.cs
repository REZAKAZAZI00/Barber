using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Barber.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }

        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string CodeMelli { get; set; }

        public string Education { get; set; }
        public DateTime BirthDate { get; set; }
        public string Age { get; set; }
        public int address { get; set; }
        [Required]
        public bool Sex { get; set; }


        #region Relations
        public List<Equipment>? Equipment { get; set; }
        public List<FoodDrink>? FoodDrinks { get; set; }
        public List<Orders>? Orders { get; set; }
        #endregion

    }
}
