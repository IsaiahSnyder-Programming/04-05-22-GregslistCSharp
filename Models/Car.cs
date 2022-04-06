using System.ComponentModel.DataAnnotations;


namespace GregsListCSharp.Models
{
    public class Car
    {
        public string Id { get; set; }

        [Required]
        public string Make { get; set; }

        [Range(0, int.MaxValue)]
        public int Price { get; set; }
        public bool HasTires { get; set; }

        public Car(string make, int price, bool hasTires)
        {
            Id = Guid.NewGuid().ToString();
            Make = make;
            Price = price;
            HasTires = hasTires;
        }
    }
}