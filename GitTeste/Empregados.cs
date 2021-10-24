using System;
using System.Collections.Generic;
using System.Globalization;

namespace GitTeste
{
    class Empregados
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Empregados(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void EncrementoSalario(double porcentagem)
        {
            Salario += Salario * porcentagem / 100.0;
        }

        public override string ToString()
        {
            return $"{Id}, {Nome}, {Salario.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
