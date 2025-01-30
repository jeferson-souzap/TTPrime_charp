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
            panel1 = new Panel();
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel_central = new Panel();
            button5 = new Button();
            button6 = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 558);
            panel1.Name = "panel1";
            panel1.Size = new Size(1058, 30);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(179, 558);
            panel2.TabIndex = 1;
            // 
            // button4
            // 
            button4.Location = new Point(3, 256);
            button4.Name = "button4";
            button4.Size = new Size(170, 23);
            button4.TabIndex = 4;
            button4.Text = "Apontamento";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(3, 227);
            button3.Name = "button3";
            button3.Size = new Size(170, 23);
            button3.TabIndex = 3;
            button3.Text = "Ordem de produção";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(3, 198);
            button2.Name = "button2";
            button2.Size = new Size(170, 23);
            button2.TabIndex = 2;
            button2.Text = "Items da obra";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(3, 169);
            button1.Name = "button1";
            button1.Size = new Size(170, 23);
            button1.TabIndex = 1;
            button1.Text = "Cadastro de Obra";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 148);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel_central
            // 
            panel_central.Dock = DockStyle.Fill;
            panel_central.Location = new Point(179, 0);
            panel_central.Name = "panel_central";
            panel_central.Size = new Size(879, 558);
            panel_central.TabIndex = 2;
            // 
            // button5
            // 
            button5.Location = new Point(3, 285);
            button5.Name = "button5";
            button5.Size = new Size(170, 23);
            button5.TabIndex = 5;
            button5.Text = "Histório Obras";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(3, 314);
            button6.Name = "button6";
            button6.Size = new Size(170, 23);
            button6.TabIndex = 6;
            button6.Text = "Configuração";
            button6.UseVisualStyleBackColor = true;
            // 
            // Form_home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 588);
            Controls.Add(panel_central);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form_home";
            Text = "PRIME";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel_central;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button6;
        private Button button5;
    }
}
