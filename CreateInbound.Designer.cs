namespace INVT {
    partial class CreateInbound {
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
            LbNumeroNF = new Label();
            LbTitulo = new Label();
            TbNumeroNF = new TextBox();
            LbDataCompra = new Label();
            DtCompra = new DateTimePicker();
            TbDescricao = new TextBox();
            LbDesc = new Label();
            LbFornecedor = new Label();
            CbFornecedor = new ComboBox();
            TbValorNF = new TextBox();
            LbValorNF = new Label();
            TbArqNF = new TextBox();
            LbArqNF = new Label();
            BtnArqNF = new Button();
            LbDivisao = new Label();
            DgItens = new DataGridView();
            CodigoProduto = new DataGridViewTextBoxColumn();
            DescProduto = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            LbItensNF = new Label();
            BtnRemover = new Button();
            BtnAdicionar = new Button();
            BtnSalvar = new Button();
            BtnCancelar = new Button();
            LbObs = new Label();
            ((System.ComponentModel.ISupportInitialize)DgItens).BeginInit();
            SuspendLayout();
            // 
            // LbNumeroNF
            // 
            LbNumeroNF.AutoSize = true;
            LbNumeroNF.Location = new Point(16, 86);
            LbNumeroNF.Name = "LbNumeroNF";
            LbNumeroNF.Size = new Size(88, 15);
            LbNumeroNF.TabIndex = 0;
            LbNumeroNF.Text = "Número da NF:";
            LbNumeroNF.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbTitulo
            // 
            LbTitulo.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            LbTitulo.Location = new Point(12, 9);
            LbTitulo.Name = "LbTitulo";
            LbTitulo.Size = new Size(468, 62);
            LbTitulo.TabIndex = 1;
            LbTitulo.Text = "Entrada de Material";
            LbTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TbNumeroNF
            // 
            TbNumeroNF.Location = new Point(110, 83);
            TbNumeroNF.MaxLength = 20;
            TbNumeroNF.Name = "TbNumeroNF";
            TbNumeroNF.PlaceholderText = "000000000";
            TbNumeroNF.Size = new Size(143, 23);
            TbNumeroNF.TabIndex = 2;
            TbNumeroNF.TextChanged += TbNumeroNF_TextChanged;
            // 
            // LbDataCompra
            // 
            LbDataCompra.AutoSize = true;
            LbDataCompra.Location = new Point(275, 86);
            LbDataCompra.Name = "LbDataCompra";
            LbDataCompra.Size = new Size(96, 15);
            LbDataCompra.TabIndex = 3;
            LbDataCompra.Text = "Data de Compra:";
            LbDataCompra.TextAlign = ContentAlignment.MiddleRight;
            // 
            // DtCompra
            // 
            DtCompra.Format = DateTimePickerFormat.Short;
            DtCompra.Location = new Point(377, 83);
            DtCompra.Name = "DtCompra";
            DtCompra.Size = new Size(103, 23);
            DtCompra.TabIndex = 4;
            // 
            // TbDescricao
            // 
            TbDescricao.Location = new Point(110, 112);
            TbDescricao.MaxLength = 200;
            TbDescricao.Name = "TbDescricao";
            TbDescricao.PlaceholderText = "Nota Fiscal da compra de...";
            TbDescricao.Size = new Size(370, 23);
            TbDescricao.TabIndex = 6;
            // 
            // LbDesc
            // 
            LbDesc.AutoSize = true;
            LbDesc.Location = new Point(38, 115);
            LbDesc.Name = "LbDesc";
            LbDesc.Size = new Size(66, 15);
            LbDesc.TabIndex = 5;
            LbDesc.Text = "Descrição*:";
            LbDesc.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbFornecedor
            // 
            LbFornecedor.AutoSize = true;
            LbFornecedor.Location = new Point(34, 145);
            LbFornecedor.Name = "LbFornecedor";
            LbFornecedor.Size = new Size(70, 15);
            LbFornecedor.TabIndex = 7;
            LbFornecedor.Text = "Fornecedor:";
            LbFornecedor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CbFornecedor
            // 
            CbFornecedor.DropDownStyle = ComboBoxStyle.DropDownList;
            CbFornecedor.FormattingEnabled = true;
            CbFornecedor.Location = new Point(110, 142);
            CbFornecedor.Name = "CbFornecedor";
            CbFornecedor.Size = new Size(370, 23);
            CbFornecedor.TabIndex = 8;
            // 
            // TbValorNF
            // 
            TbValorNF.Location = new Point(110, 171);
            TbValorNF.MaxLength = 200;
            TbValorNF.Name = "TbValorNF";
            TbValorNF.PlaceholderText = "R$ 0.00";
            TbValorNF.Size = new Size(143, 23);
            TbValorNF.TabIndex = 10;
            TbValorNF.TextChanged += TbValorNF_TextChanged;
            TbValorNF.Leave += TbValorNF_Leave;
            // 
            // LbValorNF
            // 
            LbValorNF.AutoSize = true;
            LbValorNF.Location = new Point(34, 174);
            LbValorNF.Name = "LbValorNF";
            LbValorNF.Size = new Size(70, 15);
            LbValorNF.TabIndex = 9;
            LbValorNF.Text = "Valor da NF:";
            LbValorNF.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TbArqNF
            // 
            TbArqNF.Location = new Point(110, 200);
            TbArqNF.MaxLength = 200;
            TbArqNF.Name = "TbArqNF";
            TbArqNF.ReadOnly = true;
            TbArqNF.Size = new Size(261, 23);
            TbArqNF.TabIndex = 12;
            // 
            // LbArqNF
            // 
            LbArqNF.AutoSize = true;
            LbArqNF.Location = new Point(13, 203);
            LbArqNF.Name = "LbArqNF";
            LbArqNF.Size = new Size(91, 15);
            LbArqNF.TabIndex = 11;
            LbArqNF.Text = "Arquivo da NF*:";
            LbArqNF.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BtnArqNF
            // 
            BtnArqNF.Location = new Point(377, 200);
            BtnArqNF.Name = "BtnArqNF";
            BtnArqNF.Size = new Size(103, 23);
            BtnArqNF.TabIndex = 13;
            BtnArqNF.Text = "&Procurar";
            BtnArqNF.UseVisualStyleBackColor = true;
            // 
            // LbDivisao
            // 
            LbDivisao.BorderStyle = BorderStyle.Fixed3D;
            LbDivisao.Location = new Point(16, 240);
            LbDivisao.Name = "LbDivisao";
            LbDivisao.Size = new Size(464, 226);
            LbDivisao.TabIndex = 15;
            // 
            // DgItens
            // 
            DgItens.AllowUserToAddRows = false;
            DgItens.AllowUserToDeleteRows = false;
            DgItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgItens.Columns.AddRange(new DataGridViewColumn[] { CodigoProduto, DescProduto, Quantidade });
            DgItens.Location = new Point(25, 273);
            DgItens.MultiSelect = false;
            DgItens.Name = "DgItens";
            DgItens.RowTemplate.Height = 25;
            DgItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgItens.Size = new Size(443, 155);
            DgItens.TabIndex = 16;
            DgItens.CellValidating += DgItens_CellValidating;
            // 
            // CodigoProduto
            // 
            CodigoProduto.HeaderText = "Código do Produto";
            CodigoProduto.Name = "CodigoProduto";
            CodigoProduto.ReadOnly = true;
            // 
            // DescProduto
            // 
            DescProduto.HeaderText = "Descrição do Produto";
            DescProduto.Name = "DescProduto";
            DescProduto.ReadOnly = true;
            // 
            // Quantidade
            // 
            Quantidade.HeaderText = "Quantidade";
            Quantidade.Name = "Quantidade";
            // 
            // LbItensNF
            // 
            LbItensNF.AutoSize = true;
            LbItensNF.Location = new Point(25, 252);
            LbItensNF.Name = "LbItensNF";
            LbItensNF.Size = new Size(69, 15);
            LbItensNF.TabIndex = 17;
            LbItensNF.Text = "Itens da NF:";
            LbItensNF.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BtnRemover
            // 
            BtnRemover.Location = new Point(256, 434);
            BtnRemover.Name = "BtnRemover";
            BtnRemover.Size = new Size(103, 23);
            BtnRemover.TabIndex = 18;
            BtnRemover.Text = "&Remover Item";
            BtnRemover.UseVisualStyleBackColor = true;
            // 
            // BtnAdicionar
            // 
            BtnAdicionar.Location = new Point(365, 434);
            BtnAdicionar.Name = "BtnAdicionar";
            BtnAdicionar.Size = new Size(103, 23);
            BtnAdicionar.TabIndex = 19;
            BtnAdicionar.Text = "&Adicionar Item";
            BtnAdicionar.UseVisualStyleBackColor = true;
            BtnAdicionar.Click += BtnAdicionar_Click;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(377, 475);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(103, 23);
            BtnSalvar.TabIndex = 20;
            BtnSalvar.Text = "&Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(268, 475);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(103, 23);
            BtnCancelar.TabIndex = 21;
            BtnCancelar.Text = "&Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // LbObs
            // 
            LbObs.AutoSize = true;
            LbObs.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            LbObs.Location = new Point(259, 171);
            LbObs.Name = "LbObs";
            LbObs.Size = new Size(125, 12);
            LbObs.TabIndex = 14;
            LbObs.Text = "* Os campos são opcionais";
            // 
            // CreateInbound
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 511);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnSalvar);
            Controls.Add(BtnAdicionar);
            Controls.Add(BtnRemover);
            Controls.Add(LbItensNF);
            Controls.Add(DgItens);
            Controls.Add(LbDivisao);
            Controls.Add(LbObs);
            Controls.Add(BtnArqNF);
            Controls.Add(TbArqNF);
            Controls.Add(LbArqNF);
            Controls.Add(TbValorNF);
            Controls.Add(LbValorNF);
            Controls.Add(CbFornecedor);
            Controls.Add(LbFornecedor);
            Controls.Add(TbDescricao);
            Controls.Add(LbDesc);
            Controls.Add(DtCompra);
            Controls.Add(LbDataCompra);
            Controls.Add(TbNumeroNF);
            Controls.Add(LbTitulo);
            Controls.Add(LbNumeroNF);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CreateInbound";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastrar Entrada de Material";
            ((System.ComponentModel.ISupportInitialize)DgItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbNumeroNF;
        private Label LbTitulo;
        private TextBox TbNumeroNF;
        private Label LbDataCompra;
        private DateTimePicker DtCompra;
        private TextBox TbDescricao;
        private Label LbDesc;
        private Label LbFornecedor;
        private ComboBox CbFornecedor;
        private TextBox TbValorNF;
        private Label LbValorNF;
        private TextBox TbArqNF;
        private Label LbArqNF;
        private Button BtnArqNF;
        private Label LbDivisao;
        private DataGridView DgItens;
        private Label LbItensNF;
        private Button BtnRemover;
        private Button BtnAdicionar;
        private Button BtnSalvar;
        private Button BtnCancelar;
        private DataGridViewTextBoxColumn CodigoProduto;
        private DataGridViewTextBoxColumn DescProduto;
        private DataGridViewTextBoxColumn Quantidade;
        private Label LbObs;
    }
}