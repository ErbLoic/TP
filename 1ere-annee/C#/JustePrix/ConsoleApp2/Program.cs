namespace ConsoleApp2
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();   
            int essai = 1;
            int nbr = random.Next(1,101);
            Console.WriteLine("Donner un nbr entre 1 et 100");
            int nbrJ2 = Convert.ToInt32(Console.ReadLine());
            int maxi = 100;
            int min = 1;
            while (nbr != nbrJ2)
            {
                if (nbr< nbrJ2)
                {
                    Console.WriteLine("Chiffre a trouver plus petit");
                    maxi=nbrJ2;
                }
                else
                {
                    Console.WriteLine("Chiffre a trouver plus grand");
                    min = nbrJ2;
                }
                Console.WriteLine("Donner un chiffre entre "+min+" et "+maxi);
                nbrJ2 = Convert.ToInt32(Console.ReadLine());
                essai++;
            }
            Console.WriteLine("Vous avez trouvé en " + essai + " essai");
        }
    }
}
