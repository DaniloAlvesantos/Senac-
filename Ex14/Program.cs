decimal dividendo, divisor, quociente;

Console.WriteLine("Entre o valor do dividendo ..: ");
dividendo = decimal.Parse(Console.ReadLine());
Console.WriteLine("Entre o valor do divisor ....: ");
divisor = decimal.Parse(Console.ReadLine());
try
{
    quociente = dividendo / divisor;
    Console.WriteLine("Resultado = {0}", quociente);
}


catch (DivideByZeroException dbze)
{
    Console.WriteLine();
    Console.WriteLine("Error - divisão por zero");
}


    
