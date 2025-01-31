namespace TTPrime_charp
{
    public partial class Form_home : Form
    {
        public Form_home()
        {
            InitializeComponent();
        }

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
    }
}
