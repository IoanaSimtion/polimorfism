using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfism.modelsPersonae
{
    public class Receptioner : Persoana
    {
        public bool vorbesteEngleza;
        public int salariu;

        public override void Atributie()
        {
            Console.WriteLine("Persoana este receptioner");
        }
        public Receptioner(bool vorbesteEngleza, int salariu)
        {
            this.vorbesteEngleza = vorbesteEngleza;
            this.salariu = salariu;
        }

        public Receptioner()
        {

        }

        public bool VorbesteEngleza
        {
            get { return this.vorbesteEngleza; }
            set { this.vorbesteEngleza = value; }
        }

        public int Salariu
        {
            get { return this.salariu; }
            set { this.salariu = value; }
        } 

        public override string descriere()
        {
            string text = base.descriere();

            if (this.vorbesteEngleza == true)
            {
                text += "Receptionerul vorbeste engleza\n";
            }
            else
            {
                text += "Receptionerul nu vorbeste engleza\n";
            }

            text += "Salariu receptioner: " + this.salariu.ToString() + "\n";

            return text;
        }
    }
}
