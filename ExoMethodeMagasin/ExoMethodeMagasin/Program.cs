/* Un magasin en ligne propose 3 articles
    Coca : 1€ (stock 4)
    Sandwich : 5€ (stock 2)
    Porte : 200€ (stock 3)
    Tant que l'utiliseur veut continuer ses achats, le programme continue à lui proposer la liste des articles en stock
    et lui demande de faire son choix (1 2 ou 3 )
    Quand il choisit d'arrêter, le programme affiche le total à payer. L'affichage des articles (stocké dans une collection) 
    se fera à l'aide d'une méthode (void). Le panier du client doit également être stocké dans une collection 
    le retrait d'un article du stock se fait via méthode créer une méthode qui calcule le total des achats     */


using ExoMethodeMagasin;

bool finAchat = false;

Dictionary<string, int> stock = new Dictionary<string, int>();
stock.Add("Coca", 4);
stock.Add("Sandwish", 2);
stock.Add("Porte", 3);

Dictionary<string, int> panier = new Dictionary<string, int>();
panier.Add("Coca", 0);
panier.Add("Sandwish", 0);
panier.Add("Porte", 0);

Magasin.AffichageMenu(stock, panier);

//Console.WriteLine($" Votre panier comprend {nbrCocaAchat} Coca / {nbrSandAchat} Sandwich / {nbrPorteAchat} Porte +" +
//    $" Total à payer = {totalPanier}");





// Dictionary<int, string> panier = new Dictionary<int, string>();




//void affichageArt()
//{
//    foreach (KeyValuePair<int,string> item in articles)
//    {
//        Console.WriteLine($"{item.Key} = {item.Value}" );
//    }
//}

//affichageArt();