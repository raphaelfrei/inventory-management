namespace INVT {
    partial class CreateSupplier {
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
            TbNome = new TextBox();
            LbDescricao = new Label();
            LbCodigo = new Label();
            LbDivisao = new Label();
            LbTitulo = new Label();
            BtnCancelar = new Button();
            BtnSalvar = new Button();
            TbCNPJ = new MaskedTextBox();
            TbEmail = new TextBox();
            label1 = new Label();
            TbTelefone = new MaskedTextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // TbNome
            // 
            TbNome.Location = new Point(103, 122);
            TbNome.MaxLength = 50;
            TbNome.Name = "TbNome";
            TbNome.PlaceholderText = "Razão Social do Fornecedor";
            TbNome.Size = new Size(364, 23);
            TbNome.TabIndex = 32;
            // 
            // LbDescricao
            // 
            LbDescricao.AutoSize = true;
            LbDescricao.Location = new Point(22, 125);
            LbDescricao.Name = "LbDescricao";
            LbDescricao.Size = new Size(75, 15);
            LbDescricao.TabIndex = 31;
            LbDescricao.Text = "Razão Social:";
            LbDescricao.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbCodigo
            // 
            LbCodigo.AutoSize = true;
            LbCodigo.Location = new Point(23, 96);
            LbCodigo.Name = "LbCodigo";
            LbCodigo.Size = new Size(37, 15);
            LbCodigo.TabIndex = 29;
            LbCodigo.Text = "CNPJ:";
            LbCodigo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbDivisao
            // 
            LbDivisao.BorderStyle = BorderStyle.Fixed3D;
            LbDivisao.Location = new Point(12, 84);
            LbDivisao.Name = "LbDivisao";
            LbDivisao.Size = new Size(468, 106);
            LbDivisao.TabIndex = 28;
            // 
            // LbTitulo
            // 
            LbTitulo.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            LbTitulo.Location = new Point(11, 12);
            LbTitulo.Name = "LbTitulo";
            LbTitulo.Size = new Size(468, 62);
            LbTitulo.TabIndex = 27;
            LbTitulo.Text = "Cadastrar Fornecedor";
            LbTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(290, 204);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(92, 23);
            BtnCancelar.TabIndex = 41;
            BtnCancelar.Text = "&Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(388, 204);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(92, 23);
            BtnSalvar.TabIndex = 40;
            BtnSalvar.Text = "&Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // TbCNPJ
            // 
            TbCNPJ.Location = new Point(66, 93);
            TbCNPJ.Mask = "999,999,999/9999-99";
            TbCNPJ.Name = "TbCNPJ";
            TbCNPJ.Size = new Size(127, 23);
            TbCNPJ.TabIndex = 42;
            // 
            // TbEmail
            // 
            TbEmail.Location = new Point(66, 151);
            TbEmail.MaxLength = 50;
            TbEmail.Name = "TbEmail";
            TbEmail.PlaceholderText = "Email do Fornecedor";
            TbEmail.Size = new Size(401, 23);
            TbEmail.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 154);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 43;
            label1.Text = "Email:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TbTelefone
            // 
            TbTelefone.Location = new Point(340, 93);
            TbTelefone.Mask = "(99) 9999-9999";
            TbTelefone.Name = "TbTelefone";
            TbTelefone.Size = new Size(127, 23);
            TbTelefone.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 96);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 45;
            label2.Text = "Telefone:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CreateSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 244);
            Controls.Add(TbTelefone);
            Controls.Add(label2);
            Controls.Add(TbEmail);
            Controls.Add(label1);
            Controls.Add(TbCNPJ);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnSalvar);
            Controls.Add(TbNome);
            Controls.Add(LbDescricao);
            Controls.Add(LbCodigo);
            Controls.Add(LbDivisao);
            Controls.Add(LbTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CreateSupplier";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastrar Fornecedor";
            FormClosing += CreateSupplier_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TbNome;
        private Label LbDescricao;
        private Label LbCodigo;
        private Label LbDivisao;
        private Label LbTitulo;
        private Button BtnCancelar;
        private Button BtnSalvar;
        private MaskedTextBox TbCNPJ;
        private TextBox TbEmail;
        private Label label1;
        private MaskedTextBox TbTelefone;
        private Label label2;
    }
}