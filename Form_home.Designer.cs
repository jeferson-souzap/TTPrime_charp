namespace TTPrime_charp
{
    partial class Form_home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_inferior = new Panel();
            panel_esquerdo = new Panel();
            bt_configuracao = new Button();
            bt_historico_obra = new Button();
            bt_apontamento = new Button();
            bt_ordem_prod = new Button();
            bt_item_obra = new Button();
            bt_cadastro_obra = new Button();
            pictureBox1 = new PictureBox();
            panel_central = new Panel();
            panel_esquerdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel_inferior
            // 
            panel_inferior.Dock = DockStyle.Bottom;
            panel_inferior.Location = new Point(0, 558);
            panel_inferior.Name = "panel_inferior";
            panel_inferior.Size = new Size(1137, 30);
            panel_inferior.TabIndex = 0;
            // 
            // panel_esquerdo
            // 
            panel_esquerdo.BorderStyle = BorderStyle.Fixed3D;
            panel_esquerdo.Controls.Add(bt_configuracao);
            panel_esquerdo.Controls.Add(bt_historico_obra);
            panel_esquerdo.Controls.Add(bt_apontamento);
            panel_esquerdo.Controls.Add(bt_ordem_prod);
            panel_esquerdo.Controls.Add(bt_item_obra);
            panel_esquerdo.Controls.Add(bt_cadastro_obra);
            panel_esquerdo.Controls.Add(pictureBox1);
            panel_esquerdo.Dock = DockStyle.Left;
            panel_esquerdo.Location = new Point(0, 0);
            panel_esquerdo.Name = "panel_esquerdo";
            panel_esquerdo.Size = new Size(145, 558);
            panel_esquerdo.TabIndex = 1;
            // 
            // bt_configuracao
            // 
            bt_configuracao.Location = new Point(3, 314);
            bt_configuracao.Name = "bt_configuracao";
            bt_configuracao.Size = new Size(131, 23);
            bt_configuracao.TabIndex = 6;
            bt_configuracao.Text = "Configuração";
            bt_configuracao.UseVisualStyleBackColor = true;
            // 
            // bt_historico_obra
            // 
            bt_historico_obra.Location = new Point(3, 285);
            bt_historico_obra.Name = "bt_historico_obra";
            bt_historico_obra.Size = new Size(131, 23);
            bt_historico_obra.TabIndex = 5;
            bt_historico_obra.Text = "Histório Obras";
            bt_historico_obra.UseVisualStyleBackColor = true;
            // 
            // bt_apontamento
            // 
            bt_apontamento.Location = new Point(3, 256);
            bt_apontamento.Name = "bt_apontamento";
            bt_apontamento.Size = new Size(131, 23);
            bt_apontamento.TabIndex = 4;
            bt_apontamento.Text = "Apontamento";
            bt_apontamento.UseVisualStyleBackColor = true;
            bt_apontamento.Click += bt_apontamento_Click;
            // 
            // bt_ordem_prod
            // 
            bt_ordem_prod.Location = new Point(3, 227);
            bt_ordem_prod.Name = "bt_ordem_prod";
            bt_ordem_prod.Size = new Size(131, 23);
            bt_ordem_prod.TabIndex = 3;
            bt_ordem_prod.Text = "Ordem de produção";
            bt_ordem_prod.UseVisualStyleBackColor = true;
            bt_ordem_prod.Click += bt_ordem_prod_Click;
            // 
            // bt_item_obra
            // 
            bt_item_obra.Location = new Point(3, 198);
            bt_item_obra.Name = "bt_item_obra";
            bt_item_obra.Size = new Size(131, 23);
            bt_item_obra.TabIndex = 2;
            bt_item_obra.Text = "Items da obra";
            bt_item_obra.UseVisualStyleBackColor = true;
            bt_item_obra.Click += bt_item_obra_Click;
            // 
            // bt_cadastro_obra
            // 
            bt_cadastro_obra.Location = new Point(3, 169);
            bt_cadastro_obra.Name = "bt_cadastro_obra";
            bt_cadastro_obra.Size = new Size(131, 23);
            bt_cadastro_obra.TabIndex = 1;
            bt_cadastro_obra.Text = "Cadastro de Obra";
            bt_cadastro_obra.UseVisualStyleBackColor = true;
            bt_cadastro_obra.Click += bt_cadastro_obra_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 148);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel_central
            // 
            panel_central.BorderStyle = BorderStyle.Fixed3D;
            panel_central.Dock = DockStyle.Fill;
            panel_central.Location = new Point(145, 0);
            panel_central.Name = "panel_central";
            panel_central.Size = new Size(992, 558);
            panel_central.TabIndex = 2;
            // 
            // Form_home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 588);
            Controls.Add(panel_central);
            Controls.Add(panel_esquerdo);
            Controls.Add(panel_inferior);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form_home";
            Text = "PRIME";
            panel_esquerdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_inferior;
        private Panel panel_esquerdo;
        private Panel panel_central;
        private Button bt_apontamento;
        private Button bt_ordem_prod;
        private Button bt_item_obra;
        private Button bt_cadastro_obra;
        private PictureBox pictureBox1;
        private Button bt_configuracao;
        private Button bt_historico_obra;
    }
}
