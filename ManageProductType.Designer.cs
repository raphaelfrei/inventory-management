namespace INVT {
    partial class ManageProductType {
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
            label1 = new Label();
            label2 = new Label();
            LbSelecionado = new Label();
            TbSelecionado = new TextBox();
            LbInformacoes = new Label();
            BtnCriar = new Button();
            BtnEditar = new Button();
            BtnDeletar = new Button();
            CbDescricao = new CheckBox();
            CbCodigo = new CheckBox();
            TbDescricao = new TextBox();
            TbCodigo = new TextBox();
            LbFiltro = new Label();
            ((System.ComponentModel.ISupportInitialize)DgItens).BeginInit();
            SuspendLayout();
            // 
            // LbTitulo
            // 
            LbTitulo.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            LbTitulo.Location = new Point(12, 9);
            LbTitulo.Name = "LbTitulo";
            LbTitulo.Size = new Size(634, 62);
            LbTitulo.TabIndex = 2;
            LbTitulo.Text = "Gerenciar Tipos de Produtos";
            LbTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DgItens
            // 
            DgItens.AllowUserToAddRows = false;
            DgItens.AllowUserToDeleteRows = false;
            DgItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgItens.Columns.AddRange(new DataGridViewColumn[] { CodigoProduto, DescProduto });
            DgItens.Location = new Point(12, 85);
            DgItens.MultiSelect = false;
            DgItens.Name = "DgItens";
            DgItens.ReadOnly = true;
            DgItens.RowTemplate.Height = 25;
            DgItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgItens.Size = new Size(391, 271);
            DgItens.TabIndex = 18;
            DgItens.CellClick += DgItens_CellClick;
            // 
            // CodigoProduto
            // 
            CodigoProduto.HeaderText = "Código";
            CodigoProduto.Name = "CodigoProduto";
            CodigoProduto.ReadOnly = true;
            // 
            // DescProduto
            // 
            DescProduto.HeaderText = "Descrição";
            DescProduto.Name = "DescProduto";
            DescProduto.ReadOnly = true;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(409, 85);
            label1.Name = "label1";
            label1.Size = new Size(237, 85);
            label1.TabIndex = 35;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(409, 170);
            label2.Name = "label2";
            label2.Size = new Size(237, 130);
            label2.TabIndex = 36;
            // 
            // LbSelecionado
            // 
            LbSelecionado.AutoSize = true;
            LbSelecionado.Location = new Point(418, 211);
            LbSelecionado.Name = "LbSelecionado";
            LbSelecionado.Size = new Size(74, 15);
            LbSelecionado.TabIndex = 40;
            LbSelecionado.Text = "Selecionado:";
            // 
            // TbSelecionado
            // 
            TbSelecionado.Location = new Point(498, 208);
            TbSelecionado.MaxLength = 20;
            TbSelecionado.Name = "TbSelecionado";
            TbSelecionado.ReadOnly = true;
            TbSelecionado.Size = new Size(136, 23);
            TbSelecionado.TabIndex = 39;
            // 
            // LbInformacoes
            // 
            LbInformacoes.AutoSize = true;
            LbInformacoes.Location = new Point(418, 180);
            LbInformacoes.Name = "LbInformacoes";
            LbInformacoes.Size = new Size(76, 15);
            LbInformacoes.TabIndex = 38;
            LbInformacoes.Text = "Informações:";
            // 
            // BtnCriar
            // 
            BtnCriar.Location = new Point(418, 314);
            BtnCriar.Name = "BtnCriar";
            BtnCriar.Size = new Size(216, 23);
            BtnCriar.TabIndex = 43;
            BtnCriar.Text = "&Criar Tipo";
            BtnCriar.UseVisualStyleBackColor = true;
            BtnCriar.Click += BtnCriar_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.Location = new Point(418, 266);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(216, 23);
            BtnEditar.TabIndex = 42;
            BtnEditar.Text = "&Editar Tipo";
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnDeletar
            // 
            BtnDeletar.Enabled = false;
            BtnDeletar.Location = new Point(418, 237);
            BtnDeletar.Name = "BtnDeletar";
            BtnDeletar.Size = new Size(216, 23);
            BtnDeletar.TabIndex = 41;
            BtnDeletar.Text = "&Deletar Tipo";
            BtnDeletar.UseVisualStyleBackColor = true;
            // 
            // CbDescricao
            // 
            CbDescricao.AutoSize = true;
            CbDescricao.Location = new Point(418, 132);
            CbDescricao.Name = "CbDescricao";
            CbDescricao.Size = new Size(80, 19);
            CbDescricao.TabIndex = 48;
            CbDescricao.Text = "Descrição:";
            CbDescricao.UseVisualStyleBackColor = true;
            // 
            // CbCodigo
            // 
            CbCodigo.AutoSize = true;
            CbCodigo.Location = new Point(418, 103);
            CbCodigo.Name = "CbCodigo";
            CbCodigo.Size = new Size(68, 19);
            CbCodigo.TabIndex = 47;
            CbCodigo.Text = "Código:";
            CbCodigo.UseVisualStyleBackColor = true;
            // 
            // TbDescricao
            // 
            TbDescricao.Location = new Point(504, 130);
            TbDescricao.MaxLength = 20;
            TbDescricao.Name = "TbDescricao";
            TbDescricao.PlaceholderText = "Código";
            TbDescricao.ReadOnly = true;
            TbDescricao.Size = new Size(130, 23);
            TbDescricao.TabIndex = 46;
            // 
            // TbCodigo
            // 
            TbCodigo.Location = new Point(492, 101);
            TbCodigo.MaxLength = 20;
            TbCodigo.Name = "TbCodigo";
            TbCodigo.PlaceholderText = "0";
            TbCodigo.ReadOnly = true;
            TbCodigo.Size = new Size(142, 23);
            TbCodigo.TabIndex = 45;
            // 
            // LbFiltro
            // 
            LbFiltro.AutoSize = true;
            LbFiltro.Location = new Point(418, 80);
            LbFiltro.Name = "LbFiltro";
            LbFiltro.Size = new Size(40, 15);
            LbFiltro.TabIndex = 44;
            LbFiltro.Text = "Filtrar:";
            // 
            // ManageProductType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 370);
            Controls.Add(CbDescricao);
            Controls.Add(CbCodigo);
            Controls.Add(TbDescricao);
            Controls.Add(TbCodigo);
            Controls.Add(LbFiltro);
            Controls.Add(BtnCriar);
            Controls.Add(BtnEditar);
            Controls.Add(BtnDeletar);
            Controls.Add(LbSelecionado);
            Controls.Add(TbSelecionado);
            Controls.Add(LbInformacoes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DgItens);
            Controls.Add(LbTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ManageProductType";
            Text = "Gerenciar Tipos de Produtos";
            ((System.ComponentModel.ISupportInitialize)DgItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbTitulo;
        private DataGridView DgItens;
        private DataGridViewTextBoxColumn CodigoProduto;
        private DataGridViewTextBoxColumn DescProduto;
        private Label label1;
        private Label label2;
        private Label LbSelecionado;
        private TextBox TbSelecionado;
        private Label LbInformacoes;
        private Button BtnCriar;
        private Button BtnEditar;
        private Button BtnDeletar;
        private CheckBox CbDescricao;
        private CheckBox CbCodigo;
        private TextBox TbDescricao;
        private TextBox TbCodigo;
        private Label LbFiltro;
    }
}