using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfism.modelsPersonae
{
    public class Client : Persoana
    {
        private bool bookedCamera;
        private bool pretAchitat;
        private bool clientNou;

        public override void Atributie()
        {
            Console.WriteLine("Persoana este un client");
        }
        public Client(bool bookedCamera, bool pretAchitat, bool clientNou)
        {
            this.bookedCamera = bookedCamera;
            this.pretAchitat = pretAchitat;
            this.clientNou = clientNou;
        }

        public Client()
        {

        }

        public bool BookedCamera
        {
            get { return this.bookedCamera; }
            set { this.bookedCamera = value; }
        }

        public bool PretAchitat
        {
            get { return this.pretAchitat; }
            set { this.pretAchitat = value; }
        }

        public bool ClientNou
        {
            get { return this.clientNou; }
            set { this.clientNou = value; }
        }

        public override string descriere()
        {
            string text = base.descriere();

            if (this.clientNou == true)
            {
                text += "Clientul este nou\n";
            }
            else{
                text += "Clientul nu este nou\n";
            }

            if (this.bookedCamera == true)
            {
                text += "Clientul a rezervat camera\n";
            }
            else
            {
                text += "Clientul nu a rezervat camera\n";
            }

            if (this.pretAchitat == true)
            {
                text += "Clientul a achitat pretul\n";
            }
            else
            {
                text += "Clientul nu a achitat pretul\n";
            }

            return text;
        }
    }
}
