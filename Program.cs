using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Lesson7
{
    internal class Program
    {
        static int foo(int x)
        {
            return x;   
        }
        static void foo1()
        {
            Console.WriteLine("Hello!!!");
        }

        static string fooStr()
        {
            return "ZZZZZZZZZZZ";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        static string funcAlex(string name)
        {
            string strFoo = "Hello" + " " + name + "!";
            return strFoo;  
        }

        /// <summary>
        /// Сложение двух чисел
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        static int AddSun(int num1, int num2)
        {
            return num1 + num2; 
        }

        static bool And(bool a, bool b)
        {
            return a && b;
        }

        static string nameFoo(string name)
        {
            if(name == "fool")
            {
                return "Вы использовали недопустимое слово!";
            }

            string sentence = "Hello" + " " + name + "!";    
            return sentence;    
        }

        static int Method(ref int num)
        {
            int b = num*2;
            num = 22;
            return b;   
        }

        static int MetOut(out int num)
        {
            num = 111;
            return num * 333; 
        }

        static void Main(string[] args)
        {
            int x = 5;
            int arg = foo(x);   
            Console.WriteLine(arg);
            for (int i = 0; i < 10; i++) 
            { 
                foo1 ();    
            }
            string str = fooStr();  
            Console.WriteLine(str);
            string str4 = funcAlex("Alex");
            Console.WriteLine(funcAlex("Alex"));
            Console.WriteLine(str4);
            int sum = AddSun(5, 8);
            Console.WriteLine("{0}, {1}, {2}",5, 8, sum );

            Console.WriteLine(And(true, false));

            Console.WriteLine(nameFoo("Sergey"));
            Console.WriteLine(nameFoo("fool"));

            int num333 = 333;
            int result = Method(ref num333);  
            Console.WriteLine("{0}, {1}", result, num333);

            int num111;
            int result22 = MetOut(out num111);
            Console.WriteLine("{0}, {1}", result22, num111);
        }
    }
}
