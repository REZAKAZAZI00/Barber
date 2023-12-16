using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Barber.Models
{
    public class Orders
    {
        [Key]
        public int OrdersId { get; set; }
        
        public int PersonId { get; set; }
        [Required]
        public int CustomerId { get; set; }

        public int FoodDrinkId { get; set; }

        [Required]
        public int Price { get; set; }
        [Required]

        public DateTime Created { get; set; }


        #region Relations
        
        public Person? Person { get; set; }
        public Customer? Customer  { get; set; }
        public FoodDrink? FoodDrink  { get; set; }
        #endregion
    }
}
