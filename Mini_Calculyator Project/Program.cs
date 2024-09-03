Main:
bool IsDigit = false;

while (!IsDigit)
{
    Birinci:
    Console.Write("Birinci eded: ");
    string FirstNum = Console.ReadLine();

    if (decimal.TryParse(FirstNum, out decimal birinci_eded))
    {
        IsDigit = true;
        Console.Clear();

    Ikinci:
        Console.WriteLine($"Birnici eded: {birinci_eded}");
        Console.Write("Ikinci eded: ");
        string SecondNum = Console.ReadLine();

        if (decimal.TryParse(SecondNum, out decimal ikinci_eded))
        {
           

            Console.Clear();

            Console.WriteLine($"Birinci ede: {birinci_eded},\n" +
                              $"Ikinci eded: {ikinci_eded}");

            emel:
            Console.Write("Hansi emel daxil edeceksiniz: ");
            string emel = Console.ReadLine();


            if (emel == "+")
            {
                Console.WriteLine(Plus(birinci_eded, ikinci_eded));

                bool Kecmek = false;

                while (!Kecmek)
                {
                    Console.WriteLine("Ilk pencereye qayitmaq ucun 'f' duymesine basin");
                    char Kec = Console.ReadLine()[0];

                    if (Kec == 'f')
                    {
                        Kecmek = true;
                        Console.Clear();
                        goto Main;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Duzgun duymeni basdiginizdan emin olun!");
                    }

                }



            }
            else if (emel == "-")
            {
                Console.WriteLine(Minus(birinci_eded, ikinci_eded));

                bool Kecmek = false;

                while (!Kecmek)
                {
                    Console.WriteLine("Ilk pencereye qayitmaq ucun 'f' duymesine basin");
                    char Kec = Console.ReadLine()[0];

                    if (Kec == 'f')
                    {
                        Kecmek = true;
                        Console.Clear();
                        goto Main;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Duzgun duymeni basdiginizdan emin olun!");
                    }

                }
            }
            else if (emel == "*")
            {
                Console.WriteLine(Hasil(birinci_eded, ikinci_eded));
                bool Kecmek = false;

                while (!Kecmek)
                {
                    Console.WriteLine("Ilk pencereye qayitmaq ucun 'f' duymesine basin");
                    char Kec = Console.ReadLine()[0];

                    if (Kec == 'f')
                    {
                        Kecmek = true;
                        Console.Clear();
                        goto Main;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Duzgun duymeni basdiginizdan emin olun!");
                    }

                }

            }
            else if (emel == "/")
            {
                Console.WriteLine(Dividing(birinci_eded, ikinci_eded));
                bool Kecmek = false;

                while (!Kecmek)
                {
                    Console.WriteLine("Ilk pencereye qayitmaq ucun 'f' duymesine basin");
                    char Kec = Console.ReadLine()[0];

                    if (Kec == 'f')
                    {
                        Kecmek = true;
                        Console.Clear();
                        goto Main;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Duzgun duymeni basdiginizdan emin olun!");
                    }

                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Birinci ede: {birinci_eded},\n" +
                                  $"Ikinci eded: {ikinci_eded}");
                Console.WriteLine("Duzgun emel daxil edin!");
                goto emel;

            }

        }
        else
        {
            Console.Clear();
            Console.WriteLine("Ikinci ededi duzgun daxil edin!");
            goto Ikinci;

        }


    }
    else
    {
        Console.Clear();
        Console.WriteLine("Birinci ededi duzgun daxil edin!");
        goto Birinci;

    }
    
}











decimal Plus(decimal num_1, decimal num_2)
{
    return num_1 + num_2;
}


decimal Minus(decimal num_1, decimal num_2)
{
    return num_1 - num_2;
}


decimal Hasil(decimal num_1, decimal num_2)
{
    return num_1 * num_2;
}


decimal Dividing(decimal num_1, decimal num_2)
{
    return num_1 / num_2;
}