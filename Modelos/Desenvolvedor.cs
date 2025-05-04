using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoFuncionarios.Modelos
{
    // Classe que representa um desenvolvedor, herda de Funcionario
    public class Desenvolvedor : Funcionario
    {
        // Propriedades específicas do Desenvolvedor
        public int HorasExtras { get; set; }
        public decimal ValorHoraExtra { get; set; } = 50m;

        // Método para calcular o salário total do Desenvolvedor
        public override decimal CalcularSalario()
        {
            return Salario + (HorasExtras * ValorHoraExtra);
        }

        // Imposto de 10% sobre o Salário Total
        public override decimal CalcularImpostos()
        {
            return CalcularSalario() * 0.10m;
        }

        // Salário Líquido = Salário Total - Impostos
        public decimal SalarioLiquido => CalcularSalario() - CalcularImpostos();

        // Método para entregar o pagamento do Desenvolvedor
        public override void EntregarPagamento()
        {
            Console.WriteLine(
                $"[DESENVOLVEDOR] {Nome}\n" +
                $"Idade: {Idade}\n" +
                $"Salário Total: {CalcularSalario():C} (Horas Extras: {HorasExtras})\n" +
                $"Impostos: {CalcularImpostos():C}\n" +
                $"Salário Líquido: {SalarioLiquido:C}\n" +
                $"Forma de Pagamento: {FormaPagamento}\n"
            );
        }
    }
}
