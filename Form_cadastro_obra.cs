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
                            //combo_empresa.Items.Add(myreader["nome_empresa"].ToString());
                        }
                    }

                }


            }
            catch (Exception Erro)
            {

                MessageBox.Show(Erro.Message);
            }


        }

        #endregion Controles


        #region Metodos Salvar / Cancelar / Deletar

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



        private void Salvar_obra_db()
        {

            if(Verificar_campos_vazios(text_nome_obra, text_cliente_obra, text_id_obra, text_item_obra))
            {
                MessageBox.Show("Preencher todos os campos!");
                return;
            }


            DateTime dt_entrada = date_cadastro_obra.Value.Date;
            string status = combo_status_obra.Text;
            string nome_obra = text_nome_obra.Text;
            string nome_cliente = text_cliente_obra.Text;
            string id_obra = text_id_obra.Text;
            string item_obra = text_item_obra.Text
            double qtd_itens = Convert.ToDouble(text_qtd_item.Text);
            string id_projeto = lb_id_projeto.Text;

            


            try
            {
                string conecta_string = Properties.Settings.Default.string_db;
                MySqlConnection connection = new MySqlConnection(conecta_string);
                connection.Open();

                string comando_sql;

                comando_sql = "INSERT INTO sua_tabela(status, dt_entrada, nome_obra, nome_cliente, id_obra, item_obra, qtd_itens, id_projeto) " +
                     "VALUES('" + status + "','" + dt_entrada.ToString("yyyy-MM-dd") + "','" + nome_obra + "','" + nome_cliente + "','" + id_obra + "','" + item_obra + "','" + Convert.ToString(qtd_itens).Replace(',', '.') + "','" + id_projeto + "')";

                MySqlCommand cmd = new MySqlCommand(comando_sql, connection);
                cmd.ExecuteNonQuery();
                connection.Close();


                MessageBox.Show("Salvo com Sucesso!!");
                Carregar_grid_obras();


            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message + "\r\n Erro ao salvar o apontamento");
                
            }



        }




        #region Area dos botões

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_salvar_obra_Click(object sender, EventArgs e)
        {

        }

        private void bt_deletar_obra_Click(object sender, EventArgs e)
        {

        }

        private void bt_cancelar_obra_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
