using GerenciamentoFuncionarios.Enums;
using GerenciamentoFuncionarios.Modelos;
using GerenciamentoFuncionarios.Servicos;
namespace GerenciamentoFuncionarios
{
    internal class Program
    {
        /// Método principal da aplicação
        static void Main(string[] args)
        {
            // Criação de instâncias de funcionários
            var funcionarioServico = new FuncionarioServico();

            funcionarioServico.CadastrarFuncionario(new Gerente
            {
                Nome = "José Almeida Cruz",
                Idade = 45,
                Salario = 14354.59m,
                Bonus = 1872m,
                FormaPagamento = MetodoPagamento.DepositoBancario,
                EntregaPagamento = MetodoEntregaPagamento.Automatico
            });
            funcionarioServico.CadastrarFuncionario(new Desenvolvedor
            {
                Nome = "Marcos José Jorge",
                Idade = 30,
                Salario = 8755.79m,
                HorasExtras = 3,
                FormaPagamento = MetodoPagamento.Pix,
                EntregaPagamento = MetodoEntregaPagamento.Manual
            });
            funcionarioServico.CadastrarFuncionario(new Desenvolvedor
            {
                Nome = "Aurélio Roberto Lima Cruz",
                Idade = 28,
                Salario = 6559.27m,
                HorasExtras = 5,
                FormaPagamento = MetodoPagamento.Pix,
                EntregaPagamento = MetodoEntregaPagamento.Manual
            });
            funcionarioServico.CadastrarFuncionario(new Estagiario
            {
                Nome = "Gabriel Oliveira Mendes",
                Idade = 22,
                Salario = 1440.00m,
                FormaPagamento = MetodoPagamento.Dinheiro,
                EntregaPagamento = MetodoEntregaPagamento.Manual
            });
            


            //Consulta
            funcionarioServico.ListarFuncionarios();
        }
    }
}
