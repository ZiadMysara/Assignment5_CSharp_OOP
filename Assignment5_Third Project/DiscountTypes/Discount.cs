namespace Assignment5_Third_Project.DiscountTypes
{
    internal abstract class Discount
    {
        public abstract decimal CalculateDiscount(decimal price, int quantity);

    }
}
