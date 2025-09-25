namespace Jeu_du_taquin
{
    using System.Text;

    internal class Program
    {
        //----------------------------------------------------------Affichage----------------------------------------------------------

        public static void Affichage(int[,] tab,int taille)
        {
            string ligne = "";
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                if (taille == 3)
                {
                    Console.WriteLine("+---+---+---+");
                }
                else if (taille == 5)
                {
                    Console.WriteLine("+-----+-----+-----+-----+-----+");
                }

                else if (taille == 7)
                {
                    Console.WriteLine("+-----+-----+-----+-----+-----+-----+-----+");
                }
                ligne = "";
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    if (taille != 3)
                    {
                        if (tab[i, j] == 0)
                        {
                            ligne += "|     ";
                        }
                        else if (tab[i, j] == 1 || tab[i, j] == 2 || tab[i, j] == 3 || tab[i, j] == 4 || tab[i, j] == 5 || tab[i, j] == 6 || tab[i, j] == 7 || tab[i, j] == 8 || tab[i, j] == 9)
                        {
                            ligne += "|  " + tab[i, j] + "  ";
                        }
                        else
                        {
                            ligne += "| " + tab[i, j] + "  ";
                        }
                    }
                    else
                    {
                        if (tab[i, j] == 0)
                        {
                            ligne += "|   ";
                        }
                        else
                        {
                            ligne += "| " + tab[i, j] + " ";
                        }
                    }

                }
                ligne += "|";
                Console.WriteLine(ligne);
            }
            if (taille == 3)
            {
                Console.WriteLine("+---+---+---+");
            }
            else if (taille == 5)
            {
                Console.WriteLine("+-----+-----+-----+-----+-----+");
            }
            else if (taille == 7)
            {
                Console.WriteLine("+-----+-----+-----+-----+-----+-----+-----+");
            }
        }

        //----------------------------------------------------------Mélange----------------------------------------------------------

        public static int[,] melange(int[,] plateau)
        {
            int lignevide = 0;
            int colonnevide = 0;
            int valeur = 0;
            int nombreAleatoire;
            int second;
            //Lance la boucle pour mélanger 
            for (int i = 0; i < 500; i++)
            {
                //On cherche la case vide
                for (int j = 0; j < plateau.GetLength(0); j++)
                {
                    for (int k = 0; k < plateau.GetLength(1); k++)
                    {
                        if (plateau[j, k] == 0)
                        {
                            lignevide = j;
                            colonnevide = k;
                        }
                    }
                }
                //On cherche si on va se déplacer en ligne ou en colone choisie aléatoirement
                Random random = new Random();
                nombreAleatoire = random.Next(0, 2);
                // si 0 on se déplace en ligne
                if (nombreAleatoire == 0)
                {
                    //On regarde si la ligne ou se trouve le 0 est pas au extrémité
                    if (lignevide != plateau.GetLength(0)-1 && lignevide != 0)
                    {
                        //on re fait un nbr aléatoire pour savoir si haut ou bas
                        second = random.Next(0, 2);
                        //On modifie en allant en haut si c 0 et en bas si c 1
                        if (second == 0)
                        {
                            valeur = plateau[lignevide - 1, colonnevide];
                            plateau[lignevide - 1, colonnevide] = 0;

                            plateau[lignevide, colonnevide] = valeur;
                            lignevide--;

                        }
                        else
                        {
                            valeur = plateau[lignevide + 1, colonnevide];
                            plateau[lignevide + 1, colonnevide] = 0;

                            plateau[lignevide, colonnevide] = valeur;
                            lignevide++;

                        }
                    }
                    //ou sinon si on est sur une bordure il n y a pas de choix
                    else
                    {
                        if (lignevide == plateau.GetLength(0) - 1)
                        {
                            valeur = plateau[lignevide - 1, colonnevide];
                            plateau[lignevide - 1, colonnevide] = 0;

                            plateau[lignevide, colonnevide] = valeur;
                            lignevide--;
                        }
                        else
                        {
                            valeur = plateau[lignevide + 1, colonnevide];
                            plateau[lignevide + 1, colonnevide] = 0;
                            plateau[lignevide, colonnevide] = valeur;
                            lignevide++;

                        }
                    }
                }
                //ducoup si c une autre valeur on bouge en colonne
                else
                {
                    if (colonnevide != plateau.GetLength(1) - 1 && colonnevide != 0)
                    {
                        second = random.Next(0, 2);
                        if (second == 0)
                        {
                            valeur = plateau[lignevide, colonnevide - 1];
                            plateau[lignevide, colonnevide - 1] = 0;

                            plateau[lignevide, colonnevide] = valeur;
                            colonnevide--;

                        }
                        else
                        {
                            valeur = plateau[lignevide, colonnevide + 1];
                            plateau[lignevide, colonnevide + 1] = 0;

                            plateau[lignevide, colonnevide] = valeur;
                            colonnevide++;

                        }
                    }
                    else
                    {
                        if (colonnevide == plateau.GetLength(1) - 1)
                        {
                            valeur = plateau[lignevide, colonnevide - 1];
                            plateau[lignevide, colonnevide - 1] = 0;

                            plateau[lignevide, colonnevide] = valeur;
                            colonnevide--;
                        }
                        else
                        {
                            valeur = plateau[lignevide, colonnevide + 1];
                            plateau[lignevide, colonnevide + 1] = 0;

                            plateau[lignevide, colonnevide] = valeur;
                            colonnevide++;
                        }
                    }
                }
            }
            return plateau;

        }
        //----------------------------------------------------------JEU----------------------------------------------------------

        public static void Game()
        {
            int[,] plateau;
            int[,] modèle;
            string rep;
            int compt = 0;
            int num = 0;
            Boolean tailler = false;
            Boolean valeur = true;
            Console.WriteLine("Quelle taille voulez-vous (3/5/7)");
            int taille = Convert.ToInt32(Console.ReadLine());
            //On regarde si la valeur de a taille est correct ou sinon on relance la demande
            if (taille != 3 && taille != 5 && taille != 7)
            {
                tailler = true;
                while (tailler)
                {
                    Console.WriteLine("Mauvaise Taille ou Erreur de frappe. Veuillez rentrer sois 3, 5 ou 7");
                    taille = Convert.ToInt32(Console.ReadLine());
                    if (taille == 3 || taille == 5 || taille == 7)
                    {
                        tailler = false;
                    }
                }
            }
            modèle = new int[taille, taille];
            //Incrémente les numéro
            for (int j = 0; j < taille; j++)
            {
                for (int k = 0; k < taille; k++)
                {
                    modèle[j, k] = num;
                    num++;
                }
            }
            int[,] modele = CopierPlateau(modèle); ;
            plateau = modele;
            plateau = melange(plateau);
            Console.WriteLine("Voici le modèle qui est attendu:");
            Affichage(modèle, taille);
            Console.WriteLine("Voici le Jeu Actuel:");
            Affichage(plateau, taille);
            //On lance le jeu
            while (valeur)
            {
                //on regarde si le jeu est égale au modèle
                for (int i = 0; i < plateau.GetLength(0); i++)
                {
                    for (int j = 0; j < plateau.GetLength(1); j++)
                    {
                        if (plateau[i, j] != modèle[i, j])
                        {
                            valeur = false;
                            
                        }
                    }
                }
                //Si il n'est pas égale au modèle alors
                if (valeur == false)
                {
                    //on demande sa commande
                    Console.WriteLine("Z,Q,S,D,exit,modèle,restart,compteur");
                    rep = Console.ReadLine().ToUpper() ?? "";
                    //Permet de quitter le jeux
                    if (rep == "EXIT")
                    {
                        Console.WriteLine("Aurevoir");
                        plateau = modèle;
                        valeur = false;
                    }
                    //D afficher le nbr de coups réaliser
                    else if (rep == "COMPTEUR")
                    {
                        Console.WriteLine("Actuellement vous êtes à " + compt + " coup(s)");
                        valeur = true;
                    }
                    //permet le déplacement en haut
                    else if (rep == "Z")
                    {
                        plateau = Haut(plateau);
                        Console.WriteLine("Voici le Jeu Actuel:");
                        Affichage(plateau, taille);
                        valeur = true;
                        compt++;

                    }
                    //permet le déplacement à gauche
                    else if (rep == "Q")
                    {
                        plateau = gauche(plateau);
                        Console.WriteLine("Voici le Jeu Actuel:");
                        Affichage(plateau, taille);
                        valeur = true;
                        compt++;

                    }
                    //permet le déplacement à droite
                    else if (rep == "D")
                    {
                        plateau = droite(plateau);
                        Console.WriteLine("Voici le Jeu Actuel:");
                        Affichage(plateau, taille);
                        valeur = true;
                        compt++;

                    }
                    //permet le déplacementen bas
                    else if (rep == "S")
                    {
                        plateau = Bas(plateau);
                        Affichage(plateau, taille);
                        valeur = true;
                        compt++;

                    }
                    // permet l'affichage du modèle attendu
                    else if (rep == "MODELE")
                    {
                        Console.WriteLine("Voici le modèle qui est attendu:");
                        Console.WriteLine("Voici le Jeu Actuel:");
                        Affichage(modele, taille);
                        valeur = true;

                    }
                    // permet de relancer le jeux
                    else if (rep == "RESTART")
                    {
                        valeur = false;
                        Game();
                    }
                    // Erreur si mauvaise entrée
                    else
                    {
                        Console.WriteLine("ERREUR");
                        valeur = true;

                    }
                }
                else
                {
                    Console.WriteLine("Vous avez gagnez. En "+compt+" coups");
                    valeur = false;
                    Console.WriteLine("Voulez-vous rejouez??(O/N)");
                    string replay =Console.ReadLine().ToUpper();
                    if (replay == "O")
                    {
                        Game();
                    }
                    else
                    {
                        Console.WriteLine("Aurevoir");
                    }
                }
            }
        }
        //----------------------------------------------------------Déplacement----------------------------------------------------------
        public static int[,] Haut(int[,] plateau)
        {
            //Déplacement de la cse vide vers le haut
            int lignevide = 0;
            int colonnevide = 0;
            int valeur = 0;
            for (int j = 0; j < plateau.GetLength(0); j++)
            {
                for (int k = 0; k < plateau.GetLength(1); k++)
                {
                    if (plateau[j, k] == 0)
                    {
                        lignevide = j;
                        colonnevide = k;
                    }
                }
            }
            if (lignevide != 0)
            {
                valeur = plateau[lignevide - 1, colonnevide];
                plateau[lignevide - 1, colonnevide] = 0;
                plateau[lignevide, colonnevide] = valeur;
                lignevide--;
            }
            return plateau;
        }

        public static int[,] gauche(int[,] plateau)
        //Déplacement de la cse vide vers le gauche
        {
            int lignevide = 0;
            int colonnevide = 0;
            int valeur = 0;
            for (int j = 0; j < plateau.GetLength(0); j++)
            {
                for (int k = 0; k < plateau.GetLength(1); k++)
                {
                    if (plateau[j, k] == 0)
                    {
                        lignevide = j;
                        colonnevide = k;
                    }
                }
            }
            if (colonnevide != 0) { 

            valeur = plateau[lignevide, colonnevide - 1];
            plateau[lignevide, colonnevide - 1] = 0;
            plateau[lignevide, colonnevide] = valeur;
            colonnevide--;
            }
            return plateau;
        }

        public static int[,] droite(int[,] plateau)
        //Déplacement de la cse vide vers la droite
        {
            int lignevide = 0;
            int colonnevide = 0;
            int valeur = 0;
            for (int j = 0; j < plateau.GetLength(0); j++)
            {
                for (int k = 0; k < plateau.GetLength(1); k++)
                {
                    if (plateau[j, k] == 0)
                    {
                        lignevide = j;
                        colonnevide = k;
                    }
                }
            }
            if (colonnevide != plateau.GetLength(1)) {
                valeur = plateau[lignevide, colonnevide + 1];
                plateau[lignevide, colonnevide + 1] = 0;
                plateau[lignevide, colonnevide] = valeur;
                colonnevide++; }
            return plateau;
        }


        public static int[,] Bas(int[,] plateau)
        {
            //Déplacement de la cse vide vers le bas
            int lignevide = 0;
            int colonnevide = 0;
            int valeur = 0;
            for (int j = 0; j < plateau.GetLength(0); j++)
            {
                for (int k = 0; k < plateau.GetLength(1); k++)
                {
                    if (plateau[j, k] == 0)
                    {
                        lignevide = j;
                        colonnevide = k;
                    }
                }
            }
            if (lignevide != plateau.GetLength(0)) {
                valeur = plateau[lignevide + 1, colonnevide];
                plateau[lignevide + 1, colonnevide] = 0;
                plateau[lignevide, colonnevide] = valeur;
                lignevide++; }
            return plateau;
        }
        //Copie du plateau
        public static int[,] CopierPlateau(int[,] source)
        {
            //Permet la copie du tableau 
            int[,] copie = new int[source.GetLength(0), source.GetLength(1)];
            for (int i = 0; i < source.GetLength(0); i++)
            {
                for (int j = 0; j < source.GetLength(1); j++)
                {
                    copie[i, j] = source[i, j];
                }
            }
            return copie;
        }


        static void Main(string[] args)
        {
            Game();//Lancement du jeu
        }
    }
}
