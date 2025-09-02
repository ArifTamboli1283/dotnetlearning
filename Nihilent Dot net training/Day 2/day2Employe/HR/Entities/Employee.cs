namespace HR
{

    public class Employee
    {
        private string Name;
        private int Id;

        public void setName(string name) { this.Name = name; }
        public string getName() { return this.Name; }
        public int getId() { return this.Id; }

        public void setId(int id) { this.Id = id; }

        public Employee()
        {
            this.Id = 0;
            this.Name = "";
        }

        public Employee(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }
}
}
