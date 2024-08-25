namespace GerenciadorDeClientes.Models;

public class Revendedor
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
    public DateTimeOffset DataUltimaCompra { get; set; }
    public int Quantidade { get; set; }
    public decimal Valor { get; set; }

    public int IdServidor { get; set; }

    public Servidor Servidor { get; set; }
}
