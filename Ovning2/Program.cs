

do
{
    Console.WriteLine("Du har kommit till huvudmenyn.\nFör att navigera och testa nya funktioner, skriv in siffra på den funktion du vill prova:" +
        "\n0) Avsluta programmet" +
        "\n1) Se ditt pris på bio" +
        "\n2) Se ditt sällskaps pris på bio" +
        "\n3) Få en text upprepad 10 gånger" +
        "\n4) SKriv en mening och få ut det tredje ordet ");
    string input = Console.ReadLine();

    switch (input) //tror det är ok med do while, för han säger "evighetsloop" i föreläsningen om en do while
    {
        case "0":
            Environment.Exit(0); // Avslutar programmet
            break;
        case "1":
            Console.WriteLine("Var god ange ålder i siffor: ");
            int age = int.Parse(Console.ReadLine());
            string price;
            if (age < 20)
            {
                price = "Ungdomspris: 80kr";
            }
            else if (age > 64)
            {
                price = "Pensionärspris: 90kr";
            }
            else
            {
                price = "Standardpris: 120kr";
            }
            Console.WriteLine(price);
            break;


        case "2":
            Console.WriteLine("Hur många personer ska gå på bion?");
            int numberOfPeople = int.Parse(Console.ReadLine());
            int totalPrice = 0;
            for (int i = 1; i <= numberOfPeople; i++)
            {
                Console.WriteLine($"Hur gammal är person nummer {i}?: ");
                age = int.Parse(Console.ReadLine()); //använder samma age som ovan. ok?
                if (age < 20)
                    totalPrice += 80;
                else if (age > 64)
                    totalPrice += 90;
                else
                    totalPrice += 120;
            }
            Console.WriteLine($"För ett sällskap på {numberOfPeople} personer så blir kostnaden {totalPrice} kronor!");
            break;

        case "3":
            //upprepa 10 gånger
            Console.WriteLine("Ange en godtycklig text: ");
            string text = Console.ReadLine();
            Console.WriteLine("\n");
            for (int i = 1; i <= 10; i++)
            {
                if (i == 10)
                    Console.Write($"{i}. {text} \n\n");
                else
                    Console.Write($"{i}. {text}, ");
            }
            break;
        case "4":
            //nått med tre ord
            Console.WriteLine("Var god ange en mening med minst tre ord: ");
            var split = Console.ReadLine().Split(' ');
            Console.WriteLine($"Det tredje ordet är: \"{split[2]}\"");

            break;

        default:
            Console.WriteLine("Du har angett felaktig input");
            break;
    }
    Console.WriteLine("\n"); //för att separera menyn från det som skrivits innan 
} while (true);
Console.ReadLine(); //för att inte få upp text nederst i konsolen

