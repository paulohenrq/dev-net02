using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entidades;
using Projeto02.Controles;

namespace Projeto02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("\nCADASTRO DO FUNCIONÁRIO: \n");

            Console.WriteLine("Código Funcionário:....:");
            funcionario.IdFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome do Funcionário:....:");
            funcionario.Nome = Console.ReadLine();

            Console.WriteLine("Salário do funcionário:....:");
            funcionario.Salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Tipo de contratação");
            Console.WriteLine("\t (1) - Estagiário");
            Console.WriteLine("\t (2) - CLT");
            Console.WriteLine("\t (3) - Terceirizado");
            Console.WriteLine("Informe o código desejado...:");
            funcionario.TipoContratacao = (TipoContratacao) int.Parse(Console.ReadLine());
            /*
            Console.WriteLine("\nDADOS DO FUNCIONÀRIO\n");
            Console.WriteLine("Código do funcionário.......:" + funcionario.IdFuncionario);
            Console.WriteLine("Nome.......:" + funcionario.Nome);
            Console.WriteLine("Salário.......:" + funcionario.Salario);
            Console.WriteLine("Tipo de contratação.......:" + funcionario.TipoContratacao);
            */

            FuncionarioControle funcionarioControle = new FuncionarioControle();
            funcionarioControle.ExportarParaTxt(funcionario);
            funcionarioControle.ExportarParaCsv(funcionario);
            funcionarioControle.ExportarParaXml(funcionario);

            Console.WriteLine("Gravado com sucesso!");

            Console.ReadKey();
        }
    }
}
