namespace Assignment5_Third_Project.DiscountTypes
{
    internal class PercentageDiscount : Discount
    {
        public decimal Percentage { get; set; }

        public PercentageDiscount(decimal percentage)
        {
            Percentage = percentage;
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            //Discount Amount=Price×Quantity×(Percentage/100)
            return price * quantity * (Percentage / 100);
        }
    }
}
