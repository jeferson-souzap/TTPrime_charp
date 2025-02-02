using System.Configuration;
using System;
using MySqlConnector;

namespace TTPrime_charp
{
    public partial class Form_home : Form
    {
        public Form_home()
        {
            InitializeComponent();
            Testar_banco_dados();
        }

        #region Area de funções / metodos

        private void Testar_banco_dados()
        {

            try
            {
                
                string stringdb = Properties.Settings.Default.string_db;

                using (MySqlConnection conexao = new MySqlConnection(stringdb))
                {
                    conexao.Open();
                    lb_status_banco.Text =("Conexão bem-sucedida!");
                }
            }
            catch (Exception ex)
            {
                
                lb_status_banco.Text =($"Erro ao conectar: {ex.Message}");
            }
        }
            
        



        #endregion


        #region Metodos da janela
        private void abrir_janelas(object formularios)
        {
            if (this.panel_central.Controls.Count > 0)
                this.panel_central.Controls.RemoveAt(0);

            Form janela = formularios as Form;
            janela.TopLevel = false;
            janela.Dock = DockStyle.Fill;
            this.panel_central.Controls.Add(janela);
            this.panel_central.Tag = janela;
            janela.Show();
        }

        #endregion


        private void bt_cadastro_obra_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_cadastro_obra());
        }

        private void bt_item_obra_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_item_obra());
        }

        private void bt_ordem_prod_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_ordem_prod());
        }

        private void bt_apontamento_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_apontamento());
        }

        private void bt_historico_obra_Click(object sender, EventArgs e)
        {
            abrir_janelas(new Form_historico_obra());
        }
    }
}
