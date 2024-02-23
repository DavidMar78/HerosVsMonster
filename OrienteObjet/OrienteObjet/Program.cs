////*
//Définir les classes suivantes 

//Personnages
//Guerrier, Pretre, Mage

//Chaque personnage sera définie par 
//	- Nom (du perso)

//		!!Caractéristique!!
//	- Force, Endurance, Intelligence, Sagesse
//		chaque carac sera en lecture seule

//		une méthode qui va créer les valeurs de base (tips : utiliser la méthode random de la classe)
//			Valeur comprise entre 10 et 20


//Si guerrier => Force et Endurance + 3
//Si pretre => Sagesse +4 Intel + 2
//Si mage => Intel + 4 Sagesse + 2  //*

using OrienteObjet;

Guerrier guerrier = new Guerrier();
guerrier._Nom = "Lapidis";
guerrier.CalculCaract();
Console.WriteLine($" Nom de votre guerrier : {guerrier._Nom} \n Force = {guerrier.Force} \n Endu = {guerrier.Endu} \n Intel = {guerrier.Intel} \n Sagesse = {guerrier.Sagesse}");

Pretre pretre = new Pretre();
pretre._Nom= "Nainkitu";
pretre.CalculCaract();
Console.WriteLine($" Nom de votre pretre : {pretre._Nom} \n Force = {pretre.Force} \n Endu = {pretre.Endu} \n Intel = {pretre.Intel} \n Sagesse = {pretre.Sagesse}");

Mage mage = new Mage();
mage.CalculCaract();
Console.WriteLine($" Nom de votre mage : {mage._Nom} \n Force = {mage.Force} \n Endu = {mage.Endu} \n Intel = {mage.Intel} \n Sagesse = {mage.Sagesse}");