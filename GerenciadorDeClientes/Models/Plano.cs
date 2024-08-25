namespace GerenciadorDeClientes.Models;

public class Plano
{
    public int Id { get; set; }
    public string Descricao { get; set; }
    public decimal Valor { get; set; }
    public int ValidadeEmMeses { get; set; }
    public DateTimeOffset DataProximoPagamento { get; set; }
    public string MacOuEmail { get; set; }
    public string DeviceKeyOuSenha { get; set; }

    public int IdAplicativo { get; set; }
    public int IdServidor { get; set; }
    public int IdCliente { get; set; }

    public Aplicativo Aplicativo { get; set; }
    public Servidor Servidor { get; set; }
    public Cliente Cliente { get; set; }
}
