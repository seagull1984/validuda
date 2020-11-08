using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ConsoleApp2
{
    
    class Program 
    {

        static void Main(string[] args)
        {
            Console.WriteLine("начало выполнения работу: {0}", DateTime.Now);
            Console.Write("Name fas: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!!!");
            SumMas();
            Pasvordiki();
            Console.WriteLine("конец выполнения работы: {0}", DateTime.Now);
            Console.ReadKey();
        }
        static void SumMas()
        {
            string[] sum = new string[5];
            Console.WriteLine("ведите пять чего нибудь ");
            for (int i = 0; i < 5; i++)
            {
                sum[i] = Console.ReadLine();
            }
            for(int i = 4; i > -1; i--)
            {
                Console.Write(sum[i]);
                Console.WriteLine();
            }
        }
        static void Pasvordiki()
        {
            int pasvord = 5800389;
            int i = 0;
            while (true)
            {
                Console.Write("ведите пароль: ");
                int pasvordYou = Convert.ToInt32(Console.ReadLine());
                if (pasvord == pasvordYou)
                {
                    Console.WriteLine("доступ разрешон!");
                    break;
                }
                else
                {
                    Console.WriteLine("неверный пароль");
                    Console.WriteLine($"попытка номер{i++}");
                }
            }
        }
    }
}
