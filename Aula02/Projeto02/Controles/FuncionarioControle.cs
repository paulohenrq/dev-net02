using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entidades;
using System.IO;

namespace Projeto02.Controles
{
    public class FuncionarioControle
    {
        public void ExportarParaTxt (Funcionario funcionario)
        {
            //Abrindo o arquivo txt
            StreamWriter sw = new StreamWriter("c:\\temp\\funcionarios.txt", true);

            //Escrevendo o conteúdo txt
            sw.WriteLine("Código................:" + funcionario.IdFuncionario);
            sw.WriteLine("Nome................:" + funcionario.Nome);
            sw.WriteLine("Salário................:" + funcionario.Salario);
            sw.WriteLine("Contratação................:" + funcionario.TipoContratacao);
            sw.WriteLine("----------------------------------");

            //Fechando o arquivo txt
            sw.Close();
        }

        public void ExportarParaCsv (Funcionario funcionario)
        {
            StreamWriter sw = new StreamWriter("c:\\temp\\funcionarios.csv", true);

            string dados = $"{funcionario.IdFuncionario};{funcionario.Nome};{funcionario};" +
                            $"{funcionario.Salario};{funcionario.TipoContratacao}";

            sw.WriteLine(dados);
            sw.Close();
        }

        public void ExportarParaXml (Funcionario funcionario)
        {
            StreamWriter sw = new StreamWriter ("c:\\temp\\funcionario.xml");
            sw.WriteLine("<? xml version = '1.0' encoding = 'ISO-8859-1' ?>");
            sw.WriteLine("<FUNCIONARIO>");
            sw.WriteLine($"<CODIGO>{funcionario.IdFuncionario}</CODIGO>");
            sw.WriteLine($"<NOME>{funcionario.IdFuncionario}</NOME>");
            sw.WriteLine($"<SALARIO>{funcionario.Salario}</SALARIO>");
            sw.WriteLine($"<TIPO>{funcionario.TipoContratacao}</TIPO>");
            sw.WriteLine("</FUNCIONARIO>");

            sw.Close();
        }
    }
}
