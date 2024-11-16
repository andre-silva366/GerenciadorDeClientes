namespace GerenciadorDeClientes.Models;

public class RegistroPagamentoRevendedor
{
    public int Id { get; set; }
    public int IdRevendedor { get; set; }
    public string NomeRevendedor { get; set; } = string.Empty;
    public int IdServidor { get; set; }
    public string NomeServidor { get; set; } = string.Empty ;
    public int QtdeCreditos { get; set; } = 5;
    public decimal Valor { get; set; }
    public DateTime DataPagamento { get; set; } = DateTime.Now;
}
