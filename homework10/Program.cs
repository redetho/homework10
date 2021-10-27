using System;
//usar lists
using System.Collections.Generic;

namespace homework10
{
    class Program
    {
        static void Main(string[] args)
        {
            //recebe o numero de empregados/funcionarios
            Console.WriteLine("Digite um numero:");
            int numero = int.Parse(Console.ReadLine());
            
            List<Empregado> todosfunc = new List<Empregado>();
            //cria um ''empregado'' para cada numero entregue, recebe nome, id e salário
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
            //recebe o id do funcionário
            Console.WriteLine("Digite o id de um funcionário:");
            int idFuncionario = int.Parse(Console.ReadLine());
            //usa "Find" para encontrar o id correspondente de um funcionario/empregado
            var funcionario = todosfunc.Find(num => num.Id == idFuncionario);
            //se não for nulo, apresenta a opção de aumento de salário
            if (funcionario != null)
            {
                Console.WriteLine("Digite a porcentagem de aumento do salário:");
                double porcentagem = double.Parse(Console.ReadLine());
                funcionario.AumentarSalario(porcentagem);
            }
            //se for nulo, avisa que o ID nao existe e apresenta os empregados
            else if (funcionario == null)
            {
                Console.WriteLine("Esse ID nao existe.");
            }
            //apresenta, nome, id e salário, pula uma linha para separar os funcionários e auxiliar na leitura.
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
