using GerenciadorDeClientes.Repositories;

namespace GerenciadorDeClientes
{
    public partial class FormTelaPrincipal : Form
    {
        public FormTelaPrincipal()
        {
            InitializeComponent();
                
        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            var tabela = comboBoxSelectTable.SelectedItem?.ToString();

            if(tabela != "Selecione")
            {
                if (tabela == "Cliente")
                {
                    dataGridViewClientes.Visible = true;
                    ClienteRepository cliente = new ClienteRepository();
                    var clientes = cliente.GetAll().ToList();
                            
                    dataGridViewClientes.DataSource = clientes;
                }
            }
            else
            {
                MessageBox.Show("Selecione alguma tabela!");
            }
                       

                    
            
        }
    }
}
