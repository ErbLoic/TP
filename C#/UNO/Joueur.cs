using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNO
{
    public class Joueur
    {
        public string pseudonyme { get; set; }

        public bool EstUno { get; set; }

        public Joueur JoueurSuivant { get; set; }

        public Joueur JoueurPrécédent { get; set; }
        public List<Carte> MainJoueur;

        public Joueur(string pseudonyme)
        {
            this.pseudonyme = pseudonyme;
            this.EstUno = false;
            this.MainJoueur=new List<Carte>();
        }

        public override string ToString()
        {

            string suivantPseudo = JoueurSuivant?.pseudonyme ?? "null";
            string precedentPseudo = JoueurPrécédent?.pseudonyme ?? "null";
            return $"{pseudonyme} | EstUno: {EstUno} | Suivant: {suivantPseudo} | Précédent: {precedentPseudo} \n";
        }

    }
}
