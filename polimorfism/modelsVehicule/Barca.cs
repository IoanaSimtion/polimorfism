using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfism.models
{
    public class Barca : Vehicul
    {
        private string tipBarca;
        private int greutate;

        public Barca()
        {

        }

        public Barca(string tipBarca, int greutate)
        {
            this.tipBarca = tipBarca;
            this.greutate = greutate;
        }

        public string TipBarca
        {
            get { return tipBarca; }
            set { tipBarca = value; }
        }

        public int Greutate
        {
            get { return greutate; }
            set { greutate = value; }
        }

        public string descriereBarca()
        {
            string text = descriereVehicul();

            text += "Tip barca: " + tipBarca + "\n";
            text += "Greutate: " + greutate.ToString() + "\n";

            return text;
        }
    }
}
