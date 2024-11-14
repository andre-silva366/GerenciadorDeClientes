namespace GerenciadorDeClientes.Models;

public class RegistroPagamentoRevendedor
{
    public int Id { get; set; }
    public int IdRevendedor { get; set; }
    public int IdServidor { get; set; }
    public int QtdeCreditos { get; set; } = 5;
    public decimal Valor { get; set; }
    public DateTime DataPagamento { get; set; } = DateTime.Now;
}
