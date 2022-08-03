int[] a = new int[10];
int[] b = new int[10];
int i;

for(i = 0; i <= 9; i++)
{
    Console.WriteLine("media de {0,2}° aluno:", i + 1);
    a[i] = int.Parse(Console.ReadLine());
}

for( i = 0; i <= 9; i++)
    if (i % 2 == 0)
        b[i] = a[i] * 5;
    else
        b[i] = a[i] + 3;
    
Console.WriteLine();

for(i = 0; i <= 9; i++)
{
    Console.WriteLine("A[{0}] = {1,4} /", i, a[i]);
    Console.WriteLine("B[{0}] = {1,4}", i, b[i]);
    Console.WriteLine();
}