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
            dtpNascimento.Format = DateTimePickerFormat.Custom;
            dtpNascimento.CustomFormat = "yyyy-MM-dd";

            var nome = tbNome.Text;
            var email = tbEmail.Text;
            var telefone = tbTelefone.Text;
            var sexo = cbSexo.Text;
            var dataNascimento = dtpNascimento.Text;
            

            CadastroDeContato cadastroDeContato = new CadastroDeContato();
            try
            {

                if (nome != "" && email != "" && telefone != "" && sexo != "" && dataNascimento != "")
                {

                    var sql = "INSERT INTO contato (nome_con, email_con, telefone_con, sexo_con, data_nasc_con) VALUES (@_nome, @_email, @_telefone, @_sexo, @_dataNascimento)";
                    var comando = new MySqlCommand(sql, _conexao);

                    comando.Parameters.AddWithValue("@_nome", nome);
                    comando.Parameters.AddWithValue("@_email", email);
                    comando.Parameters.AddWithValue("@_telefone", telefone);
                    comando.Parameters.AddWithValue("@_sexo", sexo);
                    comando.Parameters.AddWithValue("@_dataNascimento", dataNascimento);


                    comando.ExecuteNonQuery();

                    MessageBox.Show("Os dados foram cadastrados com sucesso");

                }
                else
                {
                    MessageBox.Show("É obrigatório preencher todos os campos");
                }
            }
            catch (Exception ex) {
                // MessageBox.Show(ex.Message);
                MessageBox.Show("Ocorreram erros ao salvar informações, contate a equipe de suporte do sistema. (CAD 10)");
            }
        }



    }
}
