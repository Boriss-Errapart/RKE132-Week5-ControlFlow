//  Kooli sisse saab alljärgnevatel tingimustel
// Math >= 90; OR Chemistry >= 90

int math, chemistry;
Console.WriteLine("Sisestage oma matemaatika tulemus:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Sisestage oma keemia tulemus:");
chemistry = Int32.Parse(Console.ReadLine());

if (math >= 90 || chemistry >= 90)
{
    Console.WriteLine("Õnnitlen, te kvalifitseerute meile õppima asuma!");
}
else
{
    Console.WriteLine("Kahjuks ei saa teie taotlust vastu võtta. Võibolla sobib teile mõni meie teine aine");
}
