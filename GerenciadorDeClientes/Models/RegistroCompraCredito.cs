namespace GerenciadorDeClientes.Models;

public class RegistroCompraCredito
{   
    public int Id { get; set; }
    public int IdServidor { get; set; }
    public int QtdeCredito { get; set; }
    public decimal Valor { get; set; }
    public DateTime DataCompra { get; set; } = DateTime.Now;

}
