// logical collection of .net types
// class, interface , structure , enum
// delegate, event 
namespace Catolog
{
    public class Product
    {
        private string Name { get; set; }
        private decimal price { get; set; }

        public void SetName(string name)
        {
            this.Name = name;
        }

         public string GetName()
        {
            return this.Name;
        }

        public void SetPrice(decimal price)
        {
            this.price = price;
        }

        public decimal GetPrice()
        {
            return this.price;
        }

        public Product(string name, decimal price) { this.Name = name; this.price = price; }
        public Product()
        {
            this.Name = "";
            this.price = 0;
        }
    }
}