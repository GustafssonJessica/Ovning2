

//Övning 2 - Flow Control. Övningen innehåller bland annat switch, while, if och for-loopar

using System.Diagnostics;
using System.Diagnostics.Metrics;

do
{
    //Huvudmeny när programmet körs
    string menuText = "Du har kommit till huvudmenyn.\nFör att navigera och testa nya funktioner, skriv in siffra på den funktion du vill prova:" +
        "\n0) Avsluta programmet" +
        "\n1) Se ditt pris på biobiljett" +
        "\n2) Se ditt sällskaps pris på bio" +
        "\n3) Få en text upprepad 10 gånger" +
        "\n4) Skriv en mening och få ut det tredje ordet ";
    string? input = GetNonEmptyInput(menuText);

    //Switch som fortgår tills användaren avslutar programmet genom att mata in "0".
    //Vid inmatning av siffrorna 1 - 4 körs olika funktioner. Vid övrig inmatning visas meddelande om ogiltig input
    switch (input)
    {
        case "0":
            // Avslutar programmet
            Environment.Exit(0);
            break;
        case "1":
            SingleCinemaTicket();
            break;
        case "2":
            MultipleCinemaTickets();
            break;
        case "3":
            RepeatTenTimes();
            break;
        case "4":
            TheThirdWord();
            break;
        default:
            //Felmeddelande om anv anger ogiltig input
            Console.WriteLine("Du har angett felaktig input!");
            break;
    }
    Console.WriteLine("\nVar god tryck på Enter för att komma tillbaka till huvudmenyn!");
    Console.ReadLine(); //Väntar på att användaren ska trycka enter innan menyn visas igen
    Console.Clear(); //Tar bort användarens tidigare inmatningar

} while (true); //Do-while-loop för att menyn ska visas fram tills användaren väljer alternativ 0



//Metod för att beräkna pris på biobiljett utifrån ålder
static void SingleCinemaTicket()
{
    int age = GetValidInt("Var god ange ålder i siffor: ");
    string price;
    if (age < 5 || age > 100)
        price = "Personer under 5 år eller över 100 år: Gratis";
    else if (age < 20)
        price = "Ungdomspris: 80kr";
    else if (age > 64)
        price = "Pensionärspris: 90kr";
    else
        price = "Standardpris: 120kr";
    Console.WriteLine(price);
}

//Metod för att beräkna totalpris på biobiljetter för grupp av människor
static void MultipleCinemaTickets()
{
    int numberOfPeople = GetValidInt("Hur många personer ska gå på bion?");
    int totalPrice = 0;
    int age;
    for (int i = 1; i <= numberOfPeople; i++) //för varje person som ska på bio, fråga efter ålder för att få ut kostnad
    {
        age = GetValidInt($"Hur gammal är person nummer {i}?: ");
        if (age < 5 || age > 100) //ingen ytterligare kostnad för personer med dessa åldrar
            totalPrice += 0;
        else if (age < 20)
            totalPrice += 80;
        else if (age > 64)
            totalPrice += 90;
        else
            totalPrice += 120;
    }
    Console.WriteLine($"För ett sällskap på {numberOfPeople} personer så blir kostnaden {totalPrice} kronor!");
}

//Metod för att upprepa användarens text 10 gånger
static void RepeatTenTimes()
{
    string text = GetNonEmptyInput("Ange en godtycklig text: ");
    Console.WriteLine("\n");
    for (int i = 1; i <= 10; i++)
    {
        // Vid alla loopar förutom den 10e så skrivs "," ut efter texten
        if (i == 10) 
            Console.Write($"{i}. {text} \n\n");
        else
            Console.Write($"{i}. {text}, ");
    }
}

//Metod för att skriva ut det tredje ordet i en mening som användaren matar in
static void TheThirdWord()
{
    string sentence = GetNonEmptyInput("Var god ange en mening med minst tre ord: ");
    var split = sentence.Split(' ');
    Console.WriteLine($"Det tredje ordet är: \"{split[2]}\"");
}

// Metod för att säkerställa att användaren matar in en icke-tom sträng
static string GetNonEmptyInput(string message)
{
    Console.WriteLine(message);
    string? input = string.Empty;
    bool validInput = false;
    do
    {
        input = Console.ReadLine();
        if (String.IsNullOrEmpty(input))
        {
            Console.WriteLine("Fältet är tomt. Var god försök igen: ");
        }
        else
        {
            validInput = true;
        }
    } while (!validInput);
    return input;
}

// Metod för att säkerställa att användaren matar in en sträng som kan omvandlas till en int
static int GetValidInt(string message)
{
    int number = 0;
    bool isANumber = false;

    while (!isANumber)
    {
        isANumber = int.TryParse((GetNonEmptyInput(message)), out number);
        if (!isANumber)
        {
            Console.WriteLine("\nOgiltig inmatning, endast heltal accepteras!");
        }
        else
        {
            isANumber = true;
        }
    }
    return number;
}