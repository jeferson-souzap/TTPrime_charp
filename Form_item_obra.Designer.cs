namespace TTPrime_charp
{
    partial class Form_item_obra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox3 = new GroupBox();
            bt_fechar = new Button();
            bt_atualizar_item = new Button();
            bt_deletar_item = new Button();
            bt_salvar_item = new Button();
            groupBox1 = new GroupBox();
            text_tipo_item = new TextBox();
            label5 = new Label();
            lb_item_descricao = new Label();
            label3 = new Label();
            text_descricao_item = new TextBox();
            label2 = new Label();
            combo_id_projeto = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            grid_lista_item_obra = new DataGridView();
            groupBox4 = new GroupBox();
            text_perimetro = new TextBox();
            label12 = new Label();
            text_peso = new TextBox();
            label11 = new Label();
            text_altura = new TextBox();
            label10 = new Label();
            text_area = new TextBox();
            label9 = new Label();
            text_largura = new TextBox();
            label8 = new Label();
            combo_unidade_med = new ComboBox();
            label7 = new Label();
            text_qtd_item = new TextBox();
            label6 = new Label();
            lb_id_item_obra = new Label();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_lista_item_obra).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(bt_fechar);
            groupBox3.Controls.Add(bt_atualizar_item);
            groupBox3.Controls.Add(bt_deletar_item);
            groupBox3.Controls.Add(bt_salvar_item);
            groupBox3.Dock = DockStyle.Bottom;
            groupBox3.Location = new Point(0, 452);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(954, 44);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Linha de Botões";
            // 
            // bt_fechar
            // 
            bt_fechar.Location = new Point(864, 15);
            bt_fechar.Name = "bt_fechar";
            bt_fechar.Size = new Size(75, 23);
            bt_fechar.TabIndex = 17;
            bt_fechar.Text = "Fechar";
            bt_fechar.UseVisualStyleBackColor = true;
            bt_fechar.Click += bt_fechar_Click;
            // 
            // bt_atualizar_item
            // 
            bt_atualizar_item.Location = new Point(194, 15);
            bt_atualizar_item.Name = "bt_atualizar_item";
            bt_atualizar_item.Size = new Size(75, 23);
            bt_atualizar_item.TabIndex = 16;
            bt_atualizar_item.Text = "Atualizar";
            bt_atualizar_item.UseVisualStyleBackColor = true;
            bt_atualizar_item.Click += bt_atualizar_item_Click;
            // 
            // bt_deletar_item
            // 
            bt_deletar_item.Location = new Point(103, 15);
            bt_deletar_item.Name = "bt_deletar_item";
            bt_deletar_item.Size = new Size(75, 23);
            bt_deletar_item.TabIndex = 2;
            bt_deletar_item.Text = "Deletar";
            bt_deletar_item.UseVisualStyleBackColor = true;
            bt_deletar_item.Click += bt_deletar_item_Click;
            // 
            // bt_salvar_item
            // 
            bt_salvar_item.Location = new Point(16, 15);
            bt_salvar_item.Name = "bt_salvar_item";
            bt_salvar_item.Size = new Size(75, 23);
            bt_salvar_item.TabIndex = 15;
            bt_salvar_item.Text = "Salvar";
            bt_salvar_item.UseVisualStyleBackColor = true;
            bt_salvar_item.Click += bt_salvar_item_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(text_tipo_item);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lb_item_descricao);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(text_descricao_item);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(combo_id_projeto);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(445, 147);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro";
            // 
            // text_tipo_item
            // 
            text_tipo_item.Location = new Point(102, 75);
            text_tipo_item.Name = "text_tipo_item";
            text_tipo_item.Size = new Size(311, 23);
            text_tipo_item.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 78);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 6;
            label5.Text = "Tipo do Item";
            // 
            // lb_item_descricao
            // 
            lb_item_descricao.AutoSize = true;
            lb_item_descricao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_item_descricao.Location = new Point(102, 109);
            lb_item_descricao.Name = "lb_item_descricao";
            lb_item_descricao.Size = new Size(100, 15);
            lb_item_descricao.TabIndex = 5;
            lb_item_descricao.Text = "Item + descricao";
            lb_item_descricao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 109);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Tipo Item";
            // 
            // text_descricao_item
            // 
            text_descricao_item.Location = new Point(102, 46);
            text_descricao_item.Name = "text_descricao_item";
            text_descricao_item.Size = new Size(311, 23);
            text_descricao_item.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 49);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 2;
            label2.Text = "Descrição Item:";
            // 
            // combo_id_projeto
            // 
            combo_id_projeto.AutoCompleteMode = AutoCompleteMode.Suggest;
            combo_id_projeto.FormattingEnabled = true;
            combo_id_projeto.Location = new Point(102, 16);
            combo_id_projeto.Name = "combo_id_projeto";
            combo_id_projeto.Size = new Size(311, 23);
            combo_id_projeto.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 19);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "ID - Projeto";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(grid_lista_item_obra);
            groupBox2.Location = new Point(12, 165);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(930, 281);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lista de materias";
            // 
            // grid_lista_item_obra
            // 
            grid_lista_item_obra.BackgroundColor = SystemColors.ControlLight;
            grid_lista_item_obra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_lista_item_obra.Dock = DockStyle.Fill;
            grid_lista_item_obra.Location = new Point(3, 19);
            grid_lista_item_obra.Name = "grid_lista_item_obra";
            grid_lista_item_obra.Size = new Size(924, 259);
            grid_lista_item_obra.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lb_id_item_obra);
            groupBox4.Controls.Add(text_perimetro);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(text_peso);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(text_altura);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(text_area);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(text_largura);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(combo_unidade_med);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(text_qtd_item);
            groupBox4.Controls.Add(label6);
            groupBox4.Location = new Point(463, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(476, 147);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Valores";
            // 
            // text_perimetro
            // 
            text_perimetro.Location = new Point(111, 106);
            text_perimetro.Name = "text_perimetro";
            text_perimetro.Size = new Size(98, 23);
            text_perimetro.TabIndex = 19;
            text_perimetro.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 109);
            label12.Name = "label12";
            label12.Size = new Size(59, 15);
            label12.TabIndex = 18;
            label12.Text = "Perimetro";
            // 
            // text_peso
            // 
            text_peso.Location = new Point(293, 78);
            text_peso.Name = "text_peso";
            text_peso.Size = new Size(98, 23);
            text_peso.TabIndex = 17;
            text_peso.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(215, 81);
            label11.Name = "label11";
            label11.Size = new Size(56, 15);
            label11.TabIndex = 16;
            label11.Text = "Peso (kg)";
            // 
            // text_altura
            // 
            text_altura.Location = new Point(293, 46);
            text_altura.Name = "text_altura";
            text_altura.Size = new Size(98, 23);
            text_altura.TabIndex = 15;
            text_altura.Text = "0";
            text_altura.Leave += text_altura_Leave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(215, 49);
            label10.Name = "label10";
            label10.Size = new Size(72, 15);
            label10.TabIndex = 14;
            label10.Text = "Altura (mm)";
            // 
            // text_area
            // 
            text_area.Location = new Point(111, 78);
            text_area.Name = "text_area";
            text_area.Size = new Size(98, 23);
            text_area.TabIndex = 13;
            text_area.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 81);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 12;
            label9.Text = "Área (m2)";
            // 
            // text_largura
            // 
            text_largura.Location = new Point(111, 49);
            text_largura.Name = "text_largura";
            text_largura.Size = new Size(98, 23);
            text_largura.TabIndex = 11;
            text_largura.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 49);
            label8.Name = "label8";
            label8.Size = new Size(80, 15);
            label8.TabIndex = 10;
            label8.Text = "Largura (mm)";
            // 
            // combo_unidade_med
            // 
            combo_unidade_med.FormattingEnabled = true;
            combo_unidade_med.Location = new Point(293, 16);
            combo_unidade_med.Name = "combo_unidade_med";
            combo_unidade_med.Size = new Size(98, 23);
            combo_unidade_med.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(215, 19);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 8;
            label7.Text = "Unidade:";
            // 
            // text_qtd_item
            // 
            text_qtd_item.Location = new Point(111, 16);
            text_qtd_item.Name = "text_qtd_item";
            text_qtd_item.Size = new Size(98, 23);
            text_qtd_item.TabIndex = 8;
            text_qtd_item.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 19);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 3;
            label6.Text = "Quantidade Item:";
            // 
            // lb_id_item_obra
            // 
            lb_id_item_obra.AutoSize = true;
            lb_id_item_obra.Location = new Point(401, 19);
            lb_id_item_obra.Name = "lb_id_item_obra";
            lb_id_item_obra.Size = new Size(18, 15);
            lb_id_item_obra.TabIndex = 20;
            lb_id_item_obra.Text = "ID";
            // 
            // Form_item_obra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 496);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_item_obra";
            Text = "Items da Obra";
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid_lista_item_obra).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private Button bt_atualizar_item;
        private Button bt_deletar_item;
        private Button bt_salvar_item;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView grid_lista_item_obra;
        private ComboBox combo_id_projeto;
        private Label label1;
        private TextBox text_tipo_item;
        private Label label5;
        private Label lb_item_descricao;
        private Label label3;
        private TextBox text_descricao_item;
        private Label label2;
        private GroupBox groupBox4;
        private TextBox text_peso;
        private Label label11;
        private TextBox text_altura;
        private Label label10;
        private TextBox text_area;
        private Label label9;
        private TextBox text_largura;
        private Label label8;
        private ComboBox combo_unidade_med;
        private Label label7;
        private TextBox text_qtd_item;
        private Label label6;
        private Button bt_fechar;
        private TextBox text_perimetro;
        private Label label12;
        private Label lb_id_item_obra;
    }
}