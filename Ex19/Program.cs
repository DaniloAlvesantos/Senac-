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

Console.WriteLine(String.Format("{0:0.00}", v1)); // valores milhar 2 casas decimais
Console.WriteLine(String.Format("{0:0.00}", v2)); // valores milhar 2 casas decimais
Console.WriteLine(String.Format("{0:0.00}", v3)); // valores milhar 2 casas decimais
Console.WriteLine(String.Format("{0:0,0.00}", v4)); // valores milhar 2 casas decimais
Console.WriteLine(String.Format("{0:0,0.00}", v5)); // valores milhar 2 casas decimais
Console.WriteLine(String.Format("{0:0,0.00}", v6)); // valores milhar 2 casas decimais
Console.WriteLine(String.Format("{0,15:0,0.00}", v4)); // valores milhar Max 15 casas
Console.WriteLine(String.Format("{0,15:0,0.00}", v5)); // valores milhar Max 15 casas
Console.WriteLine(String.Format("{0,15:0,0.00}", v2)); // valores milhar Max 15 casas
Console.WriteLine(String.Format("{0:00000}", v7)); // casas vazias completas por 0
Console.WriteLine(String.Format("{0:00000}", v8)); // casas vazias completas por 0
Console.WriteLine(String.Format("{0:00000}", v9)); // casas vazias completas por 0
Console.WriteLine(String.Format("{0,5}", v7)); // max 5 casas
Console.WriteLine(String.Format("{0,5}", v8)); // max 5 casas
Console.WriteLine(String.Format("{0,5}", v9)); // max 5 casas
Console.WriteLine(String.Format("{0:(0xx##)####-####}", x)); // Telefone
Console.WriteLine(String.Format(@"{0:###\.###\.###-###}", y)); // CPF
Console.WriteLine();
Console.WriteLine("Tecle algo para encerrar... ");
Console.ReadKey();