/*
    Programa: Formatação
 */

double v1 = 123.456,
    v2 = 234.5,
    v3 = 345.0,
    v4 = 12345.67,
    v5 = 1234.5,
    v6 = 12345.6789;
int v7 = 123,
    v8 = 12,
    v9 = 1;
long x = 1234567890, 
    y = 12345678901;

Console.WriteLine(String.Format("{0:0.00}", v1)); // Dinheiro
Console.WriteLine(String.Format("{0:0.00}", v2)); // Dinheiro
Console.WriteLine(String.Format("{0:0.00}", v3)); // Dinheiro
Console.WriteLine(String.Format("{0:0,0.00}", v4)); // Dinheiro
Console.WriteLine(String.Format("{0:0,0.00}", v5)); // Dinheiro
Console.WriteLine(String.Format("{0:0,0.00}", v6)); // Dinheiro
Console.WriteLine(String.Format("{0,15:0,0.00}", v4)); // Max 15 casas
Console.WriteLine(String.Format("{0,15:0,0.00}", v5)); // Max 15 casas
Console.WriteLine(String.Format("{0,15:0,0.00}", v2)); // Max 15 casas
Console.WriteLine(String.Format("{0,5}", v7)); // max 5 casas
Console.WriteLine(String.Format("{0,5}", v8)); // max 5 casas
Console.WriteLine(String.Format("{0,5}", v9)); // max 5 casas
Console.WriteLine(String.Format("{0:(0xx##)####-####}", x)); // Telefone
Console.WriteLine(String.Format(@"{0:###\.###\.###-###}", y)); // CPF

    string r = "9";
    int n = 4;
    for (int i = 1; i < n; i++)
    {
        r += String.Format("{0}", r);
    }
    Console.WriteLine(int.Parse(r));


Console.WriteLine();
Console.WriteLine("Tecle algo para encerrar... ");
Console.ReadKey();