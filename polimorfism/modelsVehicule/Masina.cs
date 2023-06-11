using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfism.models
{
    public class Masina : Vehicul
    {
        private int an;
        private string model;

        public Masina()
        {

        }

        public Masina(int an, string model)
        {
            this.an = an;
            this.model = model;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int An
        {
            get { return an; }
            set { an = value; }
        }

        public string descriereMasina()
        {
            string text = descriereVehicul();

            text += "Model: " + model + "\n";
            text += "An: " + an.ToString() + "\n";

            return text;
        }
    }
}
