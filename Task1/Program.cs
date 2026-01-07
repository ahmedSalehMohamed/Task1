namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int smallRoomPrice = 25;
            int largeRoomPrice = 35;
            double tax = 0.06;


            Console.WriteLine("Please Enter the Number of Small rooms");
            int smallRoomCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter the Number of Large rooms");
            int largeRoomCount = Convert.ToInt32(Console.ReadLine());

            double cost = (smallRoomCount* smallRoomPrice) + (largeRoomCount * largeRoomPrice);

            Console.WriteLine($"the Initial Cost is {cost} ");
            Console.WriteLine("          ");

            double totalCost = cost + (cost * tax);

            Console.WriteLine($"the Total Cost after adding Taxes is {totalCost} ,This estimate is valid for 30 days ");


            Console.ReadKey();
        }
    }
}
