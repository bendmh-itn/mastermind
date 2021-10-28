using System;

namespace mastermind
{
    class Program
    {
        // Cette fonction est le départ du programme
        static void Main(string[] args)
        {
			int[] combi;
            ChoixCombi(out combi);
            Afficher(combi);
            Console.WriteLine();
            Console.WriteLine("Entrez une combinaison");
            proposition = Console.ReadLine();
        }

        //Cette fonction permet à l'ordinateur de choisir une combinaison de 4 chiffres
        static void ChoixCombi(out int[] combi){
            combi = new int[4];
            Random rnd = new Random();
            for(int i = 0; i <= 3; i++){
                int valeur  = rnd.Next(1, 7);
                combi[i] = valeur;
            }
        }
        //cette fonction affiche un tableau
        static void Afficher(int[] combi) {
            for(int i = 0; i <= 3; i++){
                Console.Write(combi[i]);
            }
        }
		
    }
}
