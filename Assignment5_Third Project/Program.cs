using Assignment5_Third_Project.DiscountTypes;
using Assignment5_Third_Project.UserTypes;

namespace Assignment5_Third_Project
{

    /*
    You are tasked with designing a system for an e-commerce platform that calculates discounts 
    for different types of users and products. This system should utilize abstraction and include 
    the following parts:
    Part 1: Abstract Discount Class
    1. Create an abstract class Discount with:
    o An abstract method CalculateDiscount(decimal price, int quantity) that returns the 
    discount amount based on the original price and quantity.
    o A Name property to store the type of discount.

    Part 2: Specific Discounts
    2. Implement the following concrete discount classes:
    o PercentageDiscount:
    ▪ Accepts a percentage (e.g., 10%).
    ▪ Formula: Discount Amount=Price×Quantity×(Percentage/100)
    o FlatDiscount:
    ▪ Accepts a fixed amount to be deducted (e.g., $50).
    ▪ Formula: Discount Amount=Flat Amount×min(Quantity,1)
    o BuyOneGetOneDiscount:
    ▪ Applies a 50% discount if the quantity is greater than 1.
    ▪ Formula: Discount Amount=(Price/2)×(Quantity÷2)

    Part 3: Discount Applicability
    3. Create an abstract class User with:
    o A Name property to store the user name.
    o An abstract method GetDiscount() that returns a Discount object.


    Part 4: Integration
    5. Write a program that:
    o Ask the user to input their type (Regular, Premium, or Guest).
    o Allows the user to input product details (price and quantity).
    o Calculates and displays the total discount and final price after applying the 
    appropriate discount. 
    */


    internal class Program
    {
        private static void PrintFinalPrice(decimal price, int quantity, Discount? discount)
        {
            decimal discountAmount = 0;
            if (discount is not null)
            {
                discountAmount = discount.CalculateDiscount(price, quantity);
            }
            decimal finalPrice = price * quantity - discountAmount;
            Console.WriteLine($"Total Discount: {discountAmount}");
            Console.WriteLine($"Final Price: {finalPrice}");
        }
        static void Main(string[] args)
        {
            /*
            Part 4: Integration
            5. Write a program that:
            o Ask the user to input their type (Regular, Premium, or Guest).
            o Allows the user to input product details (price and quantity).
            o Calculates and displays the total discount and final price after applying the 
            appropriate discount. 
             */
            EUserType TheUserType = 0;
            do
            {

                Console.WriteLine("please enter your Type (Regular, Premium, or Guest)");
                string type = Console.ReadLine()!;
                Enum.TryParse<EUserType>(type, true, out TheUserType);
            }

            while (TheUserType == 0);

            decimal price = 0m;
            int quantity = 0;
            bool flag = false;
            do
            {
                Console.WriteLine("please enter the price of the product");
                flag = decimal.TryParse(Console.ReadLine(), out price);
            }
            while (!flag);

            do
            {
                Console.WriteLine("please enter the quantity of the product");
                flag = int.TryParse(Console.ReadLine(), out quantity);
            }
            while (!flag);

            /*
            o RegularUser: Applies a PercentageDiscount of 5%.
            o PremiumUser: Applies a FlatDiscount of $100.
            o GuestUser: No discount is applied
            */

            User user = TheUserType switch //impossible to be none here because of the do while loop
            {
                EUserType.Regular => new RegularUser(),
                EUserType.Premium => new PremiumUser(),
                EUserType.Guest => new GuestUser(),
            };

            Discount? discount = user.GetDiscount();

            PrintFinalPrice(price, quantity, discount);

        }
    }
}
