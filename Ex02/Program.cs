float ht, vh, pd, sb, td, sl;

Console.Write("Horas trabalhadas...................:");
ht = float.Parse(Console.ReadLine());
Console.Write("Valor de horas..................:");
vh = float.Parse(Console.ReadLine());
Console.Write("Valor do percentual de desconto.:");
pd = float.Parse(Console.ReadLine());
// sb = salario bruto
sb = ht * vh;
td = (pd / 100) * sb;
// Td = total de desconto
sl = sb - td;
// sl = salario liquido

Console.WriteLine();
Console.Write("Salario liquido.....................:");
Console.WriteLine(sl.ToString("##,##0.00"));
