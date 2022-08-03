float[] mdg = new float[8];
float soma = 0, media;
int i;

for (i = 0; i <= 7; i++)
{
    Console.WriteLine("Media {0}° aluno:", i + 1);
    mdg[i] = float.Parse(Console.ReadLine());
    if (mdg[i] == 0 || mdg[i] > 10)
        do
        { 
            Console.WriteLine("Erro");
            Console.WriteLine("Digite valor diferente de 0 ou maior que 10");
            mdg[i] = float.Parse(Console.ReadLine());
        }
        while (mdg[i] == 0 || mdg[i] > 10);
        soma += mdg[i]; // Ele vai acumulando os valores de cada média
}
Console.WriteLine(soma);
media = soma / 8;

Console.WriteLine();
Console.WriteLine("Media geral = {0:0.00}", media); 