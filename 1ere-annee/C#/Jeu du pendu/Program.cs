using System;

namespace Jeu_du_pendu
{
    internal class Program
    {
        public static void afficherT(string[] tab)
        {
            string mot = "";
            for (int o = 0; o < tab.Length; o++) 
            {
                mot += tab[o] + " ";
            }
            Console.WriteLine(mot.Trim());
        }

        static void Main(string[] args)
        {
            string[] motsFrancais = new string[]
        {
            "bonjour", "amour", "soleil", "liberte", "etoile",
            "oiseau", "maison", "chocolat", "riviere", "montagne",
            "fleur", "livre", "musique", "espoir", "jardin",
            "verite", "beaute", "reve", "lumiere", "amitie",
            "horizon", "mer", "neige", "ciel", "printemps",
            "papillon", "hiver", "foret", "arc-en-ciel", "poesie",
            "paix", "gloire", "nature", "histoire", "voyage",
            "chanson", "avenir", "bonheur", "courage", "douceur",
            "emerveillement", "famille", "joie", "melodie", "partage",
            "prosperite", "richesse", "sagesse", "tendresse", "univers",
            "victoire", "zenith", "aventure", "cascade", "destin",
            "energie", "force", "harmonie", "innocence", "justice",
            "kaleidoscope", "langage", "mystere", "nuage", "parfum",
            "quintessence", "rayon", "symphonie", "tresor", "utopie",
            "vision", "voyant", "xylophone", "zen", "arcade",
            "ballet", "cascadeur", "diversite", "ecrivain", "flamme",
            "galaxie", "hymne", "idylle", "jardinier", "karate",
            "legende", "magicien", "nectar", "opera", "palette",
            "quadrille", "refuge", "serenite", "temple", "ultime",
            "valeur", "whisky", "yoga", "zenith"
        };


            bool jeu = true;
            int essaiMax;
            string motatrouver;
            bool finpartie;
            string[] mot;
            int j;
            int i;
            string replay;
            string lettresUtilisees = ""; 

            while (jeu)
            {
                lettresUtilisees = "";
                Random random = new Random();
                int nombreAleatoire = random.Next(0, motsFrancais.Length);
                Console.WriteLine("Donner le nombre d'essais:");
                essaiMax = Convert.ToInt32(Console.ReadLine());
                motatrouver = Convert.ToString( motsFrancais[nombreAleatoire]).ToUpper();

                mot = new string[motatrouver.Length];
                for (j = 0; j < motatrouver.Length; j++)
                {
                    mot[j] = "_";
                }

                finpartie = false;

                while (finpartie == false)
                {
                    if (essaiMax > 0)
                    {
                        afficherT(mot);
                        Console.WriteLine("Donner une lettre ou un mot:");
                        string testM = Console.ReadLine().ToUpper();

                        if (testM == motatrouver)
                        {
                            finpartie = true;
                            Console.WriteLine("Gagné!");
                        }
                        else if (testM.Length == 1)
                        {
                            if (lettresUtilisees.Contains(testM))
                            {
                                Console.WriteLine("Vous avez déjà utilisé cette lettre.");
                            }
                            else
                            {
                                lettresUtilisees += testM;

                                if (motatrouver.Contains(testM))
                                {
                                    for (i = 0; i < motatrouver.Length; i++)
                                    {
                                        if (motatrouver[i].ToString() == testM)
                                        {
                                            mot[i] = testM;

                                        }
                                    }
                                    Console.WriteLine("Lettre déjà utilisé:" + lettresUtilisees);
                                }
                                else
                                {
                                    essaiMax--;
                                    Console.WriteLine("Lettre incorrecte! Essais restants: " + essaiMax);
                                    Console.WriteLine("Lettre déjà utilisé:"+lettresUtilisees);

                                }
                            }
                        }
                        else
                        {
                            essaiMax--;
                            Console.WriteLine("Mot incorrect! Essais restants: " + essaiMax);
                            Console.WriteLine("Lettre déjà utilisé:" + lettresUtilisees);
                        }

                    }
                    else
                    {
                        Console.WriteLine("Vous avez perdu!");
                        Console.WriteLine("Le mot était: " + motatrouver);
                        finpartie = true;
                    }
                }

                Console.WriteLine("Voulez-vous rejouer ? (O/N):");
                replay = Console.ReadLine().ToUpper();
                if (replay == "N")
                {
                    jeu = false;
                }
            }
        }
    }
}
