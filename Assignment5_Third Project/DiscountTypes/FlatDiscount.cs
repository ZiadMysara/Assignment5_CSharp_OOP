namespace Assignment5_Third_Project.DiscountTypes
{
    internal class FlatDiscount : Discount
    {
        #region Prop
        public decimal FlatAmount { get; set; }
        #endregion

        #region Constractors
        public FlatDiscount(decimal flatAmount)
        {
            FlatAmount = flatAmount;
        }
        #endregion


        #region Methodes
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            //Formula: Discount Amount=Flat Amount×min(Quantity,1)
            return FlatAmount * Math.Min(quantity, 1);
        }
        #endregion
    }
}
