using polimorfism.exemplu2;
using polimorfism.modelsExemplu;
using polimorfism.modelsPersonae;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {


            FairyTale tale;

            Console.WriteLine("FAIRY TALE\n");
            tale = new FairyTale();
            tale.act0();
           

            Console.WriteLine("UNHAPPY TALE\n");
            tale = new UnhappyTale();
            tale.act0();
            
        }
    }
}