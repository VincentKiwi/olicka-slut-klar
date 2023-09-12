// See https://aka.ms/new-console-template for more informatio﻿Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("höger eller vänster?");

string HÅLL = Console.ReadLine();

if (HÅLL == "höger")
{
    Console.WriteLine("DU DOG");
}

else if (HÅLL == "vänster")
{
    Console.WriteLine("up eller ner");

    string HÅLL2 = Console.ReadLine();

    if (HÅLL2 == "up")
    {
        Console.WriteLine("DU DOG");
    }

    else if (HÅLL2 == "ner")
    {
        Console.WriteLine("du vannnnnn");
    }
    else
    {
        Console.WriteLine("Huh?");
    }
}
else
{
   Console.WriteLine("kom i håg att använda små bokstäver börja om");
}


Console.ReadLine();