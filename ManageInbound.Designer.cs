namespace INVT {
    partial class ManageInbound {
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
            Valor = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            cnpj = new DataGridViewTextBoxColumn();
            DgSubItem = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            LbFiltro = new Label();
            LbDivisao = new Label();
            label1 = new Label();
            CbData = new CheckBox();
            CbDescricao = new CheckBox();
            CbCodigo = new CheckBox();
            LbE = new Label();
            TbDescricao = new TextBox();
            TbCodigo = new TextBox();
            DtDe = new DateTimePicker();
            DtAte = new DateTimePicker();
            BtnCriar = new Button();
            BtnEditar = new Button();
            BtnExcluir = new Button();
            label2 = new Label();
            TbNota = new TextBox();
            LbNota = new Label();
            ((System.ComponentModel.ISupportInitialize)DgItens).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgSubItem).BeginInit();
            SuspendLayout();
            // 
            // LbTitulo
            // 
            LbTitulo.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            LbTitulo.Location = new Point(12, 9);
            LbTitulo.Name = "LbTitulo";
            LbTitulo.Size = new Size(950, 62);
            LbTitulo.TabIndex = 2;
            LbTitulo.Text = "Gerenciar Entradas de Material";
            LbTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DgItens
            // 
            DgItens.AllowUserToAddRows = false;
            DgItens.AllowUserToDeleteRows = false;
            DgItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgItens.Columns.AddRange(new DataGridViewColumn[] { CodigoProduto, DescProduto, Estoque, Valor, Data, cnpj });
            DgItens.Location = new Point(12, 87);
            DgItens.MultiSelect = false;
            DgItens.Name = "DgItens";
            DgItens.ReadOnly = true;
            DgItens.RowTemplate.Height = 25;
            DgItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgItens.Size = new Size(625, 434);
            DgItens.TabIndex = 18;
            DgItens.CellClick += DgItens_CellClick;
            // 
            // CodigoProduto
            // 
            CodigoProduto.HeaderText = "Número da NF";
            CodigoProduto.Name = "CodigoProduto";
            CodigoProduto.ReadOnly = true;
            // 
            // DescProduto
            // 
            DescProduto.HeaderText = "Descrição";
            DescProduto.Name = "DescProduto";
            DescProduto.ReadOnly = true;
            // 
            // Estoque
            // 
            Estoque.HeaderText = "Quantidade de Produto";
            Estoque.Name = "Estoque";
            Estoque.ReadOnly = true;
            // 
            // Valor
            // 
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            // 
            // Data
            // 
            Data.HeaderText = "Data de Entrada";
            Data.Name = "Data";
            Data.ReadOnly = true;
            // 
            // cnpj
            // 
            cnpj.HeaderText = "Fornecedor";
            cnpj.Name = "cnpj";
            cnpj.ReadOnly = true;
            cnpj.Visible = false;
            // 
            // DgSubItem
            // 
            DgSubItem.AllowUserToAddRows = false;
            DgSubItem.AllowUserToDeleteRows = false;
            DgSubItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgSubItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgSubItem.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            DgSubItem.Location = new Point(643, 349);
            DgSubItem.MultiSelect = false;
            DgSubItem.Name = "DgSubItem";
            DgSubItem.ReadOnly = true;
            DgSubItem.RowTemplate.Height = 25;
            DgSubItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgSubItem.Size = new Size(319, 172);
            DgSubItem.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Quantidade";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // LbFiltro
            // 
            LbFiltro.AutoSize = true;
            LbFiltro.Location = new Point(652, 79);
            LbFiltro.Name = "LbFiltro";
            LbFiltro.Size = new Size(40, 15);
            LbFiltro.TabIndex = 21;
            LbFiltro.Text = "Filtrar:";
            // 
            // LbDivisao
            // 
            LbDivisao.BorderStyle = BorderStyle.Fixed3D;
            LbDivisao.Location = new Point(643, 87);
            LbDivisao.Name = "LbDivisao";
            LbDivisao.Size = new Size(319, 108);
            LbDivisao.TabIndex = 20;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(644, 242);
            label1.Name = "label1";
            label1.Size = new Size(319, 100);
            label1.TabIndex = 22;
            // 
            // CbData
            // 
            CbData.AutoSize = true;
            CbData.Location = new Point(651, 162);
            CbData.Name = "CbData";
            CbData.Size = new Size(96, 19);
            CbData.TabIndex = 40;
            CbData.Text = "Entrada entre";
            CbData.UseVisualStyleBackColor = true;
            CbData.CheckedChanged += CbData_CheckedChanged;
            // 
            // CbDescricao
            // 
            CbDescricao.AutoSize = true;
            CbDescricao.Location = new Point(651, 132);
            CbDescricao.Name = "CbDescricao";
            CbDescricao.Size = new Size(80, 19);
            CbDescricao.TabIndex = 39;
            CbDescricao.Text = "Descrição:";
            CbDescricao.UseVisualStyleBackColor = true;
            CbDescricao.CheckedChanged += CbDescricao_CheckedChanged;
            // 
            // CbCodigo
            // 
            CbCodigo.AutoSize = true;
            CbCodigo.Location = new Point(651, 103);
            CbCodigo.Name = "CbCodigo";
            CbCodigo.Size = new Size(87, 19);
            CbCodigo.TabIndex = 38;
            CbCodigo.Text = "Nota Fiscal:";
            CbCodigo.UseVisualStyleBackColor = true;
            CbCodigo.CheckedChanged += CbCodigo_CheckedChanged;
            // 
            // LbE
            // 
            LbE.AutoSize = true;
            LbE.Location = new Point(840, 162);
            LbE.Name = "LbE";
            LbE.Size = new Size(23, 15);
            LbE.TabIndex = 37;
            LbE.Text = "até";
            LbE.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TbDescricao
            // 
            TbDescricao.Location = new Point(737, 130);
            TbDescricao.MaxLength = 20;
            TbDescricao.Name = "TbDescricao";
            TbDescricao.PlaceholderText = "Descrição";
            TbDescricao.ReadOnly = true;
            TbDescricao.Size = new Size(212, 23);
            TbDescricao.TabIndex = 36;
            TbDescricao.TextChanged += TbDescricao_TextChanged;
            // 
            // TbCodigo
            // 
            TbCodigo.Location = new Point(744, 101);
            TbCodigo.MaxLength = 20;
            TbCodigo.Name = "TbCodigo";
            TbCodigo.PlaceholderText = "00000000";
            TbCodigo.ReadOnly = true;
            TbCodigo.Size = new Size(205, 23);
            TbCodigo.TabIndex = 34;
            TbCodigo.TextChanged += TbCodigo_TextChanged;
            // 
            // DtDe
            // 
            DtDe.Enabled = false;
            DtDe.Format = DateTimePickerFormat.Short;
            DtDe.Location = new Point(753, 159);
            DtDe.Name = "DtDe";
            DtDe.Size = new Size(80, 23);
            DtDe.TabIndex = 41;
            DtDe.ValueChanged += DtDe_ValueChanged;
            // 
            // DtAte
            // 
            DtAte.Enabled = false;
            DtAte.Format = DateTimePickerFormat.Short;
            DtAte.Location = new Point(869, 160);
            DtAte.Name = "DtAte";
            DtAte.Size = new Size(80, 23);
            DtAte.TabIndex = 42;
            DtAte.ValueChanged += DtAte_ValueChanged;
            // 
            // BtnCriar
            // 
            BtnCriar.Location = new Point(652, 254);
            BtnCriar.Name = "BtnCriar";
            BtnCriar.Size = new Size(298, 23);
            BtnCriar.TabIndex = 43;
            BtnCriar.Text = "&Criar Entrada";
            BtnCriar.UseVisualStyleBackColor = true;
            BtnCriar.Click += BtnCriar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.Enabled = false;
            BtnEditar.Location = new Point(652, 283);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(298, 23);
            BtnEditar.TabIndex = 44;
            BtnEditar.Text = "&Editar Entrada";
            BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Location = new Point(652, 312);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(298, 23);
            BtnExcluir.TabIndex = 45;
            BtnExcluir.Text = "E&xcluir Entrada";
            BtnExcluir.UseVisualStyleBackColor = true;
            BtnExcluir.Click += BtnExcluir_Click;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(644, 195);
            label2.Name = "label2";
            label2.Size = new Size(319, 47);
            label2.TabIndex = 46;
            // 
            // TbNota
            // 
            TbNota.Location = new Point(760, 207);
            TbNota.MaxLength = 20;
            TbNota.Name = "TbNota";
            TbNota.ReadOnly = true;
            TbNota.Size = new Size(190, 23);
            TbNota.TabIndex = 47;
            // 
            // LbNota
            // 
            LbNota.AutoSize = true;
            LbNota.Location = new Point(652, 210);
            LbNota.Name = "LbNota";
            LbNota.Size = new Size(102, 15);
            LbNota.TabIndex = 48;
            LbNota.Text = "Nota Selecionada:";
            // 
            // ManageInbound
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 536);
            Controls.Add(LbNota);
            Controls.Add(TbNota);
            Controls.Add(label2);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnEditar);
            Controls.Add(BtnCriar);
            Controls.Add(DtAte);
            Controls.Add(DtDe);
            Controls.Add(CbData);
            Controls.Add(CbDescricao);
            Controls.Add(CbCodigo);
            Controls.Add(LbE);
            Controls.Add(TbDescricao);
            Controls.Add(TbCodigo);
            Controls.Add(label1);
            Controls.Add(LbFiltro);
            Controls.Add(LbDivisao);
            Controls.Add(DgSubItem);
            Controls.Add(DgItens);
            Controls.Add(LbTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ManageInbound";
            Text = "Gerenciar Entrada de Material";
            Shown += ManageInbound_Shown;
            ((System.ComponentModel.ISupportInitialize)DgItens).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgSubItem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbTitulo;
        private DataGridView DgItens;
        private DataGridView DgSubItem;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Label LbFiltro;
        private Label LbDivisao;
        private Label label1;
        private CheckBox CbData;
        private CheckBox CbDescricao;
        private CheckBox CbCodigo;
        private Label LbE;
        private TextBox TbDescricao;
        private TextBox TbCodigo;
        private DateTimePicker DtDe;
        private DateTimePicker DtAte;
        private Button BtnCriar;
        private Button BtnEditar;
        private Button BtnExcluir;
        private Label label2;
        private TextBox TbNota;
        private Label LbNota;
        private DataGridViewTextBoxColumn CodigoProduto;
        private DataGridViewTextBoxColumn DescProduto;
        private DataGridViewTextBoxColumn Estoque;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn cnpj;
    }
}