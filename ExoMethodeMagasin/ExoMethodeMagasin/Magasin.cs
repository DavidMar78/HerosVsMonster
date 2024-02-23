using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoMethodeMagasin
{
    public class Magasin
    {
        
        public static void Achats(Dictionary<string,int> stockAchat, Dictionary<string, int> panierAchat, string hike)
        {
            stockAchat[hike] -= 1;
            panierAchat[hike] += 1;
        }

        // Parametre de la fctn : dico + type + nommage / type de la clé + nommage
        public static void AffichageMenu(Dictionary<string, int> stockAchat, Dictionary<string, int> panierAchat)
        {
            Console.WriteLine("Entrez votre choix :\n" +
                      " 1= Coca (1 Euros) \n" +
                      " 2= Sandwich (5 Euros)\n" +
                      " 3= Porte (200 Euros) \n" +
                      " 4 = Quitter");

            int choix = int.Parse(Console.ReadLine());
            switch (choix)
            {
                case 1:                
                    Achats(stockAchat, panierAchat, "Cola");
                    break;

                case 2:
                    Achats(stockAchat, panierAchat, "Sandwish");
                    break;

                case 3:
                    Achats(stockAchat, panierAchat, "Porte");
                    break;
                case 4:
                    //finAchat = true;
                    break;
            }
        }
        public static void TotalPanier(Dictionary<string, int> panierAchat, string hike)
        {
            int total = 0;
            panierAchat[hike] = 
        }
    }
}
