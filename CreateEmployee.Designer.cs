namespace INVT {
    partial class CreateEmployee {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            LbTitulo = new Label();
            label1 = new Label();
            TbNome = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            BtnCriarSetor = new Button();
            CbSetor = new ComboBox();
            BtnSalvar = new Button();
            BtnCancelar = new Button();
            NumRE = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)NumRE).BeginInit();
            SuspendLayout();
            // 
            // LbTitulo
            // 
            LbTitulo.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            LbTitulo.Location = new Point(12, 9);
            LbTitulo.Name = "LbTitulo";
            LbTitulo.Size = new Size(463, 62);
            LbTitulo.TabIndex = 3;
            LbTitulo.Text = "Adicionar Funcionário";
            LbTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 100);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 66;
            label1.Text = "Nome:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TbNome
            // 
            TbNome.Location = new Point(71, 97);
            TbNome.MaxLength = 20;
            TbNome.Name = "TbNome";
            TbNome.PlaceholderText = "Nome Completo";
            TbNome.Size = new Size(392, 23);
            TbNome.TabIndex = 65;
            TbNome.TextChanged += TbNome_TextChanged;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(12, 80);
            label3.Name = "label3";
            label3.Size = new Size(463, 110);
            label3.TabIndex = 67;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 129);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 69;
            label2.Text = "RE:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 158);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 70;
            label4.Text = "Setor:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BtnCriarSetor
            // 
            BtnCriarSetor.Location = new Point(388, 154);
            BtnCriarSetor.Name = "BtnCriarSetor";
            BtnCriarSetor.Size = new Size(75, 24);
            BtnCriarSetor.TabIndex = 71;
            BtnCriarSetor.Text = "&Gerenciar";
            BtnCriarSetor.UseVisualStyleBackColor = true;
            BtnCriarSetor.Click += BtnCriarSetor_Click;
            // 
            // CbSetor
            // 
            CbSetor.DropDownStyle = ComboBoxStyle.DropDownList;
            CbSetor.FormattingEnabled = true;
            CbSetor.Location = new Point(71, 155);
            CbSetor.Name = "CbSetor";
            CbSetor.Size = new Size(311, 23);
            CbSetor.TabIndex = 72;
            CbSetor.SelectedIndexChanged += CbSetor_SelectedIndexChanged;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(400, 204);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(75, 24);
            BtnSalvar.TabIndex = 73;
            BtnSalvar.Text = "&Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(319, 204);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 24);
            BtnCancelar.TabIndex = 74;
            BtnCancelar.Text = "&Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // NumRE
            // 
            NumRE.Location = new Point(71, 126);
            NumRE.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            NumRE.Name = "NumRE";
            NumRE.Size = new Size(125, 23);
            NumRE.TabIndex = 75;
            NumRE.ThousandsSeparator = true;
            NumRE.ValueChanged += NumRE_ValueChanged;
            // 
            // CreateEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 245);
            Controls.Add(NumRE);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnSalvar);
            Controls.Add(CbSetor);
            Controls.Add(BtnCriarSetor);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TbNome);
            Controls.Add(label3);
            Controls.Add(LbTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CreateEmployee";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Adicionar Funcionário";
            FormClosing += CreateEmployee_FormClosing;
            ((System.ComponentModel.ISupportInitialize)NumRE).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbTitulo;
        private Label label1;
        private TextBox TbNome;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button BtnCriarSetor;
        private ComboBox CbSetor;
        private Button BtnSalvar;
        private Button BtnCancelar;
        private NumericUpDown NumRE;
    }
}