using Assignment5_Third_Project.DiscountTypes;


namespace Assignment5_Third_Project.UserTypes
{
    internal abstract class User
    {
        public int Name { get; set; }

        public abstract Discount? GetDiscount();
    }
}
