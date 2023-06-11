using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfism.modelsPersonae
{
    public class Persoana
    {
        private string nume;
        private string prenume;
        private int varsta;

        public virtual void Atributie()
        {
            Console.WriteLine("Persoana are o atributie");
        }
        public Persoana(string nume, string prenume, int varsta)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.varsta = varsta;
        }

        public Persoana()
        {

        }

        public string Nume
        {
            get { return this.nume; }
            set { this.nume = value; }
        }

        public string Prenume
        {
            get { return this.prenume; }
            set { this.prenume = value; }
        }

        public int Varsta
        {
            get { return this.varsta; }
            set { this.varsta = value; }
        }

        public virtual string descriere()
        {
            string text = "";

            text += "Nume: " + this.nume + "\n";
            text += "Prenume: " + this.prenume + "\n";
            text += "Varsta: " + this.varsta.ToString() + "\n";

            return text;
        }
    }
}
