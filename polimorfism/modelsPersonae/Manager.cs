using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfism.modelsPersonae
{
    public class Manager : Persoana
    {
        private bool manageClient;
        private bool manageAngajati;
        private bool coordonator;

        public override void Atributie()
        {
            Console.WriteLine("Persoana este manager");
        }
        public Manager(bool manageClient, bool manageAngajati, bool coordonator)
        {
            this.manageClient = manageClient;
            this.manageAngajati = manageAngajati;
            this.coordonator = coordonator;
        }

        public Manager()
        {

        }
        public bool ManageClient
        {
            get { return this.manageClient; }
            set { this.manageClient = value; }
        }

        public bool MageAngajati
        {
            get { return this.manageAngajati; }
            set { this.manageAngajati = value; }
        }

        public bool Coordonator
        {
            get { return this.coordonator; }
            set { this.coordonator = value; }
        }

        public override string descriere()
        {
            string text = base.descriere();

            if (this.manageAngajati == true)
            {
                text += "Managerul monitorizeaza angajatii\n";
            }
            else
            {
                text += "Managerul nu monitorizeaza angajatii\n";
            }

            if (this.ManageClient == true)
            {
                text += "Managerul monitorizeaza clientii\n";
            }
            else
            {
                text += "Managerul nu monitorizeaza clientii\n";
            }

            if(this.coordonator == true)
            {
                text += "Managerul este coordonator\n";
            }
            else
            {
                text += "Managerul nu este coordonator\n";
            }

            return text;
        }
    }
}
