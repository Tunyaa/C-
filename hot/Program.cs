using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hot
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Random rnd = new Random();
            int value = rnd.Next(0, 100);
            
            Console.WriteLine("Введите ваше число:");
            int num = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"{value}"); проверка сгенерированного числа
            while (num != value)
            {
                while (num < value)
                {
                    Console.WriteLine("Холодно");
                    num = Convert.ToInt32(Console.ReadLine());

                }

                while (num > value)
                {
                    Console.WriteLine("Горячо");
                    num = Convert.ToInt32(Console.ReadLine());

                }
            }



            Console.WriteLine("Успех");
            
            Console.ReadLine();

            
        }
    }
}
