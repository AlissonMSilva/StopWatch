using System;
using System.Threading;

namespace StopWatch2
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("s = Segundos => 10s = 10 segundos");
            Console.WriteLine("m = Minutos => 1m = 1 minuto");
            Console.WriteLine("0 = Sair ");
            

            Console.WriteLine("Quanto tempo deseja? ");
            string data = Console.ReadLine().ToLower();
            //Pega o ultimo caracter de um array de String.Substring(local,numero de caracters)
            char type = char.Parse(data.Substring(data.Length - 1,1));
            int time=int.Parse(data.Substring(0,data.Length-1));

            int muliplier=1;
            
            if(type=='m')muliplier=60;

            if(time==0) System.Environment.Exit(0);

            Console.WriteLine("1 - Contagem Regressiva");
            Console.WriteLine("2 - Contagem Progressiva");

            int number=int.Parse(Console.ReadLine());

            PreStart(time*muliplier,number);
        }

        static void PreStart(int time,int num)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Go...");
            Thread.Sleep(2000);
            if(num==2)Start(time);
            StartDegress(time);
        }
        static void StartDegress(int currentTime)
        {
            int time=0;
            for(int i=currentTime;i>time;i--)
            {
                Console.Clear();
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("StopWatch Finalizado");
            Thread.Sleep(2500);
            Menu();
        }
        static void Start(int time)
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
            Console.WriteLine("StopWatch Finalizado");
            Thread.Sleep(2500);
            Menu();
        }

    }
}
