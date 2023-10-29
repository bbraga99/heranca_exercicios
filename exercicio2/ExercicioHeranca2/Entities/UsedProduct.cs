using System.Globalization;

namespace ExercicioHeranca2.Entities
{
    public class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufacturedDate)
            : base(name,price)
        {
            ManufactureDate = manufacturedDate;
        }

        public override string PriceTag()
        {
            return $"{Name} (used) $ {Price.ToString("F2'",CultureInfo.InvariantCulture)} (Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }

    }
}
