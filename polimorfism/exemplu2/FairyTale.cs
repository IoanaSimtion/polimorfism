using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfism.exemplu2
{
    public class FairyTale
    {
        public void act0()
        {
            Console.WriteLine("0 Inceput poveste originala\n");
            act1();
        }

        public virtual void act1()
        {
            Console.WriteLine("1 Printesa intalneste broscoiul\n");
            act2();
        }

        public void act2()
        {
            Console.WriteLine("2 Printesa saruta broscoiul\n");
            act3();
        }
        
        public virtual void act3()
        {
            Console.WriteLine("3 Broscoiul se transforma in Print\n");
            act4();
        }

        public virtual void act4()
        {
            Console.WriteLine("4 Si au trait multi ani fericiti\n");
            act5();
        }

        public void act5()
        {
            Console.WriteLine("5 Sfarsit fericit\n");
        }
    }
}
