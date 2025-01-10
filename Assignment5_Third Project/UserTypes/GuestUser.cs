using Assignment5_Third_Project.DiscountTypes;

namespace Assignment5_Third_Project.UserTypes
{
    internal class GuestUser : User
    {
        public override Discount? GetDiscount()
        {
            return null;
        }
    }
}
