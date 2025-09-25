using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionMeteo
{
    interface IBulletin
    {
        public DateTime Periodedediffusion { get; set; }

        public void AddZone(Zonegeographique zone);
        public Releve Afficherrelever(Zonegeographique zone);
        public double MoyenneTemp(string type);
        public Zonegeographique TemperatureMax(string type);
        public Zonegeographique TemperatureMin(string type);



    }

    class Bulletin:IBulletin
    {
        public DateTime Periodedediffusion { get; set; }

        List<Zonegeographique> lesZonegeographiques;

        public Bulletin(DateTime Periodedediffusion)
        {
            this.Periodedediffusion = Periodedediffusion;
            this.lesZonegeographiques= new List<Zonegeographique>();
        }

        public override string ToString()
        {
            string chaine=Periodedediffusion+" ";
            foreach(Zonegeographique zone in lesZonegeographiques)
            {
                chaine+=zone.ToString()+"\n";
            }
            return chaine;
        }

        public void AddZone(Zonegeographique zone)
        {
            this.lesZonegeographiques.Add(zone);
        }

        public Releve Afficherrelever(Zonegeographique lzg)
        {
            return lzg.leReleve;
        }

        public double MoyenneTemp(string type)
        {
            double moy = 0;
            double nbr =0;
            foreach (Zonegeographique zone in this.lesZonegeographiques)
            {
                nbr += 1;
                if (type == "F")
                {
                    moy += Convertisseur.ConvertToF(zone.leReleve.Temperature);
                }
                else
                {
                    moy += zone.leReleve.Temperature;
                }
            }
            return moy / nbr;
        }

        public Zonegeographique TemperatureMax(string type)
        {
            double max = -1000000;
            Zonegeographique zoneM = null;
            foreach (Zonegeographique zone in this.lesZonegeographiques)
            {
                    if (zone.leReleve.Temperature > max)
                    {
                        max = zone.leReleve.Temperature;
                        zoneM = zone;
                    }
            }
            return zoneM;
        }

        public Zonegeographique TemperatureMin(string type)
        {
            double min = 1000000;
            Zonegeographique zoneM = null;
            foreach (Zonegeographique zone in this.lesZonegeographiques)
            {
                    if (zone.leReleve.Temperature < min)
                    {
                        min = zone.leReleve.Temperature;
                        zoneM = zone;
                    }
            }
            return zoneM;
        }

    }
}
