using System;

class Program
{
	static void Main(string[] args)
	{
		// Pobieranie oceny od użytkownika
		Console.WriteLine("Podaj ocenę ucznia:");
		int ocena = Convert.ToInt32(Console.ReadLine());

		// Mapowanie oceny na jej opis
		string opis = "";
		switch (ocena)
		{
			case 6:
				opis = "Celujący";
				break;
			case 5:
				opis = "Bardzo dobry";
				break;
			case 4:
				opis = "Dobry";
				break;
			case 3:
				opis = "Dostateczny";
				break;
			case 2:
				opis = "Dopuszczający";
				break;
			case 1:
				opis = "Niedostateczny";
				break;
			default:
				opis = "Niepoprawna ocena";
				break;
		}

		// Wyświetlanie opisu oceny
		Console.WriteLine(opis);
	}
}