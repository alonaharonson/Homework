using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            shela1();
        }
        public static void shela1()
        {
            int sales,sumtotal=0;
            string name;
            int counter = 0;//סופר כמה מכירות היו 
            int sold = 0;//כמה היו בכללי
            Console.WriteLine("hello, whats your name?");
            name = Console.ReadLine();
            while (name != "")
            {
                sold++;
                int sum = 0;
                for (int i = 1; i <= 3; i++)             
                {
                    Console.WriteLine("how much money you made today?");
                    sales = int.Parse(Console.ReadLine());
                    sum = sum + sales;
                    
                }
                sumtotal = sumtotal + sum;
                Console.WriteLine("hello " + name + " your sales is " + sum);
                Console.WriteLine("your avg of the all month " + sum / 3.0);
                Console.WriteLine("hello, whats your name?");
                name = Console.ReadLine();
                /*shela1();*/
            }
            Console.WriteLine("avg: " + (double)sumtotal / sold);



        }
        public static void shela2()
        {
            int n;
            Console.WriteLine( " enter a number ");
            n = int.Parse(Console.ReadLine());
            string str = "";
            for (int i = 1; i <= n; i++)
            {
                str = str + i ;
                Console.WriteLine( str);
            }
        }
        public static void shela3()
        {
            int n;
            Console.WriteLine(" enter a number");
            n = int.Parse(Console.ReadLine());
           
            if (n >= 1)
            {
                string str = "";
                for (int i = 1; i <= n; i++)
                {
                    str = str + i;
                    Console.WriteLine(str);
                                 
                }
                
                for (int i = n; i > 0; i--)
                {
                    string str2 = "";
                    for (int j = 1; j < i ; j++)
                    {
                        str2 = str2 + j;
                    }
                    Console.WriteLine(str2);
                }

            }
        }
        public static void shela4()
        {
            int n;
            Console.WriteLine(" enter a number");
            n = int.Parse(Console.ReadLine());
            
            if (n >= 1)
            {
                string str = "";
                for (int i = n; i > 0; i--)
                {
                    string str2 = "";
                    for (int j = 1; j <= i; j++)
                    {
                        str2 = str2 + j;
                    }
                    Console.WriteLine(str2);
                }
                for (int i = 1; i <=n; i++)
                {
                    str = str + i;
                    Console.WriteLine(str);

                }

                

            }
        }
        public static void shela5()
        {
            int num, maxnum = 0;
            Console.WriteLine(" enter a number");
            num = int.Parse(Console.ReadLine());
            maxnum = num % 10;
            num /= 10;
            while (num > 0)
            {
                int currentdigit = num % 10;    
                if (currentdigit >= maxnum)
                {
                    maxnum = currentdigit;
                    
                }
                num /= 10;
            }
            num /= 10;
            Console.WriteLine(maxnum);
           


        }

    }
}
