static int Mcd(int num1, int num2)
{
    while (num2 != 0)
    {
        int temp = num2;
        num2 = num1 % num2;
        num1 = temp;
    }

    return num1;
}

int num1;
    int num2;

Console.Write("Inserisci il primo numero: ");
while (!int.TryParse(Console.ReadLine(), out num1))
{
    Console.WriteLine("errore");

}


Console.Write("Inserisci il secondo numero: ");
while (!int.TryParse(Console.ReadLine(), out num2))
{
    Console.WriteLine("errore");

}



Console.WriteLine($"MCD risulta: {Mcd(num1, num2)}");
