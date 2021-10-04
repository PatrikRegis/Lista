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
using System.Drawing.Printing;

namespace Lista_de_convidados
{
    public partial class frmLista : Form
    {

        public frmLista()
        {
            InitializeComponent();
            ConfigurarTooltip();
            ConfigurarTooltip2();
        }

        private MySqlConnectionStringBuilder conexaoBanco() //CONEXAO BD
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "lista";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;
        }

        private void atualizaGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();

                comandoMySql.CommandText = "SELECT * FROM listadeconvidados WHERE confirmadoLista = 1"; // Mostra apenas os confirmados na lista
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dgLista.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgLista.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//NOME
                    row.Cells[2].Value = reader.GetString(2);//EMAIL
                    row.Cells[3].Value = reader.GetString(3);//FONE
                    dgLista.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }

                realizaConexacoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void mostrarnaoConfirmados() //Mostra os inativados no banco de dados
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();

                comandoMySql.CommandText = "SELECT * FROM listadeconvidados WHERE confirmadoLista = 0"; // Mostra apenas os inativos no BD
                MySqlDataReader reader = comandoMySql.ExecuteReader();
                dgLista.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgLista.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//NOME
                    row.Cells[2].Value = reader.GetString(2);//EMAIL
                    row.Cells[3].Value = reader.GetString(3);//FONE
                    dgLista.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }

                realizaConexacoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void mostraTodos() //Mostra todos no banco de dados ativos e inativos
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM listadeconvidados"; //Mostra todos na lista
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dgLista.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgLista.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//NOME
                    row.Cells[2].Value = reader.GetString(2);//EMAIL
                    row.Cells[3].Value = reader.GetString(3);//FONE
                    dgLista.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }

                realizaConexacoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                Console.WriteLine(ex.Message);
            }
        }


        private void frmLista_Load(object sender, EventArgs e) //Atualiza GRID
        {
            atualizaGrid();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) //gdLista
        {
          if(dgLista.Columns[e.ColumnIndex] ==
                dgLista.Columns["edit"])
                { 

                textNome.Text = dgLista.Rows[e.RowIndex].Cells["nomeList"].FormattedValue.ToString();
                textEmail.Text = dgLista.Rows[e.RowIndex].Cells["emailList"].FormattedValue.ToString();
                textFone.Text = dgLista.Rows[e.RowIndex].Cells["foneList"].FormattedValue.ToString();
                textId.Text = dgLista.Rows[e.RowIndex].Cells["idList"].FormattedValue.ToString();

                


            }
        }

        private void butAdd_Click(object sender, EventArgs e) // Botão Adicionar 
        {
           

            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());              
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); 

                comandoMySql.CommandText = "INSERT INTO listadeconvidados (nomeLista,emailLista,foneLista) " +
                    "VALUES('" + textNome.Text + "', '" + textEmail.Text + "','" + textFone.Text + "')";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
                MessageBox.Show("Inserido com sucesso");
                atualizaGrid();
                limparCampos();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void butFechar_Click(object sender, EventArgs e) // Botão sair 
        {
            {
                if (MessageBox.Show("Deseja Sair do programa ?", "Lista de Convidados", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e) //Submenu Sair
        {
            Application.Exit();
        }

        private void butExcluir_Click(object sender, EventArgs e) //Botãoexcluir
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); 

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                
                if (MessageBox.Show("Deseja realmente excluir essa informação ?", "Lista de Convidados", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    comandoMySql.CommandText = "UPDATE listadeconvidados SET confirmadoLista = 0 WHERE idLista = " + textId.Text + ""; //Desativa no DG permanece do BD como Inativo
                    //comandoMySql.CommandText = "DELETE FROM listadeconvidados WHERE idLista = " + textId.Text + ""; //DELETA no Banco de Dados
                }

                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
     
                atualizaGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void textFone_KeyPress(object sender, KeyPressEventArgs e) //Permite apenas números no campus FONE
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {

                e.Handled = true;
            }
        }

        private void butSalvar_Click(object sender, EventArgs e) //Salva alteração no Banco de Dados
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL

                comandoMySql.CommandText = "UPDATE listadeconvidados SET nomeLista = '" + textNome.Text + "', " +
                    "emailLista = '" + textEmail.Text + "', " +
                    "foneLista = " + textFone.Text +
                    " WHERE idLista = " + textId.Text + "";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
                MessageBox.Show("Alteração salva com sucesso"); //Exibo mensagem de aviso
                atualizaGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void limparCampos() //Função Limpar
        {
            textNome.Clear();
            textFone.Clear();
            textEmail.Clear();
            textId.Clear();   
        }

        private void butLimpar_Click(object sender, EventArgs e) //Botão Limpar
        {
            limparCampos();
            atualizaGrid();
        }

        private void frmLista_Load_1(object sender, EventArgs e)
        {
            atualizaGrid();
        }

        private void butLocalizar_Click(object sender, EventArgs e) //botãolocalizar
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();

                if (string.IsNullOrEmpty(textNome.Text))
                {
                    comandoMySql.CommandText = "SELECT * FROM listadeconvidados ORDER BY nomeLista ASC";
                }
                else
                {
                    string sql = "select * from listadeconvidados where nomeLista like'" + textNome.Text + "%'";
                    comandoMySql.CommandText = sql;
                }

                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dgLista.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgLista.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//NOME
                    row.Cells[2].Value = reader.GetString(2);//EMAIL
                    row.Cells[3].Value = reader.GetString(3);//FONE
                    dgLista.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }


                realizaConexacoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                Console.WriteLine(ex.Message);
            }
        }

        private void dgLista_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgLista.Rows[e.RowIndex].Cells["edit"].ToolTipText = "Clique aqui para editar";
        }

        private void butLocalizar2_Click(object sender, EventArgs e)  // Botão Pesquisar
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();

                if (string.IsNullOrEmpty(tbPesquisar.Text))
                {
                    comandoMySql.CommandText = "SELECT * FROM listadeconvidados ORDER BY nomeLista ASC";
                }
                else
                {
                    string sql = "select * from listadeconvidados where nomeLista like'" + tbPesquisar.Text + "%'";
                    comandoMySql.CommandText = sql;
                }

                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dgLista.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgLista.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//NOME
                    row.Cells[2].Value = reader.GetString(2);//EMAIL
                    row.Cells[3].Value = reader.GetString(3);//FONE
                    dgLista.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }


                realizaConexacoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                Console.WriteLine(ex.Message);
            }
            txtPesquisar.Visible = true;
            tbPesquisar.Clear();
        }

        private void tbPesquisar_Click(object sender, EventArgs e)
        {
            txtPesquisar.Visible = false;
        }
        private void ConfigurarTooltip() //toolTip Botão Fechar
        {
            toolTip1.AutoPopDelay = 4000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 200;

            toolTip1.SetToolTip(butFechar, "Clique para Fechar");
        }
        private void ConfigurarTooltip2() //toolTip Botão Pesquisar
        {
            toolTip1.AutoPopDelay = 4000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 200;

            toolTip1.SetToolTip(butLocalizar2, "Clique para pesquisar");
        }

        private void textFone_KeyPress_1(object sender, KeyPressEventArgs e) //Apenas números no TextFone
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {

                e.Handled = true;
            }
        }

        private void mostrarNãoConfirmadosToolStripMenuItem_Click(object sender, EventArgs e) // Botão submenu mostra todos não ativos do banco de dados no datagrid
        {
            mostrarnaoConfirmados();
        }

        private void mostrarConformadosToolStripMenuItem_Click(object sender, EventArgs e) // Botão submenu mostra todos ativos do banco de dados no datagrid
        {
            atualizaGrid();
        }

        private void mostrarTodosToolStripMenuItem_Click(object sender, EventArgs e) // Botão submenu mostra todos ativos e inativos do banco de dados no datagrid
        {
            mostraTodos();
        }
    }
}
