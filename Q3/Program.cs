namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[5];

            string brand, name, colour;

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine("Please enter brand");
                brand = Console.ReadLine();
                Console.WriteLine("Please enter name");
                name = Console.ReadLine();
                Console.WriteLine("Please enter colour");
                colour = Console.ReadLine();

                cars[i] = new Car(name, brand, colour);
            }

            Console.WriteLine($"You entered {cars[1].Brand} for car 2, pleae enter a new brand");

            brand = Console.ReadLine();

            cars[1].Brand = brand;



            
        }
    }
}