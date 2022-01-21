using System;
using System.Threading;

namespace Stopwatch
{
    class program
    {
        static void Main(string[] args)
        {

            Menu();

        }


        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S - Segundo => 10s = 10 sgundos");
            Console.WriteLine("M - Minuto => 1m = 1 minuto");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("É para contar quanto tempo?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1,1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            Console.Clear();
            Console.WriteLine("Decrescente ou crescente?");
            Console.WriteLine("D para decrescente e C para crescente");

            char ordem = char.Parse(Console.ReadLine().ToLower());

            if(type == 'm')
                multiplier = 60;
            

            if(time == 0)
                System.Environment.Exit(0);
            

            PreStart(time * multiplier, ordem);

            

           

            
        }

        static void PreStart(int time, char ordemEscolha)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(1000);

            if(ordemEscolha == 'd')
            StartDecrescente(time);

            if(ordemEscolha == 'c')
            StartCrescente(time);

        }

        
        static void StartCrescente(int time)
        {   
           
            
            int currentTime = 0;

            while (currentTime != time)
            {
                 Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            
            Console.Clear();
            Console.WriteLine("Finalizou!");
            Thread.Sleep(2000);

        }

        static void StartDecrescente(int time)
        {   
           
            
            int currentTime = time;

            while (currentTime != 0)
            {
                 Console.Clear();
                currentTime--;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            
            Console.Clear();
            Console.WriteLine("Finalizou!");
            Thread.Sleep(2000);

        }



    }



}
