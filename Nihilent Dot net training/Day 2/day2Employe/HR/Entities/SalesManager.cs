namespace HR
{
    public class salesManager : salesEmployee
    {
        private decimal bonus;

        public void SetBonus(decimal bonus)
        {
            this.bonus = bonus;
        }
        public decimal GetBonus()
        {
            return this.bonus;
        }
    }
}