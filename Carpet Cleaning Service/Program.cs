namespace Carpet_Cleaning_Service
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Islam's Carpet Cleaning Service");
            Console.WriteLine("Sales tax rate is 6%");
            Console.WriteLine("please enter your small carpet : ");
            int smallCarpet = Convert.ToInt32(Console.ReadLine());
            int totalSmallCarpet = smallCarpet * 25;
            Console.WriteLine("please enter your Large carpet : ");
            int largeCarpet = Convert.ToInt32(Console.ReadLine());
            int totalLargeCarpet = largeCarpet * 35;
            int cost = totalSmallCarpet + totalLargeCarpet;
            int tax = (cost * 6) / 100;
            int totalEstimate = cost + tax;
            Console.WriteLine($"totalEstimate = {totalEstimate}");
        }
    }
}
