namespace GerenciadorDeClientes.Models;

public class Plano
{
    public int Id { get; set; }
    public string Descricao { get; set; }
    public decimal Valor { get; set; }
    public int ValidadeEmMeses { get; set; }
    public DateTime DataUltimoPagamento { get; set; }
    public DateTime DataProximoPagamento { get; set; }
    public int IdAplicativo { get; set; }
    public int IdCliente { get; set; }
    public string MacOuEmail { get; set; }
    public string DeviceKeyOuSenha { get; set; }
}
