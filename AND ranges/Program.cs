// spiker
// temp <= 0 -> Jäätav külm
// temp > 0 AND temp <= 10 -> Külm
// temp > 10 AND temp <= 15 -> Jahe
// temp > 15 AND < 20 -> Soe
// temp >= 20 AND temp < 30 -> Kuum
// temp >= 30 -> Keevalt palav

Console.WriteLine("Sisestage temperatuur: ");
int temp = Int32.Parse(Console.ReadLine());

if (temp >= 30) { Console.WriteLine("Keetvalt kuum"); }
else if (temp >= 20 && temp < 30) { Console.WriteLine("Kuum"); }
else if (temp > 15 && temp < 20) { Console.WriteLine("Soe"); }
else if (temp > 10 && temp <= 15) { Console.WriteLine("Jahe"); }
else if (temp > 0 && temp <= 10) { Console.WriteLine("Külm"); }
else if (temp <= 0) { Console.WriteLine("Jäätavalt külm"); }
else { Console.WriteLine("Ei saanud aru. Nägemist!"); }


