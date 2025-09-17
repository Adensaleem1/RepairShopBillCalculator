using System;
using System.Globalization;

namespace RepairShopBillCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set culture for currency formatting
            CultureInfo culture = CultureInfo.CurrentCulture;

            // Greeting
            Console.WriteLine("Welcome to the Repair Shop Bill Calculator!\n");

            // Get user input
            Console.Write("Enter the cost for Oil Change: ");
            double oilChange = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the cost for Tires: ");
            double tires = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the cost for Inspection: ");
            double inspection = Convert.ToDouble(Console.ReadLine());

            // Calculate subtotal
            double subtotal = oilChange + tires + inspection;

            // Calculate tax (6%)
            double tax = subtotal * 0.06;

            // Calculate grand total
            double grandTotal = subtotal + tax;

            // Output results
            Console.WriteLine("\n------- Repair Shop Bill -------");
            Console.WriteLine($"Subtotal: {subtotal.ToString("C", culture)}");
            Console.WriteLine($"Tax (6%): {tax.ToString("C", culture)}");
            Console.WriteLine($"Grand Total: {grandTotal.ToString("C", culture)}");

            Console.WriteLine("\nThank you for using the Repair Shop Bill Calculator!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
