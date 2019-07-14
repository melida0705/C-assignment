<Query Kind="Program" />

void Main()
{
	Console.Write("Unesite broj polja ");
	int brojPolja = int.Parse(Console.ReadLine());
	Console.Write(brojPolja);
	Console.Write($"\n Unesite broj mina veci od 0 a manji od {brojPolja*brojPolja}\n");
	int brojMina=int.Parse(Console.ReadLine());
	Console.Write(brojMina+"\n");
	uint [,] tabla=new uint[brojPolja,brojPolja];
	
	postaviTablu(tabla,brojPolja,brojMina);
	prikazi(tabla,brojPolja);
}
bool postaviMine(int x,int y,uint [,] tabla, int brojPolja)
{
	if (tabla[x, y] == 9)
		return true;

	for (int i = x - 1; i <= x + 1; i++)
		for (int j = y - 1; j <= y + 1; j++)
			if (i >= 0 && i < brojPolja && j >= 0 && j < brojPolja)
				if (i == x && j == y)
					tabla[i, j] = 9;
				else if (tabla[i, j] != 9)
					tabla[i, j]++;
	return false;
}
void postaviTablu(uint [,] tabla,int brojPolja,int brojMina)
{
	Random rnd=new Random();
	for(int i=0;i<brojPolja;i++)
	   {
	   	int x=rnd.Next(0,brojPolja);
		int y = rnd.Next(0, brojPolja);
		if (postaviMine(x, y, tabla, brojPolja))
			brojMina++;
	}
	
}
void prikazi(uint[,]tabla,int brojPolja)
{
	for (int i = 0; i < brojPolja; i++)
	{

		for (int j = 0; j < brojPolja; j++)
		{
			Console.Write(tabla[i, j] == 9 ? "* " : tabla[i, j].ToString() + " ");
		}
		Console.Write("\n");
	}
}
// Define other methods and classes here
