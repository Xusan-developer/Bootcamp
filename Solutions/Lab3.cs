using System;

namespace bootcamp.Solutions
{
    public class Lab3
    {
        public void Problem4()
        {
            string str = Console.ReadLine();
            int son = int.Parse(str);

            Console.WriteLine(son/10000 + "!" + son / 1000 % 10 + "!" + son / 100 % 10 + "!" + son / 10 % 10 + "!" + son % 10);
        }
        public void Problem3_5()
        {
            Console.Write("Enter upper case: ");
            string uppercase = Console.ReadLine();

            char lover = char.Parse(uppercase);
            Console.Write("Upper Case: {0}", (char)(lover+32));

        }
        public void Problem3_4()
        {
            Console.Write("Enter lower case: ");
            string lowerCase = Console.ReadLine();

            char upper = char.Parse(lowerCase);
            Console.Write("Upper Case: {0}", (char)(upper-32));

        }
        public void Problem3_3()
        {
            Console.Write("Enter a real number: ");
            double num = Convert.ToDouble(Console.ReadLine());

            Console.Write("Round off: ");
            Console.WriteLine(Math.Round(num));

        }
        public void Problem3_2()
        {
            Console.Write("Enter width: ");
            string width = Console.ReadLine();

            Console.Write("Enter Length: ");
            string length = Console.ReadLine();

            Console.Write("Area is: ");

            float w = float.Parse(width);
            float l = float.Parse(length);
            Console.WriteLine(w * l);
        }
        public void Problem3_1()
        {
            System.Console.Write("Sonni kiriting: ");
            string son = Console.ReadLine();
            
            int num = int.Parse(son);
            System.Console.WriteLine($"Natija (int): {son}");

            char harf = (char) num;
            System.Console.WriteLine($"Natija (char): {harf}");
        }
    }
}