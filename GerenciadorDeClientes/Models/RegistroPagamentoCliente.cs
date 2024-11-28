using System.ComponentModel;

namespace GerenciadorDeClientes.Models;

public class RegistroPagamentoCliente
{
    public int Id { get; set; }
    [DisplayName]
    public int IdCliente { get; set; }
    public string NomeCliente { get; set; }
    public int IdAplicativo { get; set; }
    public string NomeAplicativo { get; set; }
    public int IdPlano { get; set; }
    public string DescricaoPlano { get; set; }
    public int IdServidor { get; set; }
    public string NomeServidor { get; set; }
    public int QtdeTelas { get; set; }
    public decimal? Valor { get; set; } 
    public int QtdeMeses { get; set; } 
    public DateTime DataPagamento { get; set; } 
    public DateTime DataProximoPagamento { get; set; }
    
}
