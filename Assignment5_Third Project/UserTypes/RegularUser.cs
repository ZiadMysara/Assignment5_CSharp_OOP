using Assignment5_Third_Project.DiscountTypes;

namespace Assignment5_Third_Project.UserTypes
{
    internal class RegularUser : User
    {
        public override Discount? GetDiscount()
        {
            return new PercentageDiscount(5);
        }
    }
}
