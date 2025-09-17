namespace UNO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Partie test= new Partie();
            test.melanger();
            test.AjoutJ();
            test.DistribCarte();

            Console.WriteLine("1er carte Pioche=" + test.LaPioche.LesCartePio.Count()+"\n --------------");

            foreach(Joueur j in test.LesJoueurs)
            {
                Console.WriteLine("\n--------------------------\n");
                Console.WriteLine(j.pseudonyme); 
                foreach(Carte c in j.MainJoueur)
                {
                    Console.WriteLine(c);
                }
                Console.WriteLine("\n--------------------------\n");
            }

            Console.WriteLine("\n --------------\n"+"1er carte Pioche=" + test.LaPioche.LesCartePio.Count() + "\n --------------");




        }
    }
}
