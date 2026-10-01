using SzallodaApp;

Szoba norma = new Szoba(101,20000);
Lakosztaly suit = new Lakosztaly(501, 40000, 150000);

norma.Alapar = -5000;
// nem mukodok mert
Console.WriteLine($"Normal Szoba:{norma}");
Console.WriteLine($"Lakosztaly:{suit}");