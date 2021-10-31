using System;

namespace bootcamp.Solutions
{
    public class Lab6
    {
        public void Problem6_13()
        {
            int sum = 0;
            int count = 0;
            while(true)
            {
                int son = int.Parse(Console.ReadLine());
                if(son==0)
                {
                    break;
                }
                sum+=son;
                count++;
            }
            Console.WriteLine($"{sum} {(double)sum / (double)count} {count}");
        }
        
        public void Problem6_7()
        {
            for(int i=1; i<=10; i++ )
            {
                for(int k = i; k <= (i + 9); k++)
                {
                    Console.Write("{0}", k%10);

                }
                Console.WriteLine();
                
            }
        }
        public void Problem6_6()
        {
            int qator = int.Parse(Console.ReadLine());
            for(int i = 1; i <= qator; i++ )
            {
                int space = qator-i;
                while(space>0)
                {
                    Console.Write(" ");
                    space--;
                }
                int stars = i*2-1;
                while(stars>0)
                {
                    Console.Write("*");
                    stars--;
                }
                Console.WriteLine();
            }
            for(int i = qator-1; ; i--)
            {
                int space = qator-1;
                while(space>0)
                {
                    Console.Write(" ");
                    space--;
                }
                int stars = i*2-1;
                while(stars>0)
                {
                    Console.Write("*");
                    stars--;
                }
                Console.WriteLine();
            }
        }
        public void Problem6_5()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            for (int i = a; i > 0; i--)
            {
                if (a % i == 0)
                {
                    if (b % i == 0)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
        
        }
        public void Problem6_4()
        {
            for(int i = 2; i <= 10; i++)
            {
                Console.Write($"{i}!=");
                int fac = i;
                for(int q = 1; q < i; q++)
                {
                    Console.Write($"{q}*");
                    fac*=q;
                }
                Console.WriteLine($"{i}={fac}");
            }
        }
        public void Problem6_3()
        {
            int sum = 0;

            while(true)
            {
                int son = int.Parse(Console.ReadLine());
                if(son==0)
                {
                    break;
                }
                sum+=son;
            }
            Console.WriteLine(sum);
        }
        public void Problem6_2()
        {
            int n = int.Parse(Console.ReadLine());
            while(true)
            {
                int taxmin = int.Parse(Console.ReadLine());
                if(taxmin<n)
                {
                    Console.WriteLine($"{taxmin}<" );
                }
                else if(taxmin>n)
                {
                    Console.WriteLine($"{taxmin}>");
                }
                else
                {
                    Console.WriteLine(taxmin);
                    break;
                }
            }
        }
        public void Problem6_1()
        {
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            while(i<=n)
            {
                
                if(n % i == 0)
                {
                    Console.WriteLine(i + " ");
                }
                i++;
                
            }
        }
    }
}