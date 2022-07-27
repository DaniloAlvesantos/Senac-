int qnt;
string gas;
double G, A, val, desc;

G = 3.30;
A = 2.90;

Console.WriteLine("Qual é o tipo da gasolina ?");
Console.WriteLine("G para gasolina");
Console.WriteLine("A para Alcool");
gas = Console.ReadLine();
Console.WriteLine("Quantidade ");
qnt = int.Parse(Console.ReadLine());
if (gas == "G" || gas == "g")
{
    if (qnt >= 20)
    {
        desc = 0.04;
    } else 
    {
        desc = 0.06;
    }
    val = (G * qnt) - desc;
    Console.WriteLine("Valor total com {0}% de desconto = {1} ", desc, val);
}
if (gas == "A" || gas == "a")
{
    if(qnt >= 20)
    {
        desc = 0.03;
    } else
    {
        desc = 0.05;
    }
    val = (A * qnt) - desc;
    Console.WriteLine("Valor total com {0}% de desconto = {1} ", desc, val);
}