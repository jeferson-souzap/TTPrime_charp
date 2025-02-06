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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TTPrime_charp
{
    public partial class Form_item_obra : Form
    {
        public Form_item_obra()
        {
            InitializeComponent();

            Carregar_grid_item_obra();
            Carregar_id_projeto();
        }


        #region Metodos Carregar combobox

        private void Limpar_controles()
        {
            combo_id_projeto.Text = string.Empty;
            text_descricao_item.Text = string.Empty;
            text_tipo_item.Text = string.Empty;
            lb_item_descricao.Text = string.Empty;

            text_qtd_item.Text = "0";
            text_largura.Text = "0";
            text_qtd_item.Text = "0";
            text_area.Text = "0";
            text_peso.Text = "0";
            combo_unidade_med.Text = string.Empty;

        }

        private void Carregar_unidade_med()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.string_db;
                string comando_sql = "select cod_unidade from config_unidade_med";

                using (MySqlConnection conexao = new MySqlConnection(conecta_string))
                {
                    MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                    conexao.Open();

                    using (MySqlDataReader myreader = cmd.ExecuteReader())
                    {
                        while (myreader.Read())
                        {
                            combo_unidade_med.Items.Add(myreader["cod_unidade"].ToString());

                        }
                    }

                }


            }
            catch (Exception Erro)
            {

                MessageBox.Show(Erro.Message);
            }
        }

        private void Carregar_id_projeto()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.string_db;
                string comando_sql = "select distinct id_projeto from tb_cad_obra";

                using (MySqlConnection conexao = new MySqlConnection(conecta_string))
                {
                    MySqlCommand cmd = new MySqlCommand(comando_sql, conexao);
                    conexao.Open();

                    using (MySqlDataReader myreader = cmd.ExecuteReader())
                    {
                        while (myreader.Read())
                        {
                            combo_id_projeto.Items.Add(myreader["id_projeto"].ToString());

                        }
                    }

                }


            }
            catch (Exception Erro)
            {

                MessageBox.Show(Erro.Message);
            }

        }

        private void Carregar_grid_item_obra()
        {
            try
            {
                string conecta_string = Properties.Settings.Default.string_db;
                string comando_sql = "select * from tb_lista_itens"; //configurar visualização 

                MySqlConnection connection = new MySqlConnection(conecta_string);
                MySqlDataAdapter myadapter = new MySqlDataAdapter(comando_sql, connection);
                DataTable dt = new DataTable("tb_lista_itens");

                myadapter.Fill(dt);
                DataView dv = dt.DefaultView;

                grid_lista_item_obra.DataSource = dv.ToTable();
                //grid_cadastro_categoria.DataSource = dv.ToTable();

                connection.Close();

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message);

            }
        }


        #endregion


        #region Metodos Salvar / Deletar / Atualizar

        private void Salvar_item_obra()
        {
            string id_projeto = combo_id_projeto.Text.ToLower();
            string descricao_item = text_descricao_item.Text.ToLower();
            string tipo_item = text_tipo_item.Text.ToUpper();
            string item_completo = lb_item_descricao.Text.ToUpper();

            double quantidade = Convert.ToDouble(text_qtd_item.Text);
            int largura = Convert.ToInt32(text_largura.Text);
            int altura = Convert.ToInt32(text_qtd_item.Text);
            double area = Convert.ToDouble(text_area.Text);
            double peso = Convert.ToDouble(text_peso.Text);
            string und_medida = combo_unidade_med.Text;


            try
            {
                string conecta_string = Properties.Settings.Default.string_db;
                MySqlConnection connection = new MySqlConnection(conecta_string);


                string comando_sql;

                comando_sql = "INSERT INTO tb_lista_itens(id_projeto, descricao_item, tipo_item, item_completo, quantidade, L, H, area, peso, und_medida) " +
                         "VALUES(@id_projeto, @descricao_item, @tipo_item, @item_completo, @quantidade, @L, @H, @area, @peso, @und_medida)";



                using (MySqlCommand cmd = new MySqlCommand(comando_sql, connection))
                {
                    cmd.Parameters.AddWithValue("@id_projeto", id_projeto);
                    cmd.Parameters.AddWithValue("@descricao_item", descricao_item);
                    cmd.Parameters.AddWithValue("@tipo_item", tipo_item);
                    cmd.Parameters.AddWithValue("@item_completo", item_completo);
                    cmd.Parameters.AddWithValue("@quantidade", Convert.ToString(quantidade).Replace(',', '.'));
                    cmd.Parameters.AddWithValue("@L", Convert.ToString(largura).Replace(',', '.'));
                    cmd.Parameters.AddWithValue("@H", Convert.ToString(altura).Replace(',', '.'));
                    cmd.Parameters.AddWithValue("@area", Convert.ToString(area).Replace(',', '.'));
                    cmd.Parameters.AddWithValue("@peso", Convert.ToString(peso).Replace(',', '.'));
                    cmd.Parameters.AddWithValue("@und_medida", und_medida);

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

        private void Deletar_item_obra(string id_item_obra)
        {
            try
            {
                string conecta_string = Properties.Settings.Default.string_db;
                using (MySqlConnection connection = new MySqlConnection(conecta_string))

                {

                    string comando_sql = "DELETE FROM tb_lista_itens WHERE id = @id_item_obra";

                    using (MySqlCommand cmd = new MySqlCommand(comando_sql, connection))
                    {
                        // Adiciona o parâmetro para o id da obra a ser deletada
                        cmd.Parameters.AddWithValue("@id_item_obra", Convert.ToInt32(id_item_obra));

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
                MessageBox.Show(Erro.Message + "\r\n Erro ao Deletar o Item");
            }

        }

        private void Atualizar_item_obra(string id_item_obra)
        {
            string id_projeto = combo_id_projeto.Text.ToLower();
            string descricao_item = text_descricao_item.Text.ToLower();
            string tipo_item = text_tipo_item.Text.ToUpper();
            string item_completo = lb_item_descricao.Text.ToUpper();

            double quantidade = Convert.ToDouble(text_qtd_item.Text);
            int largura = Convert.ToInt32(text_largura.Text);
            int altura = Convert.ToInt32(text_qtd_item.Text);
            double area = Convert.ToDouble(text_area.Text);
            double peso = Convert.ToDouble(text_peso.Text);
            string und_medida = combo_unidade_med.Text;

            try
            {
                string conecta_string = Properties.Settings.Default.string_db;
                MySqlConnection connection = new MySqlConnection(conecta_string);


                string comando_sql;

                comando_sql = "UPDATE tb_lista_itens SET " +
                     "id_projeto = @id_projeto, " +
                     "descricao_item = @descricao_item, " +
                     "tipo_item = @tipo_item, " +
                     "item_completo = @item_completo, " +
                     "quantidade = @quantidade, " +
                     "largura = @largura, " +
                     "area = @area, " +
                     "peso = @peso, " +
                     "und_medida = @und_medida " +
                     "WHERE id =" + Convert.ToInt32(id_item_obra) + "";



                using (MySqlCommand cmd = new MySqlCommand(comando_sql, connection))
                {
                    cmd.Parameters.AddWithValue("@id_projeto", id_projeto);
                    cmd.Parameters.AddWithValue("@descricao_item", descricao_item);
                    cmd.Parameters.AddWithValue("@tipo_item", tipo_item);
                    cmd.Parameters.AddWithValue("@item_completo", item_completo);

                    cmd.Parameters.AddWithValue("@quantidade", Convert.ToString(quantidade).Replace(',', '.'));
                    cmd.Parameters.AddWithValue("@largura", Convert.ToString(largura).Replace(',', '.'));
                    cmd.Parameters.AddWithValue("@area", Convert.ToString(area).Replace(',', '.'));
                    cmd.Parameters.AddWithValue("@peso", Convert.ToString(peso).Replace(',', '.'));
                    cmd.Parameters.AddWithValue("@und_medida", und_medida);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();


                    MessageBox.Show("Atualizado com Sucesso!!");
                    Limpar_controles();
                }

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message + "\r\n Erro ao Atualizar o item");
                return;

            }

        }



        #endregion


        #region Area dos botoes
        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_salvar_item_Click(object sender, EventArgs e)
        {
            Salvar_item_obra();

            Carregar_grid_item_obra();


        }


        private void bt_deletar_item_Click(object sender, EventArgs e)
        {

        }

        private void bt_atualizar_item_Click(object sender, EventArgs e)
        {

        }

        #endregion


        private void text_altura_Leave(object sender, EventArgs e)
        {
            double valor_perimetro;

            valor_perimetro = Convert.ToDouble(text_largura.Text) + Convert.ToDouble(text_altura.Text);

            text_perimetro.Text = valor_perimetro.ToString("F2");

        }

        private void text_tipo_item_Leave(object sender, EventArgs e)
        {
            lb_item_descricao.Text = text_descricao_item.Text + " - " + text_tipo_item.Text;
        }
    }
}
