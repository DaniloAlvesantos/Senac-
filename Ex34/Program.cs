using System;

namespace Ex34
{
    internal class Program
    {
        public struct CAD_ALUNO 
        {
            public string NOME;
            public int SALA;
            public float MEDIA;
        }
        static void Main(string[] args)
        {
            CAD_ALUNO[] ALUNO = new CAD_ALUNO[8];
            CAD_ALUNO x;
            int i, j, lin;

            for(i = 0; i <= 7; i++)
            {
                Console.Clear();
                Console.WriteLine("Cadastro de Alunos");
                Console.WriteLine();
                Console.WriteLine("Entre o {0}° nome ...: ",i + 1);
                ALUNO[i].NOME = Console.ReadLine();
                Console.WriteLine("Entre a sala ........:");
                ALUNO[i].SALA = int.Parse(Console.ReadLine());
                Console.WriteLine("Entre a media .......:");
                ALUNO[i].MEDIA = float.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            for(i=0; i<= 6; i++)
                for(j=0; j<= 7; j++)
                    if (ALUNO[i].NOME.CompareTo(ALUNO[j].NOME) > 0)
                    {
                        x = ALUNO[i];
                        ALUNO[i] = ALUNO[j];
                        ALUNO[j] = x;
                    }

            Console.Clear();
            Console.WriteLine("Relatorio Geral");
            Console.WriteLine();

            Console.SetCursorPosition(0, 3);
            Console.Write("Aluno");
            Console.SetCursorPosition(41, 3);
            Console.Write("Sala");
            Console.SetCursorPosition(48, 3);
            Console.WriteLine("Media");

            lin = 6;
            for(i = 0; i <= 7; i++)
            {
                Console.SetCursorPosition(0, lin);
                Console.Write(ALUNO[i].NOME.ToUpper());
                Console.SetCursorPosition(41, lin);
                Console.Write("{0,4}",ALUNO[i].SALA);
                Console.SetCursorPosition(48, lin);
                Console.Write("{0,5:0.00}", ALUNO[i].MEDIA);
                lin++;
            }
            Console.SetCursorPosition(0, lin);
            Console.WriteLine();
        }
}
}
