using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNO
{
    public class Défausse
    {
        public List<Carte> lesCartesDes;

        public Défausse() 
        {
            this.lesCartesDes = new List<Carte>();
        }

        public override string ToString()
        {
            string chaine="";
            foreach (Carte carte in this.lesCartesDes)
            {
                chaine += carte.ToString();
            }
            return chaine;
        }


    }
}
