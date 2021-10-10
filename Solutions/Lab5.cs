using System;

namespace bootcamp.Solutions
{
    public class Lab5
    {
        public void Problem11()
        {
            Console.WriteLine("MENU\n");
            Console.WriteLine("1.Americano(500 sum)");
            Console.WriteLine("2.Caffe Latte(400 sum)");
            Console.WriteLine("4.Lemon Tea (300 sum)");
            
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sum = 0;

            switch(a)
            {
                case 1:
                    Console.WriteLine("Americano");
                    sum = b-500;
                    break;
                case 2:
                    Console.WriteLine("Caffe Latte");
                    sum = b-400;
                    break;
                case 3:
                    Console.WriteLine("Lemon Tea");
                    sum = b-300;
                    break;
            }
            Console.WriteLine($"{ sum / 500 } { sum % 500 / 100 }");

        }
        public void Problem10()
        {
            int a = int.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if(b=='+')
            {
                Console.WriteLine(a+c);
            }
            else if(b=='-')
            {
                Console.WriteLine(a-c);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        public void Problem9()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            int E = int.Parse(Console.ReadLine());
            int F = int.Parse(Console.ReadLine());

            int strike = 0;
            int boal = 0;
            
            if(A==D)
            {
                strike++;
            }
            else if(A==E || A==F) 
            {
                boal++;
            }
            if(B==E)
            {
                strike++;
            }
            else if(B==D || B==F)
            {
                boal++;
            }
            if(C==F)
            {
                strike++;
            }
            else if(C==D || C==E)
            {
                boal++;
            }
            
            Console.WriteLine("{0}S{1}B",strike, boal);
            
        }
        public void Problem8()
        {
            string str = Console.ReadLine();
            char harf = char.Parse(str);

            if(harf >= 'A' && harf <= 'Z')
            {
                Console.WriteLine((char)(harf+32));
            }
            else if(harf >= 'a' && harf <= 'z')
            {
                Console.WriteLine((char)(harf-32));
            }
            else
            {
                Console.WriteLine("NONE");
            }
        }
        public void Problem7()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            if(m<n)
            {
                Console.WriteLine("UP");
            }
            else if(m>n)
            {
                Console.WriteLine("DOWN");
            }
            else
            {
                Console.WriteLine("CORRECT");
            }
            int c = int.Parse(Console.ReadLine());
            if(c<n)
            {
                Console.WriteLine("UP");
            }
            else if(c>n)
            {
                Console.WriteLine("DOWN");
            }
            else
            {
                Console.WriteLine("CORRECT");
            }
            
        }
        public void Problem6()
        {
            string str = Console.ReadLine();
            int yil = int.Parse(str);

            if( yil % 4 == 0 )
            {
                if( yil % 100 == 0 )
                {
                    if( yil % 400 == 0 )
                    {
                        Console.WriteLine("Leap year");
                    }
                    else
                    {
                        Console.WriteLine("Normal year");
                    }
                }
                else
                {
                    Console.WriteLine("Leap year");
                }
            }
            else
            {
                Console.WriteLine("Normal year");
            }
        }
        public void Problem5()
        {
            string str = Console.ReadLine();
            int son = int.Parse(str);

            if( son % 2 == 0 && son % 3 == 0 && son % 5 == 0 )
            {
                Console.WriteLine('A');
            }
            else if( son % 2 == 0 && son % 3 == 0 )
            {
                Console.WriteLine('B');
            }
            else if(son % 2 == 0 && son % 5 == 0)
            {
                Console.WriteLine('C');
            }
            else if( son % 3 == 0 && son % 5 == 0)
            {
                Console.WriteLine('D');
            }
            else if( son % 2 == 0 || son % 3 == 0 || son % 5 == 0 )
            {
                Console.WriteLine('E');
            }
            else
            {
                Console.WriteLine('N');
            }
            
        }
        public void Problem4()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();

            int A = int.Parse(a);
            int B = int.Parse(b);
            int C = int.Parse(c);

            if(A>B && A>C && B>C)
            {
                Console.WriteLine($"{A} {C}");
            }
            else if(A>B && A>C && C>B)
            {
                Console.WriteLine($"{A} {B}");
            }
            else if(B>A && B>C && A>C)
            {
                Console.WriteLine($"{B} {C}");
            }
            else if(B>A && B>C && C>A)
            {
                Console.WriteLine($"{B} {A}");
            }
            else if(C>A && C>B && B>A)
            {
                Console.WriteLine($"{C} {A}");
            }
            else if(C>A && C>B && A>B)
            {
                Console.WriteLine($"{C} {B}");
            }
        }
        public void Problem3()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            int A = int.Parse(a);
            int B = int.Parse(b);

            if(A>B)
            {
                Console.WriteLine(A);
            }
            else 
            {
                Console.WriteLine(B);
            }

        }
        public void Problem2()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int A = int.Parse(a);
            int B = int.Parse(b);
        
            if( B==A*A )
            {
                Console.WriteLine($"{A}*{A}=" + A*A);
            }
            else if(A==B*B)
            {
                Console.WriteLine($"{B}*{B}=" + B*B);
            }
            else
            {
                Console.WriteLine("none");
            }
        }
        public void Problem1()
        {
            string str = Console.ReadLine();
            int son = int.Parse(str);

            if(son < 0)
            {
                Console.WriteLine("ichkarida o'yna");
            }
            else if( son > 0 && son < 40 )
            {
                Console.WriteLine("Tashqarida o'yna");
            }
            else 
            {
                Console.WriteLine("ichkarida o'yna");
            }
        }
    }
}