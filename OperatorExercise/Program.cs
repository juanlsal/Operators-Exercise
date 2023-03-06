namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            //addition
            //Console.WriteLine("Enter two numbers to sum");
            //int x = Convert.ToInt32(Console.ReadLine());
            //int y = Convert.ToInt32(Console.ReadLine());
            //or
            int x = 5;
            int y = 10;
            Console.WriteLine(x + y);
            //output 15

            //subtraction
            //Console.WriteLine("Enter two numbers to find the difference");
            //int f = Convert.ToInt32(Console.ReadLine());
            //int g = Convert.ToInt32(Console.ReadLine());
            //or
            int f = 100;
            int g = 25;
            Console.WriteLine(f - g);
            //output 75


            //multiplication
            //Console.WriteLine("Enter two numbers to multiply");
            //int q = Convert.ToInt32(Console.ReadLine());
            //int w = Convert.ToInt32(Console.ReadLine());
            //or
            int q = 10;
            int w = 2;
            Console.WriteLine(q * w);
            //output 20


            //division
            //Console.WriteLine("Enter two numbers to divide");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int quotient = (a % b);
            int a = 17;
            int b = 4;
            int quotient = (a % b);
            Console.WriteLine($"{a}/{b} is {a/b} remainder {quotient}.");
            


            //Exercise 2
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            var area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area of a circle with radius of {radius} is {area}" );
            

            //Thought Exercise
            var i = 3; // i is assigned the value of 3
            var j = 4; // j is assigned the value of 4
            var k = ++i * j++; // k is assigned the value of i + j. i s given an increment of 1 prior to the code being stated, making i = 4. j is given an increment of 1 only after the
                               // j is restated in the code, however since it never was, j is still j = 4. making k = 4 * 4. k = 16. ...i hope

            Console.WriteLine(k); // ouputs 16? YAY



        }
    }
}
