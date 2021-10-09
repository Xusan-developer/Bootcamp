using System;

namespace bootcamp.Solutions
{
    public class Lab4
    {
        public void Problem10()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            int A = int.Parse(a);
            int B = int.Parse(b);

            if(A>B)
            {
                Console.WriteLine(A/B);
                Console.WriteLine(A%B);
            }
            else
            {
                Console.WriteLine(B/A);
                Console.WriteLine(B%A);
            }

        }
        public void Problem9()
        {
            string n = Console.ReadLine();
            string m = Console.ReadLine();
            int N = int.Parse(n);
            int M = int.Parse(m);
            

            Console.WriteLine( N>M ? N:M );
        }
        public void Problem8()
        {
            string str = Console.ReadLine();
            int son = int.Parse(str);

            Console.WriteLine(son%2==0 ? "even":"odd");
        }
        public void Problem7()
        {
            string str = Console.ReadLine();
            char harf = char.Parse(str);

            Console.WriteLine((harf > 'A' && harf > 'Z' || harf > 'a' && harf > 'z') ? 1:0);
        }
        public void Problem6()
        {
            string str = Console.ReadLine();
            int son = int.Parse(str);

            Console.WriteLine(( son>=20 && son <= 30) ? 1:0);
        }
        public void Problem5()
        {
            string str = Console.ReadLine();
            float length = float.Parse(str);

            float P = 3.14f;
            float r = length / (2*P);
            float area = P*r*r;
            Console.WriteLine(Math.Round(area));
        }
        public void Problem4()
        {
            string str = Console.ReadLine();
            int num = int.Parse(str);
            Console.WriteLine( ( num/100%10 ) < 5 ? (num / 1000) * 1000 : (num / 1000 + 1) * 1000);
        }
        public void Problem3()
        {
            string str = Console.ReadLine();
            int num = int.Parse(str);

            Console.WriteLine(num/100%10);
        }

        public void Problem2()
        {
            string str = Console.ReadLine();
            int son = int.Parse(str);

            Console.WriteLine((son / 3600).ToString().PadLeft(2,'0') + ":" + (son % 3600 / 60).ToString().PadLeft(2,'0') + ":" + (son % 60).ToString().PadLeft(2,'0'));
        }
        public void Problem1()
        {
            string str = Console.ReadLine();
            int son = int.Parse(str);

            Console.WriteLine(son/10000 + "!" + son / 1000 % 10 + "!" + son / 100 % 10 + "!" + son / 10 % 10 + "!" + son % 10);
        }
    }
}