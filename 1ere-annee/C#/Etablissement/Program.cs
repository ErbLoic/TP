namespace Etablissement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matiere B2 = new Matiere("B2-Développement", 2, 0);
            Matiere B3 = new Matiere("B3-Cyber", 2, 0);
            
            Notes B000 = new Notes(DateTime.Now, 14, 1);
            Notes B001 = new Notes(DateTime.Now, 10, 1 );
            Notes B002 = new Notes(DateTime.Now, 15, 2);
            B000.AjouterMatiere(B2);
            B000.AjouterMatiere(B3);
            B001.AjouterMatiere(B2);
            B002.AjouterMatiere(B3);

            Personne Loic = new Personne("Erbuer", "Loïc", 18);
            Personne perso = new Personne("Erbuer", "perso", 18);

            Etudiant Lo = new Etudiant("SLAM", 01, "Erbuer", "Loïc", 18);
            Etudiant pers = new Etudiant("SLAM", 01, "Erbuer", "Loïc", 18);
            Lo.ajouterNote(B000);
            Lo.ajouterNote(B001);
            Lo.ajouterNote(B002);
            pers.ajouterNote(B002);
            pers.ajouterNote(B000);

            Classe SIO = new Classe("SIO 2", "BTS");
            SIO.addpersonne(Lo);
            SIO.addpersonne(pers);

            Console.WriteLine( double.Round( SIO.MoyenneGroupe("SLAM"),2));
            Console.WriteLine(double.Round(pers.MoyenneG(),2));
            Console.WriteLine(double.Round(Lo.MoyenneG(),2));
            Console.WriteLine(SIO.MeilleurEtudiant().ToString());
        }
    }
}
