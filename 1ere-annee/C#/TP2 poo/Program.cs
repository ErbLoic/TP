namespace TP2_poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zone desert = new Zone("Désert", 0, 5);
            Joueur lolo = new Joueur("Loïc", 150, 150, 25, desert);
            Monstre squelette = new Monstre("Squelette", 1, 100, 100, 10);
            Monstre zombie = new Monstre("Zombie", 1, 100, 100, 10);
            Jeu jeu = new Jeu();
            jeu.AddZones(desert);
            jeu.AddJoueur(lolo);
            desert.AddMonstre(squelette);
            desert.AddMonstre(zombie);
            jeu.rencontreAlea();
            foreach (Monstre monstre in lolo.Lmonstre)
            {
                Console.WriteLine(monstre.ToString());
            }
        }
    }
}
