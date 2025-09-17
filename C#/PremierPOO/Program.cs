namespace PremierPOO
{
    public class Personnages
    {
        List<Equipement> equip;

        public Personnages(string nom, string prenom, int age,string sexe, string origine)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Age = age;
            this.Sexe = sexe;
            this.Origine = origine;
            this.equip= new List<Equipement>();
        }

        public override string ToString()
        {
            string chaine= this.Nom+" "+this.Prenom+" "+this.Age+" "+this.Sexe+" "+this.Origine;
            foreach(Equipement item in this.equip)
            {
                chaine += "\n------------------------";
                chaine= chaine+"\n"+item.ToString();
            }
            return chaine;

        }

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
        public string Sexe { get; set; }
        public string Origine { get; set; }

        //-------------------------------------Méthodes---------------------------------------------//

        public bool EstEquipé()
        {
            if (this.equip.Count>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddEquip(Equipement equip)
        {
            Equipement valeur= null ;
            Boolean valeurV=false;
            Boolean valeurV2 = true;
            if (this.equip.Count > 0)
            {
                foreach (Equipement AncienE in this.equip)
                {
                    if (AncienE.Type == equip.Type) 
                    {
                        if (AncienE.Score < equip.Score)
                        {
                            valeurV = true;
                            valeurV2 = false;
                            valeur = AncienE;
                        }
                    }
                }
                if (valeurV==true && valeurV2==false)
                {
                    this.equip.Remove(valeur);
                    this.equip.Add(equip);
                }
                else if (valeurV2 == true)
                {
                    this.equip.Add(equip);
                }
                else
                {
                    Console.WriteLine("Equipement déjà existant ou le score est inférieur ");
                }
            }
            else
            {
                this.equip.Add(equip);
            }
        }

        public double GetScoreEquipement()
        {
            if (this.equip.Count == 0)
            {
                return 0;
            }
            else
            {
                double somme = 0;
                foreach (Equipement equip in this.equip)
                {
                    somme += equip.Score;
                }
                return somme;
            }
        }
        public string GetEquipement()
        {
            string chaine="";
            foreach(Equipement equip in this.equip)
            {
                chaine += equip.Nom + " score: " + equip.Score+"\n";
            }
            return chaine;
        }

        public void ModifierEquipement(int id)
        {
            foreach (Equipement equipement in this.equip)
            {
                if (equipement.Id == id)
                {
                    Console.WriteLine("Veux-tu modifier son nom(O/N)");
                    string nom = Console.ReadLine();
                    if (nom.ToUpper() == "O")
                    {
                        Console.WriteLine("Quelle nom");
                        nom = Console.ReadLine();
                        equipement.Nom = nom;
                    }
                    Console.WriteLine("Veux-tu modifier son Type(O/N)");
                    string type = Console.ReadLine();
                    if (type.ToUpper() == "O")
                    {
                        Console.WriteLine("Quelle Type");
                        type = Console.ReadLine();
                        equipement.Type = type;
                    }
                    Console.WriteLine("Veux-tu modifier son Score(O/N)");
                    string score = Console.ReadLine();
                    if (score.ToUpper() == "O")
                    {
                        Console.WriteLine("Quelle score");
                        double scor = Convert.ToDouble(Console.ReadLine());
                        equipement.Score = scor;
                    }

                }
            }
        }

        public void Combat(Personnages J2)
        {
            int PJ1 = 0;
            int PJ2 = 0;
            for(int a=0;a<this.equip.Count;a++) 
            {
            
                if (this.equip[a].Score > J2.equip[a].Score)
                {
                    PJ1 += 1;
                }
                else if(this.equip[a].Score < J2.equip[a].Score)
                {
                    PJ2 += 1;
                }
            }
            if (PJ1 > PJ2)
            {
                Console.WriteLine(this.Prenom + " a gagner");
            }
            else if(PJ1 < PJ2)
            {
                Console.WriteLine(J2.Prenom + " a gagner");
            }
            else
            {
                Console.WriteLine("Match Nul");
            }
            Console.WriteLine("Score finale: \nJ1:" + PJ1 + "\nJ2:" + PJ2);
        }

    }
//Main programme
    internal class Program
    {
        static void Main(string[] args)
        {
            Personnages J1 = new Personnages("Toto", "Tota", 19, "homme", "Eldiens");
            Personnages J2 = new Personnages("Pap", "Pap", 32, "homme", "sayan");
            Console.WriteLine(J1.ToString());
            Console.WriteLine("---Equipement----");
            Equipement TriDimensionnel = new (1, "TriDimensionnel", "Normal", 26);
            Equipement TriDimensionnel2 = new(2, "TriDimensionnel222", "Feu", 26);

            Console.WriteLine(TriDimensionnel.ToString());
            Console.WriteLine("---Perso + equip J1----");
            J1.AddEquip(TriDimensionnel);
            J2.AddEquip(TriDimensionnel2);
            Console.WriteLine(J1.ToString());
            Console.WriteLine("---Perso + equip J2----");
            Console.WriteLine(J2.ToString());

            Console.WriteLine("---Score équipement----");
            Console.WriteLine(J1.GetScoreEquipement());
            Console.WriteLine("----Liste équipement----");
            Console.WriteLine(J1.GetEquipement());
            Console.WriteLine("----Modif équipement----");
            J1.ModifierEquipement(1);
            Console.WriteLine(J1.GetEquipement());
            Console.WriteLine("----Combat----");
            J1.Combat(J2);


        }
    }
}
