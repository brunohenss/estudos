using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

/*Console.Write("Digite seu nome: ");
string name = Console.ReadLine();
Console.WriteLine($"Olá {name}");

Console.WriteLine("Digite seu ano de nascimento: ");
int year = int.Parse(Console.ReadLine());
int age = 2024 - year;

Console.WriteLine($"Você tem {age} anos!");

if (age >= 17)

{
    Console.WriteLine("E já é maior de idade!");
    Console.WriteLine($"{name}, para tirar sua habilitação, digite seu CPF:");
    long cpf = long.Parse(Console.ReadLine());
    bool cpfConfirma = cpf == cpf;
    Console.WriteLine($"Confirme seu documento: {cpfConfirma}");
    Console.ReadLine();

    if (cpfConfirma == true)

    {

        Console.WriteLine("Você receberá um email de confirmação, verifique sua caixa de entrada");
        Console.ReadLine();

    }

    else if (cpfConfirma == false)

    {
        Console.WriteLine("Documento inválido, tenta novamente");
    };
}


else
{
    Console.WriteLine("Desculpe, você ainda não pode tirar sua habilitação");
}
Console.ReadLine(); */

Console.WriteLine("Digite uma letra:...");
string? letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":

        Console.WriteLine("A letra digitada é uma VOGAL");
        break;


    default:

        Console.WriteLine("O caractere informado não é uma VOGAL");
        break;
}
