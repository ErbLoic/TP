using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etablissement
{
    class Notes
    {
        public DateTime date { get; set; }
        public double note { get; set; }
        public int coeff { get; set; }

        public List<Matiere>LesMatieres=new List<Matiere>();

        public Notes(DateTime date, double note , int coeff)
        {
            this.date = date;
            this.note = note;
            this.coeff = coeff;
            this.LesMatieres = new List<Matiere>();
        }

        public void AjouterMatiere(Matiere mat)
        {
            this.LesMatieres.Add(mat);
            mat.nbrnote += 1;
        }

        public override string ToString()
        {
            string chaine="";
            chaine += this.date+" "+this.note+" "+this.coeff;
            foreach (var item in this.LesMatieres)
            {
                chaine += " " + item.ToString();
            }
            return chaine;
        }
    }
}
