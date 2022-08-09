using System;

namespace teste
{
    internal class Program
    {
        public class animal
        {
            public string nome { get; }
            public string raca { get; }
            public string color { get; }
            public int age { get; }
            public int val = 0;
            public animal(string v1, string v2, string v3, int v4)
            {
                nome = v1;
                raca = v2;
                color = v3;
                age = v4;

            }
            public void about()
            {
                Console.WriteLine($"Nome:{this.nome}");
                Console.WriteLine($"Raça:{this.raca}");
                Console.WriteLine($"Cor: {this.color}");
                Console.WriteLine($"Idade: {this.age}");
            }
            public int Play()
            {
                int x = 0;
                Console.WriteLine("Digite quantos minutos ira brincar com o cachorro");
                x = int.Parse(Console.ReadLine());
                if(x == 0)
                    return val;
                else
                    return val += x;
            }
            public void Status()
            {
                switch (val)
                {
                    case 0:
                        Console.WriteLine($"The {this.nome} is borring");
                        break;
                    case 1:
                        Console.WriteLine($"The {this.nome} wants to play more!!");
                        break;
                    case 2:
                        Console.WriteLine("Try more");
                        break;
                    case 3:
                        Console.WriteLine($"The {this.nome} is happy");
                        break;
                    case 4:
                        Console.WriteLine($"The {this.nome} cant stop to play now");
                        break;
                    case 5:
                        Console.WriteLine($"The {this.nome} is tiring");
                        break;
                    default:
                        Console.WriteLine($"{this.nome} is sleeping...");
                        break;
                }
            }
        }
        class Secon
        {
            static string n, r, c;
            static int a;
            private static void forms()
            { 
                Console.WriteLine("Digite o nome do seu animal: ");
                n = Console.ReadLine();
                Console.WriteLine("Digite a raça: ");
                r = Console.ReadLine();
                Console.WriteLine("Digite a cor: ");
                c = Console.ReadLine();
                Console.WriteLine("Digite a idade dele: ");
                a = int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
            {
                forms();
                var dog = new animal(n, r, c, a);
                Console.Clear();
                Console.WriteLine("Main menu");
                Console.WriteLine("1 - status");
                Console.WriteLine("2 - brincar");
                Console.WriteLine("3 - informações");
                Console.WriteLine("4 - Sair");
                dog.about();
                dog.Play();
                dog.Status();
            }
        }
}
}
