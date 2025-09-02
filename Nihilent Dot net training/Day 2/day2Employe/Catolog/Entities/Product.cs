namespace Catelog

 {
    public class Product
    {
        private string Name;
        private decimal Price;
        public void setPrice(decimal price) { this.Price = price; }
        public void setName(string name) { this.Name = name; }
        public decimal getPrice() { return this.Price; }
        public string getName() { return this.Name; }

        public Product()
        {
            this.Name = "";
            this.Price = 0;
        }
       public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
       
    
    }
 }