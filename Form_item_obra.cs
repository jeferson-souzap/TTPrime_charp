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

namespace TTPrime_charp
{
    public partial class Form_item_obra : Form
    {
        public Form_item_obra()
        {
            InitializeComponent();

            Carregar_id_projeto();
        }


        #region Metodos Carregar combobox

        private void Limpar_campos()
        {

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




        #endregion


        #region Metodos Salvar / Deletar / Atualizar

        private void Salvar_item_obra()
        {

        }

        private void Deletar_item_obra(string id_item_obra)
        {
            return;
        }

        private void Atualizar_item_obra(string id_item_obra)
        {
            return;
        }







        #endregion


        #region Area dos botoes
        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void text_altura_Leave(object sender, EventArgs e)
        {
            double valor_perimetro;

            valor_perimetro = Convert.ToDouble(text_largura.Text) + Convert.ToDouble(text_altura.Text);

            text_perimetro.Text = valor_perimetro.ToString("F2");

        }
    }
}
