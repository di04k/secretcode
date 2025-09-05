using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;

namespace SecretCode_syla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int levelGame =1; // stock le niveau choisi par l'utilisaeur par défaut (1) débutant

            const int RANDOM_VALUE = 1234;

            Console.WriteLine("╔════════════════════ Dionit Syla ════════════════════╗");
            Console.WriteLine("║                                                     ║");
            Console.WriteLine("║       Bienvenue dans le jeu : Secret Code           ║");
            Console.WriteLine("║                                                     ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════╝");

            Console.WriteLine("Un code secret composé de 4 chiffres est généré.");
            Console.WriteLine("A toi de le découvrir en 10 essais maximum !");

            Console.WriteLine(" ");

            Console.WriteLine("A chaque essai, tu recois un indice selon le niveau choisi.");

            Console.WriteLine(" ");

            Console.WriteLine("Pour les niveaux 1 et 3 avec indices visibles :");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("■");
            Console.ResetColor();
            Console.WriteLine(" : chiffre bien placé");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("■");
            Console.ResetColor();
            Console.WriteLine(" : chiffre correct mais mal placé");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("■");
            Console.ResetColor();
            Console.WriteLine(" : chiffre absent");

            Console.WriteLine(" ");

            Console.WriteLine("Exemple : ");
            Console.WriteLine("Code secret : 1234 (caché)");
            Console.WriteLine("Votre essai : 1325");
            Console.WriteLine("Indice     :");
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.Write("■");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("■");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("■");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("■");
            Console.WriteLine(" (1 bien placé, 2 mal placés, 1 absent)");

            Console.WriteLine(" ");

            Console.WriteLine("Pour les niveaux 2 et 4 avec indices discrets :");
            Console.WriteLine("Exemple :");
            Console.WriteLine("Code secret : 5413 (caché)");
            Console.WriteLine("Votre essai : 1234");
            Console.WriteLine("Indice     :");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" → 0 bien placé(s), 3 mal placé(s)");

            Console.WriteLine(" ");

            Console.ResetColor();
            Console.WriteLine("Appuie sur une touche pour commencer...");

            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("=== SECRET CODE ===");

            Console.WriteLine(" ");

            Console.WriteLine("Choisi un niveau :");
            Console.WriteLine("1. Débutant      (1 à 6, sans doublons, indices visibles)");
            Console.WriteLine("2. intermédiaire (1 à 6, sans doublons, indices discrets)");
            Console.WriteLine("3. Avancé        (1 à 8, avec doublons, indices visibles)");
            Console.WriteLine("4. Expert        (1 à 9, avec doublons, indices discrets)");

            Console.WriteLine();

            Console.Write("Votre choix (1-4) : ");

            levelGame = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("=== SECRET CODE Niveau {0} ===", levelGame);
            Console.WriteLine(" ");

            switch (levelGame)
            {
                case 1:
                    Console.WriteLine("Essais : ");

                    
                    
                    break;

                case 2:
                    Console.WriteLine("=== SECRET CODE Niveau {0} ===", levelGame);



                    break;

                case 3:
                    Console.WriteLine("=== SECRET CODE Niveau {0} ===", levelGame);



                    break;
                case 4:
                    Console.WriteLine("=== SECRET CODE Niveau {0} ===", levelGame);



                    break;
            }






                Console.Read();
        }
    }
}
