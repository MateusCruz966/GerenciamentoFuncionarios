using GerenciamentoFuncionarios.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoFuncionarios.Modelos
{
    // Classe base Funcionario
    public abstract class Funcionario 
    {
        // Propriedades comuns a todos os funcionários
        public required string Nome { get; set; }
        public int Idade { get; set; }
        public decimal Salario { get; set; }
        public MetodoPagamento FormaPagamento { get; set; }
        public MetodoEntregaPagamento EntregaPagamento { get; set; }

     
        public abstract decimal CalcularSalario();

        public virtual decimal CalcularImpostos(){
            return Salario * 0.10m;
        }
        

        public virtual void EntregarPagamento(){
            Console.WriteLine($"pagamento de {Nome} entregue via {FormaPagamento}({EntregaPagamento})");
        }

        
    }
}
