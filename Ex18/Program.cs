/*
    Programa: Tabuada
    Autor: Danilo Alves
    Data: 29/07/2022
 */
int n, i, r;
string answer;

answer = "S";

while(answer.ToUpper() == "S")
{
    Console.Clear();
    Console.WriteLine("Programa - Tabuada");
    Console.WriteLine();
    Console.WriteLine("Informe o valor :");
    n = int.Parse(Console.ReadLine());
    Console.WriteLine();

    for(i = 1; i <= 10; i++)
    {
        r = n * i;
        Console.WriteLine("{0,2} X {1,2} = {2,3}",n,i,r);
    }

    Console.WriteLine();
    Console.WriteLine("Deseja continuar ?");
    Console.WriteLine("[s] para sim ou [n] para não: ");
    answer = Console.ReadLine();
}