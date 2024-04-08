namespace INVT {
    partial class ManageCreateSector {
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
            BtnCriar = new Button();
            BtnEditar = new Button();
            LbSelecionado = new Label();
            TbSelecionado = new TextBox();
            LbInformacoes = new Label();
            label1 = new Label();
            CbDescricao = new CheckBox();
            CbCodigo = new CheckBox();
            TbDescricao = new TextBox();
            TbCodigo = new TextBox();
            LbFiltro = new Label();
            LbDivisao = new Label();
            DgItens = new DataGridView();
            CodigoProduto = new DataGridViewTextBoxColumn();
            DescProduto = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DgItens).BeginInit();
            SuspendLayout();
            // 
            // LbTitulo
            // 
            LbTitulo.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            LbTitulo.Location = new Point(12, 9);
            LbTitulo.Name = "LbTitulo";
            LbTitulo.Size = new Size(725, 62);
            LbTitulo.TabIndex = 2;
            LbTitulo.Text = "Gerenciar Setores";
            LbTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnCriar
            // 
            BtnCriar.Location = new Point(509, 306);
            BtnCriar.Name = "BtnCriar";
            BtnCriar.Size = new Size(216, 23);
            BtnCriar.TabIndex = 53;
            BtnCriar.Text = "&Criar Setor";
            BtnCriar.UseVisualStyleBackColor = true;
            BtnCriar.Click += BtnCriar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.Enabled = false;
            BtnEditar.Location = new Point(509, 252);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(216, 23);
            BtnEditar.TabIndex = 52;
            BtnEditar.Text = "&Editar Setor";
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // LbSelecionado
            // 
            LbSelecionado.AutoSize = true;
            LbSelecionado.Location = new Point(509, 217);
            LbSelecionado.Name = "LbSelecionado";
            LbSelecionado.Size = new Size(74, 15);
            LbSelecionado.TabIndex = 51;
            LbSelecionado.Text = "Selecionado:";
            // 
            // TbSelecionado
            // 
            TbSelecionado.Location = new Point(589, 214);
            TbSelecionado.MaxLength = 20;
            TbSelecionado.Name = "TbSelecionado";
            TbSelecionado.ReadOnly = true;
            TbSelecionado.Size = new Size(136, 23);
            TbSelecionado.TabIndex = 50;
            // 
            // LbInformacoes
            // 
            LbInformacoes.AutoSize = true;
            LbInformacoes.Location = new Point(509, 186);
            LbInformacoes.Name = "LbInformacoes";
            LbInformacoes.Size = new Size(76, 15);
            LbInformacoes.TabIndex = 49;
            LbInformacoes.Text = "Informações:";
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(500, 181);
            label1.Name = "label1";
            label1.Size = new Size(237, 107);
            label1.TabIndex = 48;
            // 
            // CbDescricao
            // 
            CbDescricao.AutoSize = true;
            CbDescricao.Location = new Point(509, 118);
            CbDescricao.Name = "CbDescricao";
            CbDescricao.Size = new Size(80, 19);
            CbDescricao.TabIndex = 47;
            CbDescricao.Text = "Descrição:";
            CbDescricao.UseVisualStyleBackColor = true;
            CbDescricao.CheckedChanged += CbDescricao_CheckedChanged;
            // 
            // CbCodigo
            // 
            CbCodigo.AutoSize = true;
            CbCodigo.Location = new Point(509, 89);
            CbCodigo.Name = "CbCodigo";
            CbCodigo.Size = new Size(68, 19);
            CbCodigo.TabIndex = 46;
            CbCodigo.Text = "Código:";
            CbCodigo.UseVisualStyleBackColor = true;
            CbCodigo.CheckedChanged += CbCodigo_CheckedChanged;
            // 
            // TbDescricao
            // 
            TbDescricao.Location = new Point(595, 116);
            TbDescricao.MaxLength = 20;
            TbDescricao.Name = "TbDescricao";
            TbDescricao.PlaceholderText = "Descrição";
            TbDescricao.ReadOnly = true;
            TbDescricao.Size = new Size(130, 23);
            TbDescricao.TabIndex = 45;
            TbDescricao.TextChanged += TbDescricao_TextChanged;
            // 
            // TbCodigo
            // 
            TbCodigo.Location = new Point(583, 87);
            TbCodigo.MaxLength = 20;
            TbCodigo.Name = "TbCodigo";
            TbCodigo.PlaceholderText = "0";
            TbCodigo.ReadOnly = true;
            TbCodigo.Size = new Size(142, 23);
            TbCodigo.TabIndex = 44;
            TbCodigo.TextChanged += TbCodigo_TextChanged;
            // 
            // LbFiltro
            // 
            LbFiltro.AutoSize = true;
            LbFiltro.Location = new Point(509, 66);
            LbFiltro.Name = "LbFiltro";
            LbFiltro.Size = new Size(40, 15);
            LbFiltro.TabIndex = 43;
            LbFiltro.Text = "Filtrar:";
            // 
            // LbDivisao
            // 
            LbDivisao.BorderStyle = BorderStyle.Fixed3D;
            LbDivisao.Location = new Point(500, 74);
            LbDivisao.Name = "LbDivisao";
            LbDivisao.Size = new Size(237, 107);
            LbDivisao.TabIndex = 42;
            // 
            // DgItens
            // 
            DgItens.AllowUserToAddRows = false;
            DgItens.AllowUserToDeleteRows = false;
            DgItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgItens.Columns.AddRange(new DataGridViewColumn[] { CodigoProduto, DescProduto });
            DgItens.Location = new Point(12, 74);
            DgItens.MultiSelect = false;
            DgItens.Name = "DgItens";
            DgItens.ReadOnly = true;
            DgItens.RowTemplate.Height = 25;
            DgItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgItens.Size = new Size(482, 272);
            DgItens.TabIndex = 41;
            DgItens.CellClick += DgItens_CellClick;
            // 
            // CodigoProduto
            // 
            CodigoProduto.FillWeight = 101.522842F;
            CodigoProduto.HeaderText = "Código do Setor";
            CodigoProduto.Name = "CodigoProduto";
            CodigoProduto.ReadOnly = true;
            // 
            // DescProduto
            // 
            DescProduto.FillWeight = 200F;
            DescProduto.HeaderText = "Descrição do Setor";
            DescProduto.Name = "DescProduto";
            DescProduto.ReadOnly = true;
            // 
            // ManageCreateSector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 361);
            Controls.Add(BtnCriar);
            Controls.Add(BtnEditar);
            Controls.Add(LbSelecionado);
            Controls.Add(TbSelecionado);
            Controls.Add(LbInformacoes);
            Controls.Add(label1);
            Controls.Add(CbDescricao);
            Controls.Add(CbCodigo);
            Controls.Add(TbDescricao);
            Controls.Add(TbCodigo);
            Controls.Add(LbFiltro);
            Controls.Add(LbDivisao);
            Controls.Add(DgItens);
            Controls.Add(LbTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ManageCreateSector";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastrar/Editar Setor";
            ((System.ComponentModel.ISupportInitialize)DgItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbTitulo;
        private Button BtnCriar;
        private Button BtnEditar;
        private Label LbSelecionado;
        private TextBox TbSelecionado;
        private Label LbInformacoes;
        private Label label1;
        private CheckBox CbDescricao;
        private CheckBox CbCodigo;
        private TextBox TbDescricao;
        private TextBox TbCodigo;
        private Label LbFiltro;
        private Label LbDivisao;
        private DataGridView DgItens;
        private DataGridViewTextBoxColumn CodigoProduto;
        private DataGridViewTextBoxColumn DescProduto;
    }
}