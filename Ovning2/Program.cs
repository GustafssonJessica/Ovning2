

Console.WriteLine("Du har kommit till huvudmenyn.\nFör att navigera och testa nya funktioner, skriv in siffra: ");
string input = Console.ReadLine();

bool loop = true;

while (loop)
{
    switch (input)
    {
        case "0":
            loop = false;
            break;
        default:
            Console.WriteLine("Du har angett felaktig input");
            break;
    }
}