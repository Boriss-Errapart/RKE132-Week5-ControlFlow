// seame tingimused
// math >= 90; Biology >= 90; Chemistry >= 90.

int math, biology, chemistry;
Console.WriteLine("Sisestage oma matemaatika tulemus:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Sisestaga oma bioloogia tulemus:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Sisestage oma keemia tulemus:");
chemistry = Int32.Parse(Console.ReadLine());

if(math >= 90 && biology >= 90 && chemistry >= 90)
{
    Console.WriteLine("Õnnitlen, te kvalifitseerute meile õppima asuma!");
}
else 
{
    Console.WriteLine("Kahjuks ei saa teie taotlust vastu võtta. Võibolla sobib teile mõni meie teine aine");
}