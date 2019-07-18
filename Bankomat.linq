<Query Kind="Program" />

void Main()
{
	/*
	 - BusSharp
	    autobuske linije
		svaki bus ima boj mesta
		kupovina karati
		
		korinika pitamo koja linija da li hoce povratnu i da li ima mesta u busu
		bonus(svaka karta ima broj sedista)
		
	 - Bankomaat 
	   unesi pin, pravi uplatu, isplatu,
	   +bonus ima broj racuna
	   stanje na racunu
	 - Teretana 
	   korisni broj
	   uplacenih meseci
	 - Mastermind
	   SKOCKO
	   
	
	*/
	int novac = 0;
	Console.Write("Unesite broj racuna: \n");
	int brojRacuna = int.Parse(Console.ReadLine());

	Console.Write("Unesite pin kod : \n");
	int pinKod = int.Parse(Console.ReadLine());
	while (true)
	{
		
		stampajMeni();

		//Console.Write("1- Uplata \n2-Stanje \n3-Isplata \n");
		if (!int.TryParse(Console.ReadLine(), out int izbor))
			continue;

		switch (izbor)
		{
			case 1: uplata(ref novac); break;
			case 2: stanje(ref novac); break;
			case 3: isplata(ref novac); break;
			case 4: return;
			default: break;
			
		}
	}

}
void stampajMeni()
{

		Console.Write("\n1- Uplata \n2-Stanje \n3-Isplata \n4-Izadji \n");
		
		
	
	
}
void uplata(ref int novac)
{
	Console.Write("\n Koliko zelite da uplatite novca \n");
	int pare=int.Parse(Console.ReadLine());
	novac=novac+(Math.Abs(pare));
	
}
void stanje(ref int novac)
{
	Console.Write(novac);
	
}
void isplata(ref int novac)
{
	Console.Write("Koliko zelite da uzmete novca \n");
	if(novac==0 )
	{
		Console.Write("Na racunu nemate para");
	}
	int pare=int.Parse(Console.ReadLine());
	if(Math.Abs(pare)>novac )
	{
		Console.Write("Nemate dovoljno sredstava");

	}
	else
	{
		novac = novac - (Math.Abs(pare));
	}
}
// Define other methods and classes here
