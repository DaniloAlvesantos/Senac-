    float dividendo, divisor, quociente;

    Console.WriteLine("Entre o valor do dividendo ..: ");
    dividendo = float.Parse(Console.ReadLine());
    Console.WriteLine("Entre o valor do divisor ....: ");
    divisor = float.Parse(Console.ReadLine());
    quociente = dividendo / divisor;

    Console.WriteLine("Resultado = {0}", quociente);