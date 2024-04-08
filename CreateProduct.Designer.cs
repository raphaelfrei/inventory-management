namespace INVT {
    partial class CreateProduct {
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
            LbDivisao = new Label();
            TbCodigo = new TextBox();
            LbCodigo = new Label();
            TbDescricao = new TextBox();
            LbDescricao = new Label();
            LbQtdMin = new Label();
            NumQuantidade = new NumericUpDown();
            TbCodigoBarras = new TextBox();
            LbCodigoBarras = new Label();
            label2 = new Label();
            LbTipo = new Label();
            CbTipo = new ComboBox();
            BtnTipoProd = new Button();
            LbEstoque = new Label();
            NumEstoque = new NumericUpDown();
            label1 = new Label();
            BtnSalvar = new Button();
            BtnCancelar = new Button();
            TbPreco = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)NumQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumEstoque).BeginInit();
            SuspendLayout();
            // 
            // LbTitulo
            // 
            LbTitulo.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            LbTitulo.Location = new Point(12, 9);
            LbTitulo.Name = "LbTitulo";
            LbTitulo.Size = new Size(468, 62);
            LbTitulo.TabIndex = 3;
            LbTitulo.Text = "Cadastrar Produto";
            LbTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LbDivisao
            // 
            LbDivisao.BorderStyle = BorderStyle.Fixed3D;
            LbDivisao.Location = new Point(13, 81);
            LbDivisao.Name = "LbDivisao";
            LbDivisao.Size = new Size(468, 106);
            LbDivisao.TabIndex = 17;
            // 
            // TbCodigo
            // 
            TbCodigo.Location = new Point(79, 90);
            TbCodigo.MaxLength = 20;
            TbCodigo.Name = "TbCodigo";
            TbCodigo.ReadOnly = true;
            TbCodigo.Size = new Size(388, 23);
            TbCodigo.TabIndex = 24;
            // 
            // LbCodigo
            // 
            LbCodigo.AutoSize = true;
            LbCodigo.Location = new Point(24, 93);
            LbCodigo.Name = "LbCodigo";
            LbCodigo.Size = new Size(49, 15);
            LbCodigo.TabIndex = 23;
            LbCodigo.Text = "Código:";
            LbCodigo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TbDescricao
            // 
            TbDescricao.Location = new Point(90, 119);
            TbDescricao.MaxLength = 50;
            TbDescricao.Name = "TbDescricao";
            TbDescricao.PlaceholderText = "Descrição do produto";
            TbDescricao.Size = new Size(174, 23);
            TbDescricao.TabIndex = 26;
            TbDescricao.TextChanged += TbDescricao_TextChanged;
            // 
            // LbDescricao
            // 
            LbDescricao.AutoSize = true;
            LbDescricao.Location = new Point(23, 122);
            LbDescricao.Name = "LbDescricao";
            LbDescricao.Size = new Size(61, 15);
            LbDescricao.TabIndex = 25;
            LbDescricao.Text = "Descrição:";
            LbDescricao.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbQtdMin
            // 
            LbQtdMin.AutoSize = true;
            LbQtdMin.Location = new Point(220, 240);
            LbQtdMin.Name = "LbQtdMin";
            LbQtdMin.Size = new Size(116, 15);
            LbQtdMin.TabIndex = 28;
            LbQtdMin.Text = "Quantidade Mínima:";
            LbQtdMin.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NumQuantidade
            // 
            NumQuantidade.Location = new Point(342, 237);
            NumQuantidade.Name = "NumQuantidade";
            NumQuantidade.Size = new Size(125, 23);
            NumQuantidade.TabIndex = 27;
            NumQuantidade.ThousandsSeparator = true;
            NumQuantidade.ValueChanged += NumQuantidade_ValueChanged;
            // 
            // TbCodigoBarras
            // 
            TbCodigoBarras.Location = new Point(129, 148);
            TbCodigoBarras.MaxLength = 50;
            TbCodigoBarras.Name = "TbCodigoBarras";
            TbCodigoBarras.PlaceholderText = "*A123B456C7*";
            TbCodigoBarras.Size = new Size(338, 23);
            TbCodigoBarras.TabIndex = 30;
            TbCodigoBarras.TextChanged += TbCodigoBarras_TextChanged;
            // 
            // LbCodigoBarras
            // 
            LbCodigoBarras.AutoSize = true;
            LbCodigoBarras.Location = new Point(23, 151);
            LbCodigoBarras.Name = "LbCodigoBarras";
            LbCodigoBarras.Size = new Size(100, 15);
            LbCodigoBarras.TabIndex = 29;
            LbCodigoBarras.Text = "Código de Barras:";
            LbCodigoBarras.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(12, 187);
            label2.Name = "label2";
            label2.Size = new Size(468, 90);
            label2.TabIndex = 31;
            // 
            // LbTipo
            // 
            LbTipo.AutoSize = true;
            LbTipo.Location = new Point(24, 201);
            LbTipo.Name = "LbTipo";
            LbTipo.Size = new Size(95, 15);
            LbTipo.TabIndex = 32;
            LbTipo.Text = "Tipo de Produto:";
            LbTipo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CbTipo
            // 
            CbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            CbTipo.FormattingEnabled = true;
            CbTipo.Location = new Point(125, 198);
            CbTipo.Name = "CbTipo";
            CbTipo.Size = new Size(244, 23);
            CbTipo.TabIndex = 33;
            CbTipo.SelectedIndexChanged += CbTipo_SelectedIndexChanged;
            // 
            // BtnTipoProd
            // 
            BtnTipoProd.Location = new Point(375, 198);
            BtnTipoProd.Name = "BtnTipoProd";
            BtnTipoProd.Size = new Size(92, 23);
            BtnTipoProd.TabIndex = 34;
            BtnTipoProd.Text = "&Gerenciar";
            BtnTipoProd.UseVisualStyleBackColor = true;
            BtnTipoProd.Click += BtnTipoProd_Click;
            // 
            // LbEstoque
            // 
            LbEstoque.AutoSize = true;
            LbEstoque.Location = new Point(24, 239);
            LbEstoque.Name = "LbEstoque";
            LbEstoque.Size = new Size(57, 15);
            LbEstoque.TabIndex = 36;
            LbEstoque.Text = "Estoque*:";
            LbEstoque.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NumEstoque
            // 
            NumEstoque.Location = new Point(87, 237);
            NumEstoque.Name = "NumEstoque";
            NumEstoque.Size = new Size(125, 23);
            NumEstoque.TabIndex = 35;
            NumEstoque.ThousandsSeparator = true;
            NumEstoque.ValueChanged += NumEstoque_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 280);
            label1.Name = "label1";
            label1.Size = new Size(455, 24);
            label1.TabIndex = 37;
            label1.Text = "* O valor é incrementado automaticamente ao dar entrada em uma NF. Após a primeira inserção, não \r\né possível alterar a quantidade manualmente.";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(388, 300);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(92, 23);
            BtnSalvar.TabIndex = 38;
            BtnSalvar.Text = "&Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(290, 300);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(92, 23);
            BtnCancelar.TabIndex = 39;
            BtnCancelar.Text = "&Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // TbPreco
            // 
            TbPreco.Location = new Point(316, 119);
            TbPreco.MaxLength = 50;
            TbPreco.Name = "TbPreco";
            TbPreco.PlaceholderText = "R$ 0.00";
            TbPreco.Size = new Size(148, 23);
            TbPreco.TabIndex = 41;
            TbPreco.TextChanged += TbPreco_TextChanged;
            TbPreco.Leave += TbPreco_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(270, 122);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 40;
            label3.Text = "Preço:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CreateProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 336);
            Controls.Add(TbPreco);
            Controls.Add(label3);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnSalvar);
            Controls.Add(label1);
            Controls.Add(LbEstoque);
            Controls.Add(NumEstoque);
            Controls.Add(BtnTipoProd);
            Controls.Add(CbTipo);
            Controls.Add(LbTipo);
            Controls.Add(TbCodigoBarras);
            Controls.Add(LbCodigoBarras);
            Controls.Add(LbQtdMin);
            Controls.Add(NumQuantidade);
            Controls.Add(TbDescricao);
            Controls.Add(LbDescricao);
            Controls.Add(TbCodigo);
            Controls.Add(LbCodigo);
            Controls.Add(LbDivisao);
            Controls.Add(LbTitulo);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CreateProduct";
            Text = "Cadastrar Produto";
            FormClosing += CreateProduct_FormClosing;
            ((System.ComponentModel.ISupportInitialize)NumQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbTitulo;
        private Label LbDivisao;
        private TextBox TbCodigo;
        private Label LbCodigo;
        private TextBox TbDescricao;
        private Label LbDescricao;
        private Label LbQtdMin;
        private NumericUpDown NumQuantidade;
        private TextBox TbCodigoBarras;
        private Label LbCodigoBarras;
        private Label label2;
        private Label LbTipo;
        private ComboBox CbTipo;
        private Button BtnTipoProd;
        private Label LbEstoque;
        private NumericUpDown NumEstoque;
        private Label label1;
        private Button BtnSalvar;
        private Button BtnCancelar;
        private TextBox TbPreco;
        private Label label3;
    }
}