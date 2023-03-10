

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Employee emp1 = new Employee();

            emp1.Name = "Anna";
            emp1.Gender = "F";

           Console.WriteLine(emp1.ToString());
            Console.WriteLine(emp1);
        }
    }
}