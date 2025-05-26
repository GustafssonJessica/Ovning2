
bool loop = true;

while (loop)
{
    Console.WriteLine("Du har kommit till huvudmenyn.\nFör att navigera och testa nya funktioner, skriv in siffra på den funktion du vill prova:" +
        "\n1) Se ditt pris på bio");
    string input = Console.ReadLine();

    switch (input)
    {
        case "0":
            loop = false; // "stänger ned programmet"?
            break;
        case "1": //Bio
            Console.WriteLine("Välj alternativ: " +
                "\n1) Jag ska gå själv på bio " +
                "\n2)Det är fler än en person");
            string choice = Console.ReadLine();

            if (choice== "1")
            {
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

            }
            else if (choice == "2")
            {
                Console.WriteLine("Hur många personer ska gå på bion?");
                int numberOfPeople = int.Parse(Console.ReadLine());
                int totalPrice = 0;
                for (int i = 1; i <= numberOfPeople; i++)
                {
                    Console.WriteLine($"Hur gammal är person nummer {i}?: ");
                    int age = int.Parse(Console.ReadLine());
                    if (age < 20)
                        totalPrice += 80;
                    else if (age > 64)
                        totalPrice += 90;
                    else
                        totalPrice += 120;
                }
                Console.WriteLine($"För ett sällskap på {numberOfPeople} personer så blir kostnaden {totalPrice} kronor!");
            }
            break;
        default:
            Console.WriteLine("Du har angett felaktig input");
            break;
    }
}


