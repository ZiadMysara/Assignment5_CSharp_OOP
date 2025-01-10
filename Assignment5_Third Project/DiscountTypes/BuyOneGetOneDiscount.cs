namespace Assignment5_Third_Project.DiscountTypes
{
    internal class BuyOneGetOneDiscount : Discount
    {
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            //Discount Amount=(Price/2)×(Quantity÷2)
            return quantity > 1 ? (price / 2) * (quantity / 2) : 0;
        }
    }
}
