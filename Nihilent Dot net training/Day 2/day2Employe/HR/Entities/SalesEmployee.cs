namespace HR
{
    public class salesEmployee : Employee
    {
        private decimal salesTarget;

        public void SetSalesTarget(decimal salesTarget)
        {
            this.salesTarget = salesTarget;
        }

        public decimal getSalesTarget() { return this.salesTarget; }

    }
}