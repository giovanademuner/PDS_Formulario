using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ProjetoVisual1.Formularios
{
    public partial class ListarCadastro : Form
    {
        private MySqlConnection _conexao;
        public ListarCadastro()
        {
            InitializeComponent();

            Conexao();
            Listar();
        }

        public MySqlConnection conexao { get; private set; }

        public void Conexao()
        {
            string conexaoString = "server=localhost;database=app_contato_bd;user=root;password=root;port=3360";

            _conexao = new MySqlConnection(conexaoString);
            _conexao.Open();
        }

       public void Listar()
       {
            string sql = "SELECT * FROM contato";
            var comando = new MySqlCommand(sql, _conexao);
            var adaptador = new MySqlDataAdapter(comando);
            DataTable tabela = new DataTable();

            adaptador.Fill(tabela);
            dgvContato.DataSource = tabela; 

        }
    }
}
