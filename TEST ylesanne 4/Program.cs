string userPIN, userName, password;
Console.WriteLine("Enter PIN: ");
userPIN = Console.ReadLine();
if(userPIN == "1234") 
{
    Console.WriteLine("Enter your username: ");
    userName = Console.ReadLine();
    Console.WriteLine("Enter your password: ");
    password = Console.ReadLine();
    if (password == "admin1234" && userName == "admin1") 
    {
        Console.WriteLine("Welcome");
    }
    else
    {
        Console.WriteLine("Invalid login credentials!");
    }
}
else 
{ 
    Console.WriteLine("Invalid PIN");
}