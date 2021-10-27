using System;
using System.Collections.Generic;

namespace homework10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero:");
            int numero = int.Parse(Console.ReadLine());

            List<Empregado> todosfunc = new List<Empregado>();

            for (int i = 0; i < numero; i++)
            { 
                Console.WriteLine("Digite seu nome:");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite seu id:");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite seu salário");
                double salario = double.Parse(Console.ReadLine());

                todosfunc.Add(new Empregado { Id = id, Nome = nome, Salario = salario });
            }

            Console.WriteLine("Digite o id de um funcionário:");
            int idFuncionario = int.Parse(Console.ReadLine());

            var funcionario = todosfunc.Find(num => num.Id == idFuncionario);

            if (funcionario != null)
            {
                Console.WriteLine("Digite a porcentagem de aumento do salário:");
                double porcentagem = double.Parse(Console.ReadLine());
                funcionario.AumentarSalario(porcentagem);
            }
            else if (funcionario == null)
            {
                Console.WriteLine("Esse ID nao existe.");
            }

            Console.WriteLine("Salarios e funcionarios:");
            foreach (var bagulho in todosfunc)
            {
                Console.WriteLine(bagulho.Nome);
                Console.WriteLine(bagulho.Id);
                Console.WriteLine(bagulho.Salario);
                Console.WriteLine();
            }
        }
    }
}
