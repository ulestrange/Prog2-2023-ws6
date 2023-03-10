namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle[] myCircles = new Circle[4];

            double myRadius
                = myCircles[0].Radius;


            List<Circle> myCircleList = new List<Circle>();


      // using the array

            for (int i = 0; i < myCircles.Length; i++)
            {
                myCircles[i] = new Circle();
            }

            myCircles[0].Radius = 10;
            myCircles[2].Radius = 10;

            for (int i = 0; i < myCircles.Length; i++)
            {
                Console.WriteLine(myCircles[i]);
            }

    //using the list

            for (int i = 0; i < 4; i++)
            {
                Circle circle = new Circle();
                myCircleList.Add(circle);
            }

            myCircleList[0].Radius = 20;
            myCircleList[2].Radius = 20;

            for (int i = 0; i < myCircleList.Count; i++)
            {
                Console.WriteLine(myCircleList[i]);
            }

            // could also use - this does the same as the for loop above.

            foreach (Circle c in myCircleList)
            {
                Console.WriteLine(c);
            }
        }
    }
}