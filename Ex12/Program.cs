int nr, pedido;
Random Randomico = new Random();
nr = Randomico.Next(1, 6);
Console.Write("Digite um número entre 1 e 5 ");
pedido = int.Parse(Console.ReadLine());

if (pedido == nr)
	// Se o pedido ( numero lido ) foi igual a o número sorteado ( random )...
	Console.WriteLine("Acertou - foi sorteado: {0}", nr);
else
	Console.WriteLine("Errou - foi sorteado: {0}", nr);