using System;
using System.Collections.Generic;
using System.Globalization;

namespace GitTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos empregados serão registrados ? ");
            int q = int.Parse(Console.ReadLine());

            List<Empregados> empregados = new List<Empregados>();

            for (int lista = 1; lista <= q; lista++)
            {
                Console.WriteLine($"Empregado #{lista}:");

                Console.Write("Id : ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome : ");
                string nome = Console.ReadLine();

                Console.Write("Salário : ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                empregados.Add(new Empregados(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Informe a ID que receberá acrescimo : ");
            int procurarId = int.Parse(Console.ReadLine());

            Empregados funcionarios = empregados.Find(x => x.Id == procurarId);

            if (funcionarios != null)
            {
                Console.Write("Informe a porcentagem : ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcionarios.EncrementoSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Essa ID não existe ! ");
            }

            Console.WriteLine();
            Console.WriteLine("Lista Atualizadas dos Empregados ");

            foreach (Empregados emp in empregados)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
