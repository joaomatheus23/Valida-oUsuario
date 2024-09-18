string login, senha;
int cont = 1;

Console.WriteLine("Digite seu login");
login = Console.ReadLine();
do
{
    if (login != "Admin")
    {
        Console.WriteLine("Login incorreto  redigite...");
        login = Console.ReadLine();
        cont++;
    }
    else
    {
        break;
    }
} while (cont < 3);
if (cont == 3 && login != "Admin")
{
    Console.WriteLine("Você estourou seu maximo de tentativas");
    Console.ReadKey();
}
else
{
    Console.WriteLine("Digite sua senha");
    senha = Console.ReadLine();
    cont = 1;

    do
    {
        if (senha != "Senha123")
        {
            Console.WriteLine("Senha incorreto  redigite...");
            senha = Console.ReadLine();
            cont++;
        }
        else
        {
            break;
        }
    } while (cont < 3);
    if (cont == 3 && senha != "Senha123")
    {
        Console.WriteLine("Você estourou seu maximo de tentativas");
    }
    else
    {
        Console.WriteLine("Parabens pelo minimo que é lembrar sua senha");
    }

}
