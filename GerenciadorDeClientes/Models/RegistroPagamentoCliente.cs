namespace GerenciadorDeClientes.Models;

public class RegistroPagamentoCliente
{
    public int Id { get; set; }
    public int IdCliente { get; set; }
    public int IdAplicativo { get; set; }
    public int IdPlano { get; set; }
    public int QtdeTelas { get; set; } = 1;
    public decimal Valor { get; set; }
    public int QtdeMeses { get; set; } = 1;
    public DateTime DataPagamento { get; set; } = DateTime.Now;
    public DateTime DataProximoPagamento { get; set; }
    public RegistroPagamentoCliente()
    {
        DataProximoPagamento =  DataPagamento.AddMonths(QtdeMeses);
    }
}
