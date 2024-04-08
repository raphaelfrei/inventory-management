namespace INVT {
    partial class ManageSupplier {
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
            NomeForn = new DataGridViewTextBoxColumn();
            CNPJForn = new DataGridViewTextBoxColumn();
            EmailForn = new DataGridViewTextBoxColumn();
            LbFiltro = new Label();
            LbDivisao = new Label();
            CbDescricao = new CheckBox();
            CbCodigo = new CheckBox();
            TbDescricao = new TextBox();
            TbCodigo = new TextBox();
            LbNota = new Label();
            TbNota = new TextBox();
            label2 = new Label();
            BtnEditar = new Button();
            BtnCriar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgItens).BeginInit();
            SuspendLayout();
            // 
            // LbTitulo
            // 
            LbTitulo.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            LbTitulo.Location = new Point(12, 9);
            LbTitulo.Name = "LbTitulo";
            LbTitulo.Size = new Size(969, 62);
            LbTitulo.TabIndex = 3;
            LbTitulo.Text = "Gerenciar Fornecedores";
            LbTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DgItens
            // 
            DgItens.AllowUserToAddRows = false;
            DgItens.AllowUserToDeleteRows = false;
            DgItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgItens.Columns.AddRange(new DataGridViewColumn[] { NomeForn, CNPJForn, EmailForn });
            DgItens.Location = new Point(12, 87);
            DgItens.MultiSelect = false;
            DgItens.Name = "DgItens";
            DgItens.ReadOnly = true;
            DgItens.RowTemplate.Height = 25;
            DgItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgItens.Size = new Size(644, 214);
            DgItens.TabIndex = 19;
            DgItens.CellClick += DgItens_CellClick;
            // 
            // NomeForn
            // 
            NomeForn.HeaderText = "Nome";
            NomeForn.Name = "NomeForn";
            NomeForn.ReadOnly = true;
            // 
            // CNPJForn
            // 
            CNPJForn.HeaderText = "CNPJ";
            CNPJForn.Name = "CNPJForn";
            CNPJForn.ReadOnly = true;
            // 
            // EmailForn
            // 
            EmailForn.HeaderText = "Email de Contato";
            EmailForn.Name = "EmailForn";
            EmailForn.ReadOnly = true;
            // 
            // LbFiltro
            // 
            LbFiltro.AutoSize = true;
            LbFiltro.Location = new Point(671, 79);
            LbFiltro.Name = "LbFiltro";
            LbFiltro.Size = new Size(40, 15);
            LbFiltro.TabIndex = 23;
            LbFiltro.Text = "Filtrar:";
            // 
            // LbDivisao
            // 
            LbDivisao.BorderStyle = BorderStyle.Fixed3D;
            LbDivisao.Location = new Point(662, 87);
            LbDivisao.Name = "LbDivisao";
            LbDivisao.Size = new Size(319, 88);
            LbDivisao.TabIndex = 22;
            // 
            // CbDescricao
            // 
            CbDescricao.AutoSize = true;
            CbDescricao.Location = new Point(673, 136);
            CbDescricao.Name = "CbDescricao";
            CbDescricao.Size = new Size(56, 19);
            CbDescricao.TabIndex = 43;
            CbDescricao.Text = "CNPJ:";
            CbDescricao.UseVisualStyleBackColor = true;
            CbDescricao.CheckedChanged += CbDescricao_CheckedChanged;
            // 
            // CbCodigo
            // 
            CbCodigo.AutoSize = true;
            CbCodigo.Location = new Point(673, 107);
            CbCodigo.Name = "CbCodigo";
            CbCodigo.Size = new Size(62, 19);
            CbCodigo.TabIndex = 42;
            CbCodigo.Text = "Nome:";
            CbCodigo.UseVisualStyleBackColor = true;
            CbCodigo.CheckedChanged += CbCodigo_CheckedChanged;
            // 
            // TbDescricao
            // 
            TbDescricao.Location = new Point(735, 134);
            TbDescricao.MaxLength = 20;
            TbDescricao.Name = "TbDescricao";
            TbDescricao.PlaceholderText = "CNPJ da Empresa";
            TbDescricao.ReadOnly = true;
            TbDescricao.Size = new Size(236, 23);
            TbDescricao.TabIndex = 41;
            TbDescricao.TextChanged += TbDescricao_TextChanged;
            // 
            // TbCodigo
            // 
            TbCodigo.Location = new Point(741, 105);
            TbCodigo.MaxLength = 20;
            TbCodigo.Name = "TbCodigo";
            TbCodigo.PlaceholderText = "Nome";
            TbCodigo.ReadOnly = true;
            TbCodigo.Size = new Size(230, 23);
            TbCodigo.TabIndex = 40;
            TbCodigo.TextChanged += TbCodigo_TextChanged;
            // 
            // LbNota
            // 
            LbNota.AutoSize = true;
            LbNota.Location = new Point(670, 190);
            LbNota.Name = "LbNota";
            LbNota.Size = new Size(104, 15);
            LbNota.TabIndex = 51;
            LbNota.Text = "CNPJ Selecionado:";
            // 
            // TbNota
            // 
            TbNota.Location = new Point(778, 187);
            TbNota.MaxLength = 20;
            TbNota.Name = "TbNota";
            TbNota.ReadOnly = true;
            TbNota.Size = new Size(190, 23);
            TbNota.TabIndex = 50;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(662, 175);
            label2.Name = "label2";
            label2.Size = new Size(319, 47);
            label2.TabIndex = 49;
            // 
            // BtnEditar
            // 
            BtnEditar.Enabled = false;
            BtnEditar.Location = new Point(670, 263);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(298, 23);
            BtnEditar.TabIndex = 54;
            BtnEditar.Text = "&Editar Fornecedor";
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnCriar
            // 
            BtnCriar.Location = new Point(670, 234);
            BtnCriar.Name = "BtnCriar";
            BtnCriar.Size = new Size(298, 23);
            BtnCriar.TabIndex = 53;
            BtnCriar.Text = "&Criar Fornecedor";
            BtnCriar.UseVisualStyleBackColor = true;
            BtnCriar.Click += BtnCriar_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(662, 222);
            label1.Name = "label1";
            label1.Size = new Size(319, 79);
            label1.TabIndex = 52;
            // 
            // ManageSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 318);
            Controls.Add(BtnEditar);
            Controls.Add(BtnCriar);
            Controls.Add(label1);
            Controls.Add(LbNota);
            Controls.Add(TbNota);
            Controls.Add(label2);
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
            Name = "ManageSupplier";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gerenciar Fornecedores";
            ((System.ComponentModel.ISupportInitialize)DgItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbTitulo;
        private DataGridView DgItens;
        private DataGridViewTextBoxColumn NomeForn;
        private DataGridViewTextBoxColumn CNPJForn;
        private DataGridViewTextBoxColumn EmailForn;
        private Label LbFiltro;
        private Label LbDivisao;
        private CheckBox CbDescricao;
        private CheckBox CbCodigo;
        private TextBox TbDescricao;
        private TextBox TbCodigo;
        private Label LbNota;
        private TextBox TbNota;
        private Label label2;
        private Button BtnEditar;
        private Button BtnCriar;
        private Label label1;
    }
}