using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoFuncionarios.Modelos
{
    // Classe que representa um gerente, herda de Funcionario
    public class Gerente : Funcionario
    {
        // Propriedades específicas do Gerente
        public decimal Bonus { get; set; }
        // Método para calcular o salário total do Gerente
        public override decimal CalcularSalario()
        {
            return Salario + Bonus;
        }
        // Imposto de 27,5% sobre o Salário Total
        public override decimal CalcularImpostos()
        {
            return CalcularSalario() * 0.275m;
        }
        // Salário Líquido = Salário Total - Impostos
        public decimal SalarioLiquido => CalcularSalario() - CalcularImpostos();

        // Método para entregar o pagamento do Gerente
        public override void EntregarPagamento()
        {
            Console.WriteLine(
             $"[GERENTE] {Nome}\n" +
             $"Idade: {Idade}\n" +
             $"Salário Total: {CalcularSalario():C}\n" +
             $"Impostos: {CalcularImpostos():C}\n" +
             $"Salário Líquido: {SalarioLiquido:C}\n" +
             $"Forma de Pagamento: {FormaPagamento}\n"
         );
        }
    }
}
