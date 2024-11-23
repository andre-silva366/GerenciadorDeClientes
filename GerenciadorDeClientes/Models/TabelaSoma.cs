namespace GerenciadorDeClientes.Models;

public class TabelaSoma
{
    public int Id { get; set; }
    public int Ano { get; set; }
    public int Mes { get; set; }
    public decimal TotalCompraCredito { get; set; }
    public decimal TotalPagamentoCliente { get; set; }
    public decimal TotalPagamentoRevendedor { get; set; }
    public decimal Lucro { get; set; }
}
