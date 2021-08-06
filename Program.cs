using System;

namespace day5
{
    class Program
    {
        public static void Division()
        {
            int q = 10 / 2;
            int r = 10 % 2;
            Console.WriteLine("quotient: " + q + "remainder: " + r);
        }

        public static void swap(int a, int b)
        {
            int temp;
            Console.WriteLine("before swap: " + a + " & " + b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("before swap: " + a + " & " + b);
        }

        public static void even(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine(a + " is an even no.");
            }
            else
            {
                Console.WriteLine(a + " is a odd no.");
            }

        }

        public static void vowel(char a)
        {
            switch (a)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine(a+ " is a vowel");
                    break;
                default:
                    Console.WriteLine(a + " is a consonant.");
                    break;
            }
        }

        public static void largest (int a,int b,int c)
        {
            if (a >= b && a >= c)
            {
                Console.WriteLine(a + " is largest amongst the 3 numbers.");
            }
            else if(b >= a && b >= c)
            {
                Console.WriteLine(b + " is largest amongst the 3 numbers.");
            }
            else
            {
                Console.WriteLine(c + " is largest amongst the 3 numbers.");
            }
        }

        public static void coins(int n)
        {
            float hc = 0;
            Random r = new Random();            
            for (int i = 0; i < n; i++)
            {
                int a = r.Next(0, 2);
                if (a == 1)
                {
                    hc += 1;
                }
            }            
            float hp = (hc / n) * 100;
            float tp = 100 - hp;
            Console.WriteLine("no of times heads occur: "+hp+ "% no of times tails occur: "+tp+"% in "+n+" times.");
        }

        public static void leapyear(int n)
        {
            if (n > 999)
            {
                if (n%4==0 && n%100!=0)
                {
                    Console.WriteLine(n + " is a leap year.");
                }
                else
                {
                    Console.WriteLine(n + " is not a leap year.");
                }
            }
            else
            {
                Console.WriteLine(n + " is not a 4 digit no.");
            }
        }

        public static void twoPower(int n)
        {
            int a;
            if (0 <= n && n < 31)
            {
                Console.WriteLine("2 to the power 0 to 2 to the power "+n+" table ::");
                for (int i = 0; i < n; i++)
                {
                    a = (int)Math.Pow(2, i);
                    Console.Write(a+" ");
                }
            }
        }

        public static void harmonic(int n)
        {
            for (int i = 1; i < n; i++)
            {
                Console.Write("1/"+i+" + ");
            }
            Console.WriteLine("1/" + n);
        }

        public static void primefactors(int m)
        {
            Console.WriteLine("prime factors of "+m+" are ::");
            for (int i = 2; i <= m/2; i++)
            {
                if (m % i == 0)
                {
                    Console.Write(+i+" ");
                }
            }            
        }

        static void Main(string[] args)
        {
            int w=1;
            while (w ==1)
            {
                Console.WriteLine();
                Console.WriteLine("enter choice::");
                Console.WriteLine("0. exit menu");
                Console.WriteLine("1. coin percentage");
                Console.WriteLine("2. Leap Year");
                Console.WriteLine("3. Power of 2");
                Console.WriteLine("4. Harmonic Number");
                Console.WriteLine("5. Prime Factors");
                Console.WriteLine("6. Compute Quotient and Remainder");
                Console.WriteLine("7. Swap Two Numbers");
                Console.WriteLine("8. a Number is Even or Odd");
                Console.WriteLine("9. Alphabet is Vowel or Consonant");
                Console.WriteLine("10. the Largest Among Three Numbers");
                int c = int.Parse(Console.ReadLine());
                switch (c)
                {
                    case 0:
                        w = 0;
                        break;
                    case 1:
                        coins(10);
                        break;
                    case 2:
                        leapyear(2012);
                        break;
                    case 3:
                        twoPower(10);
                        break;
                    case 4:
                        harmonic(10);
                        break;
                    case 5:
                        primefactors(20);
                        break;
                    case 6:
                        Division();
                        break;
                    case 7:
                        swap(3, 7);
                        break;
                    case 8:
                        even(3);
                        break;
                    case 9:
                        vowel('e');
                        break;
                    case 10:
                        largest(1, 2, 3);
                        break;
                    default:
                        break;
                }
            }
            
        }
    }
}
