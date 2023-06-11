using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfism.models
{
    public class Vehicul
    {
        private string id;
        private double pret;
        private string marca;

        public Vehicul(string ID, double pret, string marca)
        {
            id = ID;
            this.pret = pret;
            this.marca = marca;
        }

        public Vehicul()
        {

        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public double Pret
        {
            get { return pret; }
            set { pret = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string descriereVehicul()
        {
            string text = "";

            text += "Id: " + id + "\n";
            text += "Marca: " + marca + "\n";
            text += "Pret: " + pret.ToString() + "\n";

            return text;
        }
    }
}
