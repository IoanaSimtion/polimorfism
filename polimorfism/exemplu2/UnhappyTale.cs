using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfism.exemplu2
{
    public class UnhappyTale : FairyTale
    {
        public void act0()
        {
            Console.WriteLine("0 Inceput poveste modificata\n");
            act1();
        }

        public void act2()
        {
            Console.WriteLine("2 Printesa atinge broscoiul\n");
            act3();
        }

        public override void act3()
        {
            Console.WriteLine("3 Broscoiul ramane broscoi\n");
            act4();
        }

        public override void act4()
        {
            Console.WriteLine("4 Printesa fuge ingrozita\n");
            act5();
        }

        public void act5()
        {
            Console.WriteLine("5 Sfarsit nu prea fericit\n");
        }
    }
}
