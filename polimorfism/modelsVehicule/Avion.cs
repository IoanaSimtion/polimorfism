using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfism.models
{
    public class Avion : Vehicul
    {
        private string modelAripi;
        private string tipAvion;

        public Avion()
        {

        }

        public Avion(string modelAripi, string tip)
        {
            this.modelAripi = modelAripi;
            tipAvion = tip;
        }

        public string ModelAripi
        {
            get { return modelAripi; }
            set { modelAripi = value; }
        }

        public string Tip
        {
            get { return tipAvion; }
            set { tipAvion = value; }
        }

        public string descriereAvion()
        {
            string text = descriereVehicul();

            text += "Tip avion: " + tipAvion + "\n";
            text += "Model aripi: " + modelAripi + "\n";

            return text;
        }
    }
}
