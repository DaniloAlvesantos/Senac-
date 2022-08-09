class program {
    public static float r, a, b;
    public static string MSG = "Tecle algo para continuar...";
    static void Main(String[] args)
    { 
        string opcao;
        opcao = "0";
        while (opcao != "5")
        {
            Console.Title = "Calculadora";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine("Main menu");
            Console.WriteLine();
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
            Console.WriteLine();
            Console.WriteLine("Escolha a opção");
            opcao = Console.ReadLine();
            if (opcao != "5")
            {
                switch (opcao)
                {
                    case "1":
                        RotSoma();
                        break;
                    case "2":
                        RotSubtracao();
                        break;
                    case "3":
                        RotMultiplicacao();
                        break;
                    case "4":
                        RotDivisao();
                        break;
                    default:
                        Console.WriteLine("valor inválido");
                        Console.WriteLine(MSG);
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
    private static void RotDivisao()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Rotina de Divisão");
        Console.WriteLine();
        Entrada();
        if (b == 0)
        {
            Console.WriteLine();
            Console.WriteLine("Erro");
            Console.WriteLine(MSG);
            Console.ReadKey();
        }
        else
        {
            r = Calculo(a, b, "/");
            Saida();
        }
    }
    private static void RotMultiplicacao()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Rotina de Multiplicação");
        Console.WriteLine();
        Entrada();
        r = Calculo(a, b, "*");
        Saida();
    }
    private static void RotSoma()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Rotina de Soma");
        Console.WriteLine();
        Entrada();
        r = Calculo(a, b, "+");
        Saida();
    }
    private static void RotSubtracao()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Subtração");
        Console.WriteLine();
        Entrada();
        r = Calculo(a, b, "-");
        Saida();
    }
    public static float Calculo(float x, float y, string operador)
    {
        float z = 0;
        switch (operador)
        {
            case "+": z = x + y; break;
            case "-": z = y - x; break;
            case "*": z = x * y; break;
            case "/": z = x / y; break;
        }
        return z;
    }
    private static void Entrada()
    {
        Console.Write("Entre um valor para A:");
        a = float.Parse(Console.ReadLine());
        Console.WriteLine("Entre um valor para B:");
        b = float.Parse(Console.ReadLine());
    }
    private static void Saida()
    {
        Console.WriteLine();
        Console.WriteLine("O resultado entre A e B = {0:0.00}", r);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(MSG);
        Console.ReadKey();
    }
}
