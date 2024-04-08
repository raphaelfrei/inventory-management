namespace INVT {
    partial class ManageProduct {
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
            DgItens = new DataGridView();
            CodigoProduto = new DataGridViewTextBoxColumn();
            DescProduto = new DataGridViewTextBoxColumn();
            Estoque = new DataGridViewTextBoxColumn();
            EstoqueMin = new DataGridViewTextBoxColumn();
            LbDivisao = new Label();
            LbFiltro = new Label();
            TbCodigo = new TextBox();
            NumQtdMin = new NumericUpDown();
            TbDescricao = new TextBox();
            LbE = new Label();
            CbCodigo = new CheckBox();
            CbDescricao = new CheckBox();
            CbQuantidade = new CheckBox();
            NumQtdMax = new NumericUpDown();
            label1 = new Label();
            LbInformacoes = new Label();
            TbSelecionado = new TextBox();
            LbSelecionado = new Label();
            BtnDeletar = new Button();
            BtnEditar = new Button();
            BtnCriar = new Button();
            ((System.ComponentModel.ISupportInitialize)DgItens).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumQtdMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumQtdMax).BeginInit();
            SuspendLayout();
            // 
            // LbTitulo
            // 
            LbTitulo.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            LbTitulo.Location = new Point(12, 9);
            LbTitulo.Name = "LbTitulo";
            LbTitulo.Size = new Size(868, 62);
            LbTitulo.TabIndex = 1;
            LbTitulo.Text = "Gerenciar Produtos";
            LbTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DgItens
            // 
            DgItens.AllowUserToAddRows = false;
            DgItens.AllowUserToDeleteRows = false;
            DgItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgItens.Columns.AddRange(new DataGridViewColumn[] { CodigoProduto, DescProduto, Estoque, EstoqueMin });
            DgItens.Location = new Point(12, 83);
            DgItens.MultiSelect = false;
            DgItens.Name = "DgItens";
            DgItens.ReadOnly = true;
            DgItens.RowTemplate.Height = 25;
            DgItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgItens.Size = new Size(625, 295);
            DgItens.TabIndex = 17;
            DgItens.CellClick += DgItens_CellClick;
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
            // Estoque
            // 
            Estoque.HeaderText = "Quantidade em Estoque";
            Estoque.Name = "Estoque";
            Estoque.ReadOnly = true;
            // 
            // EstoqueMin
            // 
            EstoqueMin.HeaderText = "Quantidade Mínima";
            EstoqueMin.Name = "EstoqueMin";
            EstoqueMin.ReadOnly = true;
            // 
            // LbDivisao
            // 
            LbDivisao.BorderStyle = BorderStyle.Fixed3D;
            LbDivisao.Location = new Point(643, 83);
            LbDivisao.Name = "LbDivisao";
            LbDivisao.Size = new Size(237, 107);
            LbDivisao.TabIndex = 18;
            // 
            // LbFiltro
            // 
            LbFiltro.AutoSize = true;
            LbFiltro.Location = new Point(652, 75);
            LbFiltro.Name = "LbFiltro";
            LbFiltro.Size = new Size(40, 15);
            LbFiltro.TabIndex = 19;
            LbFiltro.Text = "Filtrar:";
            // 
            // TbCodigo
            // 
            TbCodigo.Location = new Point(726, 96);
            TbCodigo.MaxLength = 20;
            TbCodigo.Name = "TbCodigo";
            TbCodigo.PlaceholderText = "0";
            TbCodigo.ReadOnly = true;
            TbCodigo.Size = new Size(142, 23);
            TbCodigo.TabIndex = 21;
            TbCodigo.TextChanged += TbCodigo_TextChanged;
            // 
            // NumQtdMin
            // 
            NumQtdMin.Location = new Point(751, 154);
            NumQtdMin.Name = "NumQtdMin";
            NumQtdMin.ReadOnly = true;
            NumQtdMin.Size = new Size(49, 23);
            NumQtdMin.TabIndex = 26;
            NumQtdMin.ValueChanged += NumQtdMin_ValueChanged;
            // 
            // TbDescricao
            // 
            TbDescricao.Location = new Point(738, 125);
            TbDescricao.MaxLength = 20;
            TbDescricao.Name = "TbDescricao";
            TbDescricao.PlaceholderText = "Descrição";
            TbDescricao.ReadOnly = true;
            TbDescricao.Size = new Size(130, 23);
            TbDescricao.TabIndex = 28;
            TbDescricao.TextChanged += TbDescricao_TextChanged;
            // 
            // LbE
            // 
            LbE.AutoSize = true;
            LbE.Location = new Point(803, 157);
            LbE.Name = "LbE";
            LbE.Size = new Size(13, 15);
            LbE.TabIndex = 29;
            LbE.Text = "e";
            LbE.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CbCodigo
            // 
            CbCodigo.AutoSize = true;
            CbCodigo.Location = new Point(652, 98);
            CbCodigo.Name = "CbCodigo";
            CbCodigo.Size = new Size(68, 19);
            CbCodigo.TabIndex = 30;
            CbCodigo.Text = "Código:";
            CbCodigo.UseVisualStyleBackColor = true;
            CbCodigo.CheckedChanged += CbCodigo_CheckedChanged;
            // 
            // CbDescricao
            // 
            CbDescricao.AutoSize = true;
            CbDescricao.Location = new Point(652, 127);
            CbDescricao.Name = "CbDescricao";
            CbDescricao.Size = new Size(80, 19);
            CbDescricao.TabIndex = 31;
            CbDescricao.Text = "Descrição:";
            CbDescricao.UseVisualStyleBackColor = true;
            CbDescricao.CheckedChanged += CbDescricao_CheckedChanged;
            // 
            // CbQuantidade
            // 
            CbQuantidade.AutoSize = true;
            CbQuantidade.Location = new Point(652, 157);
            CbQuantidade.Name = "CbQuantidade";
            CbQuantidade.Size = new Size(98, 19);
            CbQuantidade.TabIndex = 32;
            CbQuantidade.Text = "Estoque entre";
            CbQuantidade.UseVisualStyleBackColor = true;
            CbQuantidade.CheckedChanged += CbQuantidade_CheckedChanged;
            // 
            // NumQtdMax
            // 
            NumQtdMax.Location = new Point(819, 154);
            NumQtdMax.Name = "NumQtdMax";
            NumQtdMax.ReadOnly = true;
            NumQtdMax.Size = new Size(49, 23);
            NumQtdMax.TabIndex = 33;
            NumQtdMax.ValueChanged += NumQtdMax_ValueChanged;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(643, 190);
            label1.Name = "label1";
            label1.Size = new Size(237, 132);
            label1.TabIndex = 34;
            // 
            // LbInformacoes
            // 
            LbInformacoes.AutoSize = true;
            LbInformacoes.Location = new Point(652, 195);
            LbInformacoes.Name = "LbInformacoes";
            LbInformacoes.Size = new Size(76, 15);
            LbInformacoes.TabIndex = 35;
            LbInformacoes.Text = "Informações:";
            // 
            // TbSelecionado
            // 
            TbSelecionado.Location = new Point(732, 223);
            TbSelecionado.MaxLength = 20;
            TbSelecionado.Name = "TbSelecionado";
            TbSelecionado.ReadOnly = true;
            TbSelecionado.Size = new Size(136, 23);
            TbSelecionado.TabIndex = 36;
            // 
            // LbSelecionado
            // 
            LbSelecionado.AutoSize = true;
            LbSelecionado.Location = new Point(652, 226);
            LbSelecionado.Name = "LbSelecionado";
            LbSelecionado.Size = new Size(74, 15);
            LbSelecionado.TabIndex = 37;
            LbSelecionado.Text = "Selecionado:";
            // 
            // BtnDeletar
            // 
            BtnDeletar.Location = new Point(652, 262);
            BtnDeletar.Name = "BtnDeletar";
            BtnDeletar.Size = new Size(216, 23);
            BtnDeletar.TabIndex = 38;
            BtnDeletar.Text = "&Deletar Produto";
            BtnDeletar.UseVisualStyleBackColor = true;
            BtnDeletar.Click += BtnDeletar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.Location = new Point(652, 291);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(216, 23);
            BtnEditar.TabIndex = 39;
            BtnEditar.Text = "&Editar Produto";
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnCriar
            // 
            BtnCriar.Location = new Point(652, 339);
            BtnCriar.Name = "BtnCriar";
            BtnCriar.Size = new Size(216, 23);
            BtnCriar.TabIndex = 40;
            BtnCriar.Text = "&Criar Produto";
            BtnCriar.UseVisualStyleBackColor = true;
            BtnCriar.Click += BtnCriar_Click;
            // 
            // ManageProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 392);
            Controls.Add(BtnCriar);
            Controls.Add(BtnEditar);
            Controls.Add(BtnDeletar);
            Controls.Add(LbSelecionado);
            Controls.Add(TbSelecionado);
            Controls.Add(LbInformacoes);
            Controls.Add(label1);
            Controls.Add(NumQtdMax);
            Controls.Add(CbQuantidade);
            Controls.Add(CbDescricao);
            Controls.Add(CbCodigo);
            Controls.Add(LbE);
            Controls.Add(TbDescricao);
            Controls.Add(NumQtdMin);
            Controls.Add(TbCodigo);
            Controls.Add(LbFiltro);
            Controls.Add(LbDivisao);
            Controls.Add(DgItens);
            Controls.Add(LbTitulo);
            MaximizeBox = false;
            Name = "ManageProduct";
            Text = "Gerenciar Produtos";
            Shown += ManageProduct_Shown;
            ((System.ComponentModel.ISupportInitialize)DgItens).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumQtdMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumQtdMax).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbTitulo;
        private DataGridView DgItens;
        private DataGridViewTextBoxColumn CodigoProduto;
        private DataGridViewTextBoxColumn DescProduto;
        private DataGridViewTextBoxColumn Estoque;
        private DataGridViewTextBoxColumn EstoqueMin;
        private Label LbDivisao;
        private Label LbFiltro;
        private TextBox TbCodigo;
        private NumericUpDown NumQtdMin;
        private TextBox TbDescricao;
        private Label LbE;
        private CheckBox CbCodigo;
        private CheckBox CbDescricao;
        private CheckBox CbQuantidade;
        private NumericUpDown NumQtdMax;
        private Label label1;
        private Label LbInformacoes;
        private TextBox TbSelecionado;
        private Label LbSelecionado;
        private Button BtnDeletar;
        private Button BtnEditar;
        private Button BtnCriar;
    }
}