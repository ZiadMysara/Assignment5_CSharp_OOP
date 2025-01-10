using Assignment5_Third_Project.DiscountTypes;

namespace Assignment5_Third_Project.UserTypes
{
    internal class PremiumUser : User
    {
        public override Discount? GetDiscount()
        {
            return new FlatDiscount(100);
        }
    }
}
