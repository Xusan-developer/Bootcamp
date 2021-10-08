using System;

namespace bootcamp.Solutions
{
    public class Lab2
    {
        public void Problem10()
        {
            
        }
        public void Problem9()
        {
            int fib1=0, fib2=1, fib3=fib2+fib1;
            System.Console.WriteLine();
        }
        public void Problem8()
        {
            int a = 1, b = 2, c = 3, d = 4, e = 5;

            System.Console.WriteLine(a + "!=" + a*a);
            System.Console.WriteLine(b + "!=" + b*a);
            System.Console.WriteLine(c + "!=" + c*b);
            System.Console.WriteLine(d + "!=" + d*b*c);
            System.Console.WriteLine(e + "!=" + e*d*c*b);
        }
        public void Problem7()
        {
            System.Console.Write("Enter integer: ");
            string son = System.Console.ReadLine();
            int n = int.Parse(son);

            System.Console.WriteLine($"{son}*1={n*1}");
            System.Console.WriteLine($"{son}*2={n*2}");
            System.Console.WriteLine($"{son}*3={n*3}");
            System.Console.WriteLine($"{son}*4={n*4}");
            System.Console.WriteLine($"{son}*5={n*5}");
            System.Console.WriteLine($"{son}*6={n*6}");
            System.Console.WriteLine($"{son}*7={n*7}");
            System.Console.WriteLine($"{son}*8={n*8}");
            System.Console.WriteLine($"{son}*9={n*9}");
        }
        public void Problem6()
        {
            System.Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");
            System.Console.WriteLine(" 4   5   6   7   8   9   10");
        }
        public void Problem5()
        {
            System.Console.Write("Enter integer: ");
            string son = System.Console.ReadLine();

            Console.WriteLine(son+son+son+son+son+son);
            Console.WriteLine(son+ "    " +son);
            Console.WriteLine(son+ "    " +son);
            Console.WriteLine(son+son+son+son+son+son);
            
        }
        public void Problem4()
        {
            System.Console.WriteLine("Birthdate");

            System.Console.Write("Enter month: ");
            string month = System.Console.ReadLine();

            System.Console.Write("Enter date : ");
            string date = System.Console.ReadLine();

            System.Console.Write("Birthday is: ");
            string a = month.ToString().PadLeft(2,'0');
            string b = date.ToString().PadLeft(2,'0');
            System.Console.WriteLine("Birthdate is "+ a + "-" + b);
        }
        public void Problem3_1()
        {
            System.Console.WriteLine("Birthdate");

            System.Console.Write("Enter month: ");
            string month = System.Console.ReadLine();

            System.Console.Write("Enter date : ");
            string date = System.Console.ReadLine();

            System.Console.Write("Birthday is: ");
            System.Console.WriteLine($"{month}-{date} (mm-dd)");
            
        }
        public void Problem2()
        {
            System.Console.WriteLine("   A");
            System.Console.WriteLine("  A A");
            System.Console.WriteLine(" AAAAA");
        }
        public void Problem1()
        {
            System.Console.WriteLine("222222");
            System.Console.WriteLine("2    2");
            System.Console.WriteLine("2    2");
            System.Console.WriteLine("222222");
        }
    }
}