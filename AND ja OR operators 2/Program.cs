//  Kooli sisse saab alljärgnevatel tingimustel
// Math >= 90; ja siis  chemistry >= 90 või biology >= 90
// Selleks sean alljärgnevad tingimused
// math && chemistry || math && biology || chemistry && biology


int math, biology, chemistry;
Console.WriteLine("Sisestage oma matemaatika tulemus:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Sisestage oma bioloogia tulemus:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Sisestage oma keemia tulemus:");
chemistry = Int32.Parse(Console.ReadLine());

if ((math >= 90 && chemistry >= 90) || (math >= 90 && biology >= 90) || (chemistry >= 90 && biology >= 90))
{
    Console.WriteLine("Õnnitlen, te kvalifitseerute meile õppima asuma!");
}
else
{
    Console.WriteLine("Kahjuks ei saa teie taotlust vastu võtta. Võibolla sobib teile mõni meie teine aine");
}
