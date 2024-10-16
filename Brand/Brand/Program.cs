using System.Diagnostics;
using System.Reflection;

namespace Brand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new("World Industries", "Wet Willy", 70, 30, 2500);

            Phone Phone = new Phone("Iphone", "14", "500", "200", "1000", "4", "Blue");

            product.GetInfo();

            Phone.GetInfo();

            Phone.Calls();
        }
    }
}
