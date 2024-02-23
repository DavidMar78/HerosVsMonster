
int[] tabCode = new int[5];
int[] codeMaster = new int[5];
List<int> listHisto = new List<int>();
bool flag = false;
bool gameOver = false;
int essais = 0;

// Random du code mystere 
for (int i = 0; i < codeMaster.Length; i++)
{
    Random rnd = new Random();
    codeMaster[i] = rnd.Next(0,9);
}

// Début de la boucle Affichage/essais
while (gameOver == false)
{
    // affichage départ

    Affichage();
    essais++;

    // Rentré des nbr users
    foreach (int item in codeMaster)
    {
        Console.Write(item);
    }
    Console.WriteLine();
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"Rentrez proposition {i + 1}");
        tabCode[i] = int.Parse(Console.ReadLine());
        listHisto.Add(tabCode[i]);
        flag = true;
        Console.Clear();
        Affichage();
    }
    
    Console.Clear();
    //------------------------------------------------

}
void Affichage()
{
    Console.WriteLine("   |--------------------------|");
    Console.WriteLine("   |------  MasterMind  ------|");
    Console.WriteLine("   |--------------------------|");

    Console.Write("   |    ");
    for (int i = 0; i < 5; i++)
    {
        if (tabCode[i] == codeMaster[i])
        {
            Console.Write("  |");
        }
    }
 
    Console.WriteLine();
    Console.WriteLine("   |                          ");
    Console.WriteLine("   |     Votre proposition    ");
    Console.Write("   |    ");
    for (int i = 0; i < 5; i++)
    {
        if (flag == true)
        {
            Console.Write($" {tabCode[i]} |");
        }

    }

    Console.WriteLine();
    Console.WriteLine("   |                          ");
    Console.WriteLine("   |        Historique        ");
    Console.Write("   |    ");

    for (int i = 0; i < listHisto.Count; i++)
    {
        Console.Write($" {listHisto[i]} |");
    }

    Console.WriteLine();
    Console.Write("   ----------------------------");
    Console.WriteLine();
    Console.WriteLine();
}

