using System.Collections;
namespace IntroPOO
{
    public class Eleve
    {
        private string nom;
        private string prenom;
        private int age;
        List<Matiere>lesmatieres;


        //constructeur
        public Eleve(string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.lesmatieres = new List<Matiere>();

        }

        //methode d ajout de matière
        public void AjouterMatière(Matiere matiere)
        {
            this.lesmatieres.Add(matiere);
        }

        //accesseur

        public string Getnom()
        {
            return this.nom;
        }

        public string GetPrenom()
        {
            return this.prenom;
        }

        public int GetAge()
        {
            return this.age;
        }

        public void Setnom(string nom)
        {
            this.nom = nom;
        }

        public void SetPrenom(string prenom)
        {
            this.prenom = prenom;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        //To string()

        public override string ToString() 
        {
            string chaine= "Nom: "+this.nom +"\nPrenom: "+this.prenom +"\nAge: " +this.age+"\nMatières: ";
            foreach (Matiere item in lesmatieres)
            {
                chaine = chaine + item.ToString();
            }
            return chaine;
        }

        //Méthode
        public bool AugmenterAge(int age)
        {
            if(age > 0)
            {
                this.age=this.age+age;
                return true;
            }
            else
            {
                return false;
            }
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Eleve El = new Eleve("Erb", "Moi", 18);
            Eleve el2 = new Eleve("garp", "barp", 25);
            Matiere math = new Matiere("Math", 17.5);
            math.CNom = "Bal";
            El.AjouterMatière(math);
            Console.WriteLine(El.ToString());
        }
    }
}
