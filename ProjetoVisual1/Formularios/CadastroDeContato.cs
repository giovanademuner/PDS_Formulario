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
    public partial class CadastroDeContato : Form
    {
        private MySqlConnection _conexao;
        public CadastroDeContato()
        {
            InitializeComponent();

            Conexao();
        }

        public void Conexao()
        {
            string conexaoString = "server=localhost;database=app_contato_bd;user=root;password=root;port=3360";

            _conexao = new MySqlConnection(conexaoString);
            _conexao.Open();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            CadastroDeContato cadastroDeContato = new CadastroDeContato();
            



            var nome = tbNome.Text;
            var email = tbEmail.Text;   

            var sql = "INSERT INTO contato (nome_con, email_con) VALUES (@_nome, @_email)";
            var comando = new MySqlCommand(sql, _conexao);

            comando.Parameters.AddWithValue("@_nome", nome);
            comando.Parameters.AddWithValue("@_email", email);
            comando.Parameters.AddWithValue("@_telefone", tbTelefone);
            comando.Parameters.AddWithValue("@sexo", cbSexo);
            comando.Parameters.AddWithValue("@sexo", cbSexo);



            comando.ExecuteNonQuery();

            _conexao.Close();
        }
    }
}
