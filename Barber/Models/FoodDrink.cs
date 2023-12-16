using System.ComponentModel.DataAnnotations;

namespace Barber.Models
{
    public class FoodDrink
    {
        [Key]
        public int FoodDrinkId { get; set; }
        [Required]
        public int PersonId { get; set; }
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }

        public int Count { get; set; }

        public DateTime Created { get; set; }


        #region Relations
        public  List<Orders>? Orders { get; set; }

        public Person? Person { get; set; }
        #endregion
    }
}
