using GerenciamentoFuncionarios.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoFuncionarios.Servicos
{
    // Classe responsável por gerenciar os funcionários.
    public class FuncionarioServico
    {
        // Lista de funcionários cadastrados.
        private readonly List<Funcionario> _funcionarios = new();

        public void CadastrarFuncionario(Funcionario funcionario)
        {
            _funcionarios.Add(funcionario);
           
        }
        // Método para listar todos os funcionários cadastrados.
        public void ListarFuncionarios()
        {
            Console.WriteLine("Lista de Funcionários:");
            Console.WriteLine();
            foreach (var funcionario in _funcionarios)
            {
               
                funcionario.EntregarPagamento();
            }
        }
    }
}
