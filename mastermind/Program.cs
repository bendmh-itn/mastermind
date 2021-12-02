using System;

namespace mastermind
{
    class Program
    {
        // Cette fonction est le départ du programme
        static void Main(string[] args)
        {
			int[] combi;
            int[] propositionTableau;
            int[] clonePropositionTableau;
            string proposition;
            int nombrePionsRouges = 0;
            int nombrePionsBlancs;
            int nombreChances = 12;


            ChoixCombi(out combi);
            while (nombrePionsRouges != 4 & nombreChances > 0){
                Afficher(combi);
                Console.WriteLine("Entrez une combinaison");
                proposition = Console.ReadLine();
                StringToArray(proposition, out propositionTableau);
                cloneCombi(propositionTableau, out clonePropositionTableau);
                PionsRouges(propositionTableau, clonePropositionTableau, out nombrePionsRouges);
                Console.WriteLine(nombrePionsRouges);
                PionsBlancs(propositionTableau, clonePropositionTableau, out nombrePionsBlancs);
                Console.WriteLine(nombrePionsBlancs);
            }
        }

        static void cloneCombi(int[] propositionTableau, out int[] clonePropositionTableau){
            clonePropositionTableau = new int[4];
            for(int i = 0; i <= 3; i++){
                clonePropositionTableau[i] = propositionTableau[i];
            }
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
            Console.WriteLine();
        }
		
        static void StringToArray(string proposition, out int[] propositionTableau){
            propositionTableau = new int[4];

            for(int i = 0; i <= 3; i++){
                propositionTableau[i] = int.Parse(proposition[i].ToString());
            }
        }

        static void PionsRouges(int[] propositionTableau, int[] combi, out int nombrePionsRouges){
            nombrePionsRouges = 0;
            for(int i = 0; i <= 3; i++){
                if(propositionTableau[i] == combi[i]){
                    nombrePionsRouges++;
                    propositionTableau[i] = -1;
                    combi[i] = -2;
                }
            }
        }

        static void PionsBlancs(int[] propositionTableau, int[] combi, out int nombrePionsBlancs){
            nombrePionsBlancs = 0;
            for(int i = 0; i <= 3; i++){
                for(int j=0; j <=3; j++){
                    if(propositionTableau[i] == combi[j]){
                        nombrePionsBlancs++;
                        propositionTableau[i] = -1;
                    }
                } 
            }
        }


    }
}
