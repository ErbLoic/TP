using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_2
{
    public class Centre
    {
        public List<spe> spe;

        public List<Tarif> tarif;
        public int ID { get; set; }
        public string Nom { get; set; }
        public int IDCommune { get; set; }
        public int Remise2 { get; set; }

        public int Remise3 { get; set; }
        public Centre(int id, string nom, int idC, int Remise2)
        {
            this.ID = id;
            this.Nom = nom;
            this.IDCommune = idC;
            this.Remise2 = Remise2;
            this.Remise3 = 0;
            this.spe=new List<spe>();
            this.tarif=new List<Tarif>();  

        }

        public override string ToString()
        {
            string chaine=this.ID + " " + this.Nom + " " + this.IDCommune + " " + this.Remise2 + " " + this.Remise3;
            foreach (spe spe in this.spe)
            {
                chaine += " " + spe.ToString();
            }
            return chaine;
        }

    }
    internal class centres
    {

    }
}
