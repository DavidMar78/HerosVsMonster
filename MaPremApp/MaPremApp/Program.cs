
#region Calculez l'age selon date de naissance

//Console.WriteLine("Rentrez votre jour de naissance :");
//int jour = int.Parse(Console.ReadLine());
//Console.WriteLine("Rentrez votre mois de naissance :");
//int mois = int.Parse(Console.ReadLine());
//Console.WriteLine("Rentrez votre année de naissance :");
//int annee = int.Parse(Console.ReadLine());

//DateTime date = new DateTime(annee, mois, jour);
//DateTime date2 = DateTime.Now;

//int age = date2.Year - date.Year;
//Console.WriteLine(age);

//TimeSpan s = date2.Subtract(date);
//int ageOk = (int)(s.TotalDays / 365.25);
//Console.WriteLine(ageOk);
#endregion

#region collection 

//int n = 0;

//int[,] historique = new int[n,5];

//for (int i = 0; i < historique.Length; i++)
//{
//    Random rnd = new Random();
//    historique[] = rnd.Next(0,9);
//    ta
//}
#endregion

//mettre en place un systeme de vente basique
//demander a l user comb d article il souhaite 
//     tout les 2 articles le  3 est offert
//    annoncer a l user combien il doit en payer et combien sont gratuits
//    pas de calcul de prix ou de choix d'articles ... pour le moment ...)


#region Promo magasin conditions
//Console.WriteLine("Combien d'articles desirez vous ? ");
//int nbrArt = int.Parse(Console.ReadLine());
//int stock = 14;



//if (nbrArt <= stock)
//{
//    int nbrArtGr = nbrArt / 3;
//    int nbrArtPay = nbrArt - nbrArtGr;
//    Console.WriteLine($" Nbr articles à payer = {nbrArtPay} / nbr articles gratuits = {nbrArtGr}");
//}
//else
//{
//    int nbrArtGr = stock / 3;
//    int nbrArtPay = stock - nbrArtGr;
//    Console.WriteLine("Désolé il n'y a plus que 14 articles en stock");
//    Console.WriteLine($" Nbr articles à payer = {nbrArtPay} / nbr articles gratuits = {nbrArtGr}");
//} 
#endregion

#region List
//bool endGame = false;
//int[] tabUsers = new int[5];
//List<int> historique = new List<int>();


////while (endGame == false)
////{
////    for (int i = 0; i < tabUsers.Length; i++)
////    {
////        Console.WriteLine("rentrez votre nbr");
////        tabUsers[i] = int.Parse(Console.ReadLine());
////        historique.Add(tabUsers[i]);
////    }

////    foreach (int elem in tabUsers)
////    {
////        Console.Write(elem);
////    }
////    Console.WriteLine();
////    foreach (int item in historique)
////    {
////        Console.Write(item);
////    }
////}
#endregion

#region Déplacer un pion  dans un tableau 

//using System;

//string[,] tab = new string[10,10];
//int posXpion = 0; // position initiale du x à 0
//int posYpion = 0;   
//bool partieOff = false;

//while (partieOff == false)
//{
//    for (int i = 0; i < 10; i++)
//    {
//        for (int j = 0; j < 10; j++)
//        {
//            if (i == posXpion && j == posYpion)
//            {
//                Console.Write('|');
//                Console.Write('X');
//            }
//            else
//            {
//                Console.Write('|');
//                Console.Write('o');

//            }

//        }
//        Console.Write('|');
//        Console.WriteLine(  );
//    }
//    Console.WriteLine();
//    ConsoleKeyInfo choix = Console.ReadKey();
//    Console.Clear();

//    switch (choix.Key)
//    {
//        case ConsoleKey.D:
//            if (posYpion < 9)
//            {
//                posYpion++;
//            }
//            break;
//        case ConsoleKey.Q:
//            if (posYpion > 0)
//            {
//                posYpion--;
//            }
//            break;
//        case ConsoleKey.S:
//            if (posXpion < 9)
//            {
//                posXpion++;
//            }
//            break;
//        case ConsoleKey.Z:
//            if (posXpion > 0)
//            {
//                posXpion--;
//            }
//            break;
//    }
//}


#endregion

#region Boucle exemple
//bool condition = true;
//int i = 0;

//while (i < 10)
//{
//    Console.WriteLine("Coucou");
//    if (i == 5)
//    {
//        Console.WriteLine(">Flop");
//    }
//    i++;

//} 
#endregion

#region Mot de passe boucle
//string mdp = "supernova05";
//bool flag = false;
//int essais = 0;

//while (flag == false)
//{
//    Console.WriteLine("Entrez votre mot de passe : ");
//    string mdpUsers = Console.ReadLine();
//    essais++;
//    if (mdpUsers == mdp)
//    {
//        Console.WriteLine("Bienvenue David");
//        flag = true;
//    }
//    else
//    {
//        if (essais == 3)
//        {
//            Console.WriteLine("Trop d'essais ! Veuillez réessayer plus tard");
//        }
//        Console.WriteLine("Veuillez entrez un mot de passe correct");

//    }
//} 
#endregion

#region Table mult 10
//int result = 0;

//for (int i = 1; i <= 10; i++)
//{
//    for (int j = 1; j <= 10; j++)
//    {
//        result = j * i;
//        Console.WriteLine($" {i} x {j} = {result}");

//    }
//    Console.WriteLine();
//} 
#endregion

#region Distributeur
//int stockCoca = 4;
//int stockSand = 2;
//int stockPorte = 3;
//int nbrCocaAchat = 0;
//int nbrSandAchat = 0;
//int nbrPorteAchat = 0;
//int totalPanier = 0;
//bool finAchat = false;

//do
//{
//    Console.WriteLine("Entrez votre choix : 1= Coca (1 Euros), 2= Sandwich (5 Euros), +" +
//        "3= Porte (200 Euros) , 4 = Quitter");
//    int choix = int.Parse(Console.ReadLine());
//    switch (choix)
//    {
//        case 1:
//            if (stockCoca > 0)
//            {
//                Console.WriteLine("Voici votre porte");
//            }
//            stockCoca--;
//            nbrCocaAchat++;
//            totalPanier = totalPanier + 1;
//            break;

//        case 2:
//            if (stockSand > 0)
//            {
//                Console.WriteLine("Voici votre Sandwich");
//            }
//            stockSand--;
//            nbrSandAchat++;
//            totalPanier = totalPanier + 2;

//            break;

//        case 3:
//            if (stockPorte > 0)
//            {
//                Console.WriteLine("Voici votre porte");
//            }
//            stockPorte--;
//            nbrPorteAchat++;
//            totalPanier = totalPanier + 200;

//            break;
//        case 4:
//            finAchat = true;
//            break;
//    }
//    Console.WriteLine($" Votre panier comprend {nbrCocaAchat} Coca / {nbrSandAchat} Sandwich / {nbrPorteAchat} Porte +" +
//        $" Total à payer = {totalPanier}");

//} while (finAchat == false);
#endregion

#region Dictionnaire

//List<string> trilogie1 = new List<string>();
//trilogie1.Add("Liam Nesson");
//trilogie1.Add("Ewan McGregor");
//trilogie1.Add("Samuel L. Jackson");

//List<string> trilogie2= new List<string>();
//trilogie1.Add("Marc Hamill");
//trilogie1.Add("Carry Fisher");
//trilogie1.Add("Harisson Ford");

//List<string> trilogie3= new List<string>();
//trilogie1.Add("Josh Bilku");
//trilogie1.Add("Nora Calrson");
//trilogie1.Add("Bitube yopla");

//Dictionary<string, List<string>> films = new Dictionary<string, List<string>>();

//trilogie.Add(trilogie1,)

//for (int i = 0; i < trilogie.Count; i++)
//{

//}

//trilogie2.Add("la menace fantome");
//trilogie2.Add("L'attaque des clones");
//trilogie2.Add("La revanche des Siths");
//trilogie2.Add("Un nouvel espoir");
//trilogie2.Add("Le retour du Jedi");
//trilogie2.Add("L'Empire contre-attaque");
//trilogie2.Add("Le réveil de la force");
//trilogie2.Add("Le dernier Jedi");
//trilogie2.Add("L'ascension de Skywalker");

#endregion

//Dictionary<string, List<string>> articles = new Dictionary<string, List<string>>();





