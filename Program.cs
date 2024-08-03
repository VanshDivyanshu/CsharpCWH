using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Greet(string name)
        {
            Console.WriteLine("Good Morning " + name);
        }

        static float Average(int a, int b, int c)
        {
            float sum = a + b + c;
            return sum / 3;
        }

        static float Average(int a, int b)
        {
            float sum = a + b;
            return sum / 2;
        }
        static void Main(string[] args)
        {
            // Single line comment example - This is importaant for debugging. do not remove
            /*
            Multi - line comment example:
            This is a multi-line comment 
            spanning multiple lines 
            */

            /*
            int harry = 34; // Integer variable 
            string inp = Console.ReadLine();
            Console.WriteLine(inp);
            // Console.WriteLine("Hello World");
            // Console.Write("Hello Harry");
            // Console.WriteLine("I love C#");
            // Console.ReadLine();
            */

            /* 
            Data types in C#:
            Integer - int 34; --> 4 bytes
            Long - long harry; --> 8 bytes 
            Floating point number - float that; --> 4 bytes
            Double - double harry; --> 8 bytes 
            Character - char a = 'A'; --> 1 bytes
            Boolean - bool isGreat = true; --> 1 bit
            String - string inp = "Harry"; --> 2 bytes per character
            */

            // Data types examples:
            //int a = 34;
            //float b = 34.4F;
            //double c = 34.4D;
            //bool isGreat = true;
            //char d = 'r';
            //string e =  "this is a string";
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(isGreat);
            //Console.WriteLine(d);
            //Console.WriteLine(e);
            //Console.ReadLine();


            //Type Casting
            //There are two types of type casting 
            //1. Implicit Casting
            //char to int to long to float to double 
            //2. Explicit Casting 
            //int x = (int)3.4;
            //float x1 = (float)3.5;
            //Console.WriteLine(x1);
            //float varr = Convert.ToInt64(3.55);
            ////Convert.ToDouble
            ////Convert.ToString
            //string sx = "Random string";
            //double y = x;
            //int z = 'y';
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            //Console.ReadLine();

            //Console.WriteLine("Enter your name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hey I am " + name);

            //Console.WriteLine("How many cnadles do you want?");
            //string can = Console.ReadLine();
            //Console.WriteLine("You will get 4 more candies: " + (Convert.ToInt32(can) + 4));
            //Console.ReadLine();


            /*
            Operators in C#
            1. Arithmetic operators 
            2. Assignment operators 
            3. Logical operators 
            4. Comparison operators 
            */
            //int a = 4;
            //int b = 5;
            //Console.WriteLine("The value of a + b is: " + (a + b));
            //Console.WriteLine("The value of a - b is: " + (a - b));
            //Console.WriteLine("The value of a * b is: " + (a * b));
            //Console.WriteLine("The value of a / b is: " + (a / b));
            //Console.ReadLine();


            /*
            Assignment operators 
            int a = 4;
            int b = a;
            b += 4;
            //b -= 4;
            //b *= 4;
            //b /= 4;
            Console.WriteLine(b);
            Console.ReadLine();
            */

            /*
            //Logical operators
            //Console.WriteLine(true && true);
            //Console.WriteLine(true && false);
            //Console.WriteLine(false && false);
            //Console.ReadLine();

            //Console.WriteLine(true || true);
            //Console.WriteLine(true || false);
            //Console.WriteLine(false || false);
            //Console.ReadLine();  

            //Console.WriteLine(!true);
            //Console.WriteLine(!false);
            //Console.ReadLine();  
            */

            /*
            //Comparison operators
            Console.WriteLine(324 > 555);
            Console.WriteLine(324 <= 555);
            Console.WriteLine(324 >= 555);
            Console.WriteLine(324 != 555);
            Console.WriteLine(324 == 555);
            Console.ReadLine();
            */

            //int a = Math.Min(34,65); 
            //double a = Math.Sqrt(29);
            //int a = Math.Abs(-24);
            //Console.WriteLine(a);
            //Console.ReadLine();

            //string hello = "Hello world this is vansh.";
            //Console.WriteLine(hello.Length);
            //Console.WriteLine(hello.ToUpper());
            //Console.WriteLine(hello.ToLower());
            //Console.WriteLine(hello + " You are nice");
            //Console.WriteLine(string.Concat(hello , " You are nice"));
            //Console.ReadLine();

            //string name = Console.ReadLine();
            //string candies = Console.ReadLine();
            //Console.WriteLine($"Your name is {name}. You will get {candies} candies");
            //Console.ReadLine();


            //string hello = "Hello world this is \"vansh\".";
            ////Console.WriteLine(hello[1]);
            //Console.WriteLine(hello.IndexOf("is"));
            //Console.WriteLine(hello.Substring(12));
            //Console.WriteLine(hello);
            //Console.ReadLine();


            //Console.WriteLine("Enter your name: ");
            //string ageStr = Console.ReadLine();
            //int age = Convert.ToInt32(ageStr);
            //if (age < 2)
            //{
            //    Console.WriteLine("You are just born");
            //}
            //else if (age < 10)
            //{
            //    Console.WriteLine("Finish your high school first");
            //}
            //else if (age < 18)
            //{
            //    Console.WriteLine("You are below 18");
            //}
            //else if (age < 75)
            //{
            //    Console.WriteLine("You can drive");
            //}
            //else
            //{
            //    Console.WriteLine("You cannot drive");
            //}
            //Console.ReadLine();


            //int age = 20;
            //switch (age)
            //{
            //    case 18:
            //        Console.WriteLine("Please wait for a year");
            //        break;
            //    case 20:
            //        Console.WriteLine("You are 20");
            //        break;
            //    default:
            //        Console.WriteLine("Enjoy!");
            //        break;  
            //}
            //Console.ReadLine();


            //Loops
            //Console.WriteLine("1\n2\n3\n4\n5");

            //int i = 1;
            //while (i <= 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //Console.ReadLine();            

            //int i = 1;
            //do 
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i <= 5) ;
            //Console.ReadLine();

            //for (int i = 1; i <= 5; i++)
            //{
            //    if(i == 1)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //    //break;
            //}
            //Console.ReadLine();


            //Greet("Vansh");
            //Greet("Divyanshu");

            //Console.WriteLine(Average(2,6,8));
            //float temp = Average(9,3,0);
            //Console.WriteLine(temp);
            //Console.WriteLine(Average(3,3,3));

            //Console.WriteLine(Average(3,3));
            //Console.ReadLine();



            Class1 tom = new Class1();
            Console.WriteLine(tom.getHealth());
            tom.setHealth(59);
            Console.WriteLine(tom.getHealth());
            Console.ReadLine();
        }
    }
}

