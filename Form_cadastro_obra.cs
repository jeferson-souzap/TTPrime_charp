using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TTPrime_charp
{
    public partial class Form_cadastro_obra : Form
    {
        public Form_cadastro_obra()
        {
            InitializeComponent();

            //Controles
            Carregar_grid_obras();
            Carregar_status_obra();

            combo_status_obra.Text = "Orçamento";

        }


        #region Carregar controles

        private void Carregar_grid_obras()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.string_db;
                string comando_sql = "select * from tb_cad_obra";

                MySqlConnection connection = new MySqlConnection(conecta_string);
                MySqlDataAdapter myadapter = new MySqlDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("tb_cad_obra");

                myadapter.Fill(dt);
                DataView dv = dt.DefaultView;

                grid_lista_obras.DataSource = dv.ToTable();
                //grid_cadastro_categoria.DataSource = dv.ToTable();

                connection.Close();

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);

            }

        }

        private void Carregar_status_obra()
        {

            try
            {
                string conecta_string = Properties.Settings.Default.string_db;
                string comando_sql = "select status_obra from config_status_obra";

                using (MySqlConnection conexao = new MySqlConnection(conecta_string))
                {
                    MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                    conexao.Open();

                    using (MySqlDataReader myreader = cmd.ExecuteReader())
                    {
                        while (myreader.Read())
                        {
                            combo_status_obra.Items.Add(myreader["status_obra"].ToString());
                            
                        }
                    }

                }


            }
            catch (Exception Erro)
            {

                MessageBox.Show(Erro.Message);
            }


        }

        #endregion


        #region Metodos Salvar / Cancelar / Deletar / Carregar


        private void Limpar_controles()
        {
            date_cadastro_obra.Value = DateTime.Now;
            combo_status_obra.Text = "Orçamento";
            text_nome_obra.Text = string.Empty;
            text_cliente_obra.Text = string.Empty;
            text_id_obra.Text = string.Empty;
            text_item_obra.Text = string.Empty;
            text_qtd_item.Text = "0";
            lb_id_projeto.Text = string.Empty;
        }

        private bool Verificar_campos_vazios(params System.Windows.Forms.TextBox[] textBoxes)
        {
            foreach (System.Windows.Forms.TextBox tb in textBoxes)
            {
                if (string.IsNullOrEmpty(tb.Text))
                {
                    return true;
                }
            }

            return false;

        }

        private void Carregar_campos_obra(string id_obra_db)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.string_db;
                string comando_sql = "select * from tb_cad_obra where id =" + Convert.ToInt32(id_obra_db) + "";


                MySqlConnection conexao = new MySqlConnection(conecta_string);
                MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                MySqlDataReader myreader;
                conexao.Open();

                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {

                    date_cadastro_obra.Value = Convert.ToDateTime(myreader["dt_entrada"]);
                    combo_status_obra.Text = myreader["status"].ToString();
                    text_nome_obra.Text = myreader["nome_obra"].ToString();
                    text_cliente_obra.Text = myreader["nome_cliente"].ToString();
                    text_id_obra.Text = myreader["id_obra"].ToString();
                    text_item_obra.Text = myreader["item_obra"].ToString();
                    text_qtd_item.Text = myreader["qtd_itens"].ToString();
                    lb_id_projeto.Text = myreader["id_projeto"].ToString();

                }

                conexao.Close();


            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);
                
            }

        }

        private void Salvar_obra_db()
        {

            DateTime dt_entrada = date_cadastro_obra.Value.Date;
            string status = combo_status_obra.Text.ToUpper();
            string nome_obra = text_nome_obra.Text.ToUpper();
            string nome_cliente = text_cliente_obra.Text.ToUpper();
            string id_obra = text_id_obra.Text.ToUpper();
            string item_obra = text_item_obra.Text.ToUpper();
            double qtd_itens = Convert.ToDouble(text_qtd_item.Text);
            string id_projeto = lb_id_projeto.Text.ToUpper();

            try
            {
                string conecta_string = Properties.Settings.Default.string_db;
                MySqlConnection connection = new MySqlConnection(conecta_string);


                string comando_sql;

                comando_sql = "INSERT INTO tb_cad_obra(status, dt_entrada, nome_obra, nome_cliente, id_obra, item_obra, qtd_itens, id_projeto) " +
                         "VALUES(@status, @dt_entrada, @nome_obra, @nome_cliente, @id_obra, @item_obra, @qtd_itens, @id_projeto)";



                using (MySqlCommand cmd = new MySqlCommand(comando_sql, connection))
                {
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@dt_entrada", dt_entrada.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@nome_obra", nome_obra);
                    cmd.Parameters.AddWithValue("@nome_cliente", nome_cliente);
                    cmd.Parameters.AddWithValue("@id_obra", id_obra);
                    cmd.Parameters.AddWithValue("@item_obra", item_obra);
                    cmd.Parameters.AddWithValue("@qtd_itens", Convert.ToString(qtd_itens).Replace(',', '.'));
                    cmd.Parameters.AddWithValue("@id_projeto", id_projeto);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();


                    MessageBox.Show("Salvo com Sucesso!!");
                    Limpar_controles();
                }

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message + "\r\n Erro ao salvar o apontamento");
                return;

            }
        }

        private void Atualizar_obra(string id_obra_db)
        {
            DateTime dt_entrada = date_cadastro_obra.Value.Date;
            string status = combo_status_obra.Text.ToUpper();
            string nome_obra = text_nome_obra.Text.ToUpper();
            string nome_cliente = text_cliente_obra.Text.ToUpper();
            string id_obra = text_id_obra.Text.ToUpper();
            string item_obra = text_item_obra.Text.ToUpper();
            double qtd_itens = Convert.ToDouble(text_qtd_item.Text);
            string id_projeto = lb_id_projeto.Text.ToUpper();

            try
            {
                string conecta_string = Properties.Settings.Default.string_db;
                MySqlConnection connection = new MySqlConnection(conecta_string);


                string comando_sql;

                comando_sql = "UPDATE tb_cad_obra SET " +
                     "status = @status, " +
                     "dt_entrada = @dt_entrada, " +
                     "nome_obra = @nome_obra, " +
                     "nome_cliente = @nome_cliente, " +
                     "id_obra = @id_obra, " +
                     "item_obra = @item_obra, " +
                     "qtd_itens = @qtd_itens, " +
                     "id_projeto = @id_projeto " +
                     "WHERE id =" + Convert.ToInt32(id_obra_db) + "";



                using (MySqlCommand cmd = new MySqlCommand(comando_sql, connection))
                {
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@dt_entrada", dt_entrada.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@nome_obra", nome_obra);
                    cmd.Parameters.AddWithValue("@nome_cliente", nome_cliente);
                    cmd.Parameters.AddWithValue("@id_obra", id_obra);
                    cmd.Parameters.AddWithValue("@item_obra", item_obra);
                    cmd.Parameters.AddWithValue("@qtd_itens", Convert.ToString(qtd_itens).Replace(',', '.'));
                    cmd.Parameters.AddWithValue("@id_projeto", id_projeto);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();


                    MessageBox.Show("Atualizado com Sucesso!!");
                    Limpar_controles();
                }

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message + "\r\n Erro ao Atualizar o apontamento");
                return;

            }

        }

        private void Deletar_obra(string id_obra_db)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.string_db;
                using (MySqlConnection connection = new MySqlConnection(conecta_string))

                {
                    
                    string comando_sql = "DELETE FROM tb_cad_obra WHERE id = @id_obra_db";

                    using (MySqlCommand cmd = new MySqlCommand(comando_sql, connection))
                    {
                        // Adiciona o parâmetro para o id da obra a ser deletada
                        cmd.Parameters.AddWithValue("@id_obra_db", Convert.ToInt32(id_obra_db));

                        connection.Open();
                        int linhasAfetadas = cmd.ExecuteNonQuery(); // Executa o comando

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Registro deletado com sucesso!");
                            
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro encontrado para deletar.");
                        }
                    }
                }

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message + "\r\n Erro ao Deletar o apontamento");
            }
        }

        #endregion





        #region Area dos botões

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_salvar_obra_Click(object sender, EventArgs e)
        {
            if (Verificar_campos_vazios(text_nome_obra, text_cliente_obra, text_id_obra, text_item_obra, text_qtd_item))
            {
                MessageBox.Show("Preencher todos os campos!");
                return;
            }

            Salvar_obra_db();
            Carregar_grid_obras();

        }

        private void bt_deletar_obra_Click(object sender, EventArgs e)
        {
            Deletar_obra(lb_id_banco.Text);
            Carregar_grid_obras();
            lb_id_banco.Text = "0";
        }

        private void bt_cancelar_obra_Click(object sender, EventArgs e)
        {
            // Botao de atualizar
            
            string mensagem = "Você deseja continuar?";
            string titulo = "Confirmação";
            DialogResult resultado = MessageBox.Show(mensagem, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                
                Atualizar_obra(lb_id_banco.Text);
                Carregar_grid_obras();
            }
            else
            {
                
                return;
            }

        }



        #endregion





        private void text_item_obra_Leave(object sender, EventArgs e)
        {
            lb_id_projeto.Text = "OBR - " + text_nome_obra.Text + " - " +text_item_obra.Text;
        }

        private void grid_lista_obras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id_banco_obra = grid_lista_obras.CurrentRow.Cells[0].Value.ToString();
            lb_id_banco.Text = id_banco_obra.ToString();
            Carregar_campos_obra(id_banco_obra);
            

        }
    }
}
