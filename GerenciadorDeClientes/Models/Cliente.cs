namespace GerenciadorDeClientes.Models;

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
    public string MacOuEmail { get; set; }
    public string DeviceKeyOuSenha { get; set; }
    public DateTime DataUltimoPagamento { get; set; }
    public DateTime DataProximoPagamento { get; set; }

    public int IdAplicativo { get; set; }
    public int IdPlano { get; set; }
    public int IdServidor { get; set; }
}
