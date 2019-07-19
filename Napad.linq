<Query Kind="Program" />

/*int snagaP = 100;
int umorP = 100;
int jacinaUdarcaP = 17;*/
int snagaC = 600;
//int umorC = 500;
int jacinaUdarcaC = 30;
void Main()
{
	(int snagaP,int jacinaUdarcaP) igrac;
	igrac.snagaP=50;
	//igrac.umorP=100;
	igrac.jacinaUdarcaP=20;
	while (true)
	{
		
		Console.Write("1-Napad \n2-Odmor \n3-Stanje \n");
		if(!int.TryParse(Console.ReadLine(), out int izbor))
			continue;
		
		switch (izbor)
		{
			case 1: Napad(ref igrac); break;
			case 2: Odmor(ref igrac.snagaP); break;
			case 3: Umor(ref igrac.snagaP); break;
		}
	}

}
void Napad(ref(int snagaP,int jacinaUdarcaP) igrac)
{
	Console.Write("Gde cete da napadate levo/desno \n");
	string izbor = Console.ReadLine();
	//string l = "levo";
	//string d = "desno";
	string izborC = Odbrana();

	
	if (izbor == izborC)
	{
		snagaC = snagaC - igrac.jacinaUdarcaP;

		
		Console.Write($"Skinuli ste {igrac.jacinaUdarcaP} cudovistu \n");
			Console.Write($"Ostalo mu je {snagaC} \n");
		
	}
	else
	{
		igrac.snagaP=igrac.snagaP-2;
		Console.Write("Izbego je \n");
	}
	NapadCudovista(ref igrac.snagaP);
  // Console.Write(izborC);
}
void Umor(ref int umorP)
{
	Console.Write($"Imate {umorP} health-a \n");
}
void player()
{
	int snaga=100; 
	int umor=100;
	int jacinaUdarca=17;
}
string Odbrana()
{
	Random rnd=new Random();
	int mesto=rnd.Next(1,3);
//	Console.Write(mesto);
	string izb;
	if (mesto == 1)
	{
		izb = "levo";
	}
	else
	{
		izb = "desno";
	}
	
	return izb;
}
string StranaNapada()
{
	Random rnd = new Random();
	int mesto = rnd.Next(1, 3);
	//	Console.Write(mesto);
	string izb;
	if (mesto == 1)
	{
		izb = "levo";
	}
	else
	{
		izb = "desno";
	}

	return izb;
}
void Odmor(ref int snagaP)
{
	int povecaj=5;
	if((snagaP+povecaj)>=snagaP){
	    
		Console.Write("Vec ste odmorni \n");
	}
	else
	{
		snagaP = snagaP + povecaj;}
}
/*void cudoviste()
{
	int snaga=600;
	int umor=500;
	int jacinaUdarca=10;
}*/
void NapadCudovista(ref int snagaP)
{
		string izbor=StranaNapada();
		Console.Write("Cudoviste vas napada gde cete da skrenete levo/desno \n");
	string izb = Console.ReadLine();
	if (izb == izbor)
	{
		
		snagaP = snagaP - jacinaUdarcaC;
		Console.Write($"Cudoviste vas je udarilo imate jos {snagaP} \n");
	}
		else
		{
			Console.Write("Izbegli ste napad \n");
		}
}
void meni()
{
	Console.Write("1-Napad \n2-Odmor");
}

// Define other methods and classes here