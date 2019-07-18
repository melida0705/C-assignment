<Query Kind="Program" />

void Main()
{
	/* bus plus 
	
	
	*/
	
	int [] linije;
	int brMesta=5;
	
	linije=new int[3];
	
	linije[0]=21;
	linije[1]=22;
	linije[2]=17;
	int i = 1;
	while (true)
	{
		Console.Write($"Izaberite liniju \n 1-{linije[0]}\n2-{linije[1]}\n3-{linije[2]} \n");

		if(!int.TryParse(Console.ReadLine(), out int izbor))
		{
			continue;
		}
		switch (izbor)
		{
			case 1: linija21(ref brMesta); break;


		}
	}
	
	
	
}
void linija21 (ref int brMesta)
{
	//brMesta = 5;
	Console.Write($"Ima {brMesta} slobodnih mesta");
	Console.Write("Kupite kartu da/ne ? \n");
	string izbor=Console.ReadLine();
	if(izbor=="da")
	{
		Console.Write("\nKupili ste kartu uspesno \n");
		brMesta--;
	}
	
	
}

// Define other methods and classes here
