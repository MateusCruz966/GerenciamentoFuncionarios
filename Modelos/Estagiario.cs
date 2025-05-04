using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoFuncionarios.Modelos
{
    // Classe que representa um estagiário, herda de Funcionario
    public class Estagiario : Funcionario
    {
        
        public override decimal CalcularSalario()
        {
            return Salario;
        }
        // Imposto de 0% sobre o Salário Total
        public decimal SalarioLiquido => CalcularSalario();

        // Método para entregar o pagamento do Estagiário
        public override void EntregarPagamento()
        {
            Console.WriteLine(
             $"[ESTAGIÁRIO] {Nome}\n" +
             $"Idade: {Idade}\n" +
             $"Salário Total: {CalcularSalario():C}\n" +
             $"Salário Líquido: {SalarioLiquido:C}\n" +
             $"Forma de Pagamento: {FormaPagamento}\n"
         );
        }



    }
}
