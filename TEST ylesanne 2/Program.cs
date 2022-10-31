Console.WriteLine("Windows operatsioonisüsteem");
Console.WriteLine("Palun sisesta oma kasutaja tunnus:");
string userName = Console.ReadLine();
Console.WriteLine("Palun sisesta oma kasutaja parool:");
string password = Console.ReadLine();



if ((userName == "admin") && (password == "admin1234"))
{
    Console.WriteLine("Welcome!");
}
else
{
    Console.WriteLine("Invalid login credentials.");
}