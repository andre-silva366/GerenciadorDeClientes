namespace GerenciadorDeClientes.Models;

public class RegistroCompraCredito
{   
    public int Id { get; set; }
    public int IdServidor { get; set; }
    public string NomeServidor { get; set; } = string.Empty;
    public int QtdeCredito { get; set; }
    public decimal Valor { get; set; } = 0;
    public DateTime DataCompra { get; set; } = DateTime.Now;

}
