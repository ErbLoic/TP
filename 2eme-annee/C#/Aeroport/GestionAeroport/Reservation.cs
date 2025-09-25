using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAeroport
{
    interface IReservation
    {
        DateTime dateDepart { get; set; }
        DateTime dateArriver { get; set; }

        Aeroport AeroportDepart { get; set; }
        Aeroport AeroportArrive { get; set; }
        Avion lAvion { get; set; }

        public double PoidsTotalbagage();
        public string DureeTrajet();
        public bool AddClient(Client client);

        public Client DoyenClient();
    }

    public class Reservation:IReservation
    { 
        public DateTime dateDepart { get;set; }
        public DateTime dateArriver { get;set; }
        public Aeroport AeroportDepart { get;set; }
        public Aeroport AeroportArrive { get; set; }
        public Avion lAvion { get;set; }
        List<Client> ListeClient;

        public Reservation(DateTime dateDepart, DateTime dateArriver, Aeroport AeroportDepart, Aeroport AeroportArrive, Avion lAvion)
        {
            this.dateDepart = dateDepart;
            this.dateArriver= dateArriver;
            this.lAvion= lAvion;
            this.AeroportArrive = AeroportArrive;
            this.AeroportArrive= AeroportArrive;
            this.ListeClient = new List<Client>();
        }

        public override string ToString()
        {
            string chaine= this.dateDepart+" "+this.dateArriver+" "+this.AeroportDepart+" "+this.AeroportArrive+" "+this.lAvion+" \n";
            foreach(Client client in this.ListeClient)
            {
                chaine+= client.ToString();
            }
            return chaine;
        }

        public double PoidsTotalbagage()
        {
            double poids = 0;
            foreach(Client client in this.ListeClient)
            {
                poids += client.PoidsBagage;
            }
            return poids;
        }

        public bool AddClient(Client client)
        {
            if (this.lAvion.Capacite < this.lAvion.CapaciteMax)
            {
                this.lAvion.Capacite++;
                this.ListeClient.Add(client);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string DureeTrajet()
        {
            TimeSpan temps = this.dateArriver - this.dateDepart;
            return temps.ToString();
        }

        public Client DoyenClient()
        {
            Client doyen = ListeClient[0];
            foreach(Client client in this.ListeClient)
            {
                if (client.dateN < doyen.dateN)
                {
                    doyen= client;
                }
            }
            return doyen;
        }


    }
}
