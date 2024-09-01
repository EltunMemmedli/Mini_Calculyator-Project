// Birinci eded
Main:

Console.Write("Birinci ededi daxile edin: ");
decimal birinci_eded = decimal.Parse(Console.ReadLine());

// Ikinci eded
Console.Write("Ikinci ededi daxil edin: ");
decimal ikinci_eded = decimal.Parse(Console.ReadLine());

// Emeli daxil edin
Console.Write("Hansi emel daxil edeceksiniz: ");
string emel = Console.ReadLine();

//Toplayir
if (emel == "+")
{
    Console.WriteLine(Plus(birinci_eded, ikinci_eded));
    goto Main;

}
else if (emel == "-")
{
    Console.WriteLine(Minus(birinci_eded, ikinci_eded));
    goto Main;

}
else if (emel == "*")//Vurma
{
    Console.WriteLine(Hasil(birinci_eded, ikinci_eded));
    goto Main;

}
else if (emel == "/")//Bolme
{
    Console.WriteLine(Dividing(birinci_eded, ikinci_eded));
    goto Main;
}
else
{
    goto Main;

}











// Toplama emeli
decimal Plus(decimal num_1, decimal num_2)
{
    return num_1 + num_2;
}

// Cixma emeli
decimal Minus(decimal num_1, decimal num_2)
{
    return num_1 - num_2;
}

// Vurma emeli
decimal Hasil(decimal num_1, decimal num_2)
{
    return num_1 * num_2;
}

// Bolme emeli
decimal Dividing(decimal num_1, decimal num_2)
{
    return num_1 / num_2;
}