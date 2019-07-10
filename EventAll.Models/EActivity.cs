using System;

namespace EventAll.Models
{
    public class EActivity
    {
        public int Id { get; set; }
        public string DishName { get; set; }
        public double Price { get; set; }
        public int QuantityOfDishes { get; set; }
        public DateTime DateOfActivity { get; set; }
        
        public EPay EPay { get; set; }
        public EHost Ehost { get; set; }
        public EType EType { get; set; }
    }
}
