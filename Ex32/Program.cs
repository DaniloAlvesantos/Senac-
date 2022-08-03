string[] nome = new string[5];
int i, j;
string x;

for(i = 0; i <= 4; i++)
{
    Console.WriteLine("Entre o {0}° nome: ", i + 1);
    nome[i] = Console.ReadLine();
}

for(i = 0; i <= 3; i++)
    for(j = i + 1; j <= 4; j++)
        if (nome[j].CompareTo(nome[j]) > 0)
        {
            x = nome[i];
            nome[i] = nome[j];
            nome[j] = x;
        }

Console.WriteLine("Lista de nomes ordenada");
Console.ReadLine();

for(i = 0; i <= 4; i++)
    Console.WriteLine(nome[i]);