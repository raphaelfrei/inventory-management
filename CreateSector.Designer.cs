namespace INVT {
    partial class CreateSector {
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
            BtnCancelar = new Button();
            BtnSalvar = new Button();
            TbDescricao = new TextBox();
            LbDescricao = new Label();
            TbCodigo = new TextBox();
            LbCodigo = new Label();
            LbDivisao = new Label();
            LbTitulo = new Label();
            SuspendLayout();
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(299, 169);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(92, 23);
            BtnCancelar.TabIndex = 47;
            BtnCancelar.Text = "&Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(397, 169);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(92, 23);
            BtnSalvar.TabIndex = 46;
            BtnSalvar.Text = "&Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // TbDescricao
            // 
            TbDescricao.Location = new Point(90, 119);
            TbDescricao.MaxLength = 50;
            TbDescricao.Name = "TbDescricao";
            TbDescricao.PlaceholderText = "Descrição do setor";
            TbDescricao.Size = new Size(377, 23);
            TbDescricao.TabIndex = 45;
            TbDescricao.TextChanged += TbDescricao_TextChanged;
            // 
            // LbDescricao
            // 
            LbDescricao.AutoSize = true;
            LbDescricao.Location = new Point(23, 122);
            LbDescricao.Name = "LbDescricao";
            LbDescricao.Size = new Size(61, 15);
            LbDescricao.TabIndex = 44;
            LbDescricao.Text = "Descrição:";
            LbDescricao.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TbCodigo
            // 
            TbCodigo.Location = new Point(79, 90);
            TbCodigo.MaxLength = 20;
            TbCodigo.Name = "TbCodigo";
            TbCodigo.ReadOnly = true;
            TbCodigo.Size = new Size(388, 23);
            TbCodigo.TabIndex = 43;
            // 
            // LbCodigo
            // 
            LbCodigo.AutoSize = true;
            LbCodigo.Location = new Point(24, 93);
            LbCodigo.Name = "LbCodigo";
            LbCodigo.Size = new Size(49, 15);
            LbCodigo.TabIndex = 42;
            LbCodigo.Text = "Código:";
            LbCodigo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbDivisao
            // 
            LbDivisao.BorderStyle = BorderStyle.Fixed3D;
            LbDivisao.Location = new Point(13, 81);
            LbDivisao.Name = "LbDivisao";
            LbDivisao.Size = new Size(468, 75);
            LbDivisao.TabIndex = 41;
            // 
            // LbTitulo
            // 
            LbTitulo.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            LbTitulo.Location = new Point(12, 9);
            LbTitulo.Name = "LbTitulo";
            LbTitulo.Size = new Size(468, 62);
            LbTitulo.TabIndex = 40;
            LbTitulo.Text = "Adicionar Produto";
            LbTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CreateSector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 205);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnSalvar);
            Controls.Add(TbDescricao);
            Controls.Add(LbDescricao);
            Controls.Add(TbCodigo);
            Controls.Add(LbCodigo);
            Controls.Add(LbDivisao);
            Controls.Add(LbTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CreateSector";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastrar Setor";
            FormClosing += CreateSector_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCancelar;
        private Button BtnSalvar;
        private TextBox TbDescricao;
        private Label LbDescricao;
        private TextBox TbCodigo;
        private Label LbCodigo;
        private Label LbDivisao;
        private Label LbTitulo;
    }
}