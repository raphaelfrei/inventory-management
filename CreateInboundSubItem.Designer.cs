namespace INVT {
    partial class CreateInboundSubItem {
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
            TbFiltro = new TextBox();
            LbProcurar = new Label();
            CodigoProduto = new DataGridViewTextBoxColumn();
            DescProduto = new DataGridViewTextBoxColumn();
            CodProduto = new DataGridViewTextBoxColumn();
            DcProduto = new DataGridViewTextBoxColumn();
            DgItens = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            preco = new DataGridViewTextBoxColumn();
            BtnSalvar = new Button();
            BtnCancelar = new Button();
            DgvSubItem = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            PrecoVenda = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BtnItem = new Button();
            ((System.ComponentModel.ISupportInitialize)DgItens).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvSubItem).BeginInit();
            SuspendLayout();
            // 
            // LbTitulo
            // 
            LbTitulo.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            LbTitulo.Location = new Point(12, 9);
            LbTitulo.Name = "LbTitulo";
            LbTitulo.Size = new Size(468, 62);
            LbTitulo.TabIndex = 2;
            LbTitulo.Text = "Adicionar Item";
            LbTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LbDivisao
            // 
            LbDivisao.BorderStyle = BorderStyle.Fixed3D;
            LbDivisao.Location = new Point(12, 82);
            LbDivisao.Name = "LbDivisao";
            LbDivisao.Size = new Size(468, 198);
            LbDivisao.TabIndex = 16;
            // 
            // TbFiltro
            // 
            TbFiltro.Location = new Point(87, 92);
            TbFiltro.MaxLength = 20;
            TbFiltro.Name = "TbFiltro";
            TbFiltro.PlaceholderText = "Código ou Descrição";
            TbFiltro.Size = new Size(377, 23);
            TbFiltro.TabIndex = 18;
            TbFiltro.TextChanged += TbFiltro_TextChanged;
            // 
            // LbProcurar
            // 
            LbProcurar.AutoSize = true;
            LbProcurar.Location = new Point(26, 95);
            LbProcurar.Name = "LbProcurar";
            LbProcurar.Size = new Size(55, 15);
            LbProcurar.TabIndex = 17;
            LbProcurar.Text = "Procurar:";
            LbProcurar.TextAlign = ContentAlignment.MiddleRight;
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
            // CodProduto
            // 
            CodProduto.HeaderText = "Código do Produto";
            CodProduto.Name = "CodProduto";
            CodProduto.ReadOnly = true;
            // 
            // DcProduto
            // 
            DcProduto.HeaderText = "Descrição do Produto";
            DcProduto.Name = "DcProduto";
            DcProduto.ReadOnly = true;
            // 
            // DgItens
            // 
            DgItens.AllowUserToAddRows = false;
            DgItens.AllowUserToDeleteRows = false;
            DgItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgItens.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, preco });
            DgItens.Location = new Point(26, 121);
            DgItens.MultiSelect = false;
            DgItens.Name = "DgItens";
            DgItens.ReadOnly = true;
            DgItens.RowTemplate.Height = 25;
            DgItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgItens.Size = new Size(438, 120);
            DgItens.TabIndex = 20;
            DgItens.CellClick += DgItens_CellClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Código do Produto";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Descrição do Produto";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // preco
            // 
            preco.HeaderText = "preco";
            preco.Name = "preco";
            preco.ReadOnly = true;
            preco.Visible = false;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(405, 473);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(75, 23);
            BtnSalvar.TabIndex = 27;
            BtnSalvar.Text = "&Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(324, 473);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 23);
            BtnCancelar.TabIndex = 28;
            BtnCancelar.Text = "&Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // DgvSubItem
            // 
            DgvSubItem.AllowUserToAddRows = false;
            DgvSubItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvSubItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvSubItem.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, Quantidade, PrecoVenda });
            DgvSubItem.Location = new Point(26, 303);
            DgvSubItem.MultiSelect = false;
            DgvSubItem.Name = "DgvSubItem";
            DgvSubItem.RowTemplate.Height = 25;
            DgvSubItem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvSubItem.Size = new Size(441, 133);
            DgvSubItem.TabIndex = 77;
            DgvSubItem.RowsRemoved += DgvSubItem_RowsRemoved;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Código";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Descrição";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Quantidade
            // 
            Quantidade.HeaderText = "Quantidade";
            Quantidade.Name = "Quantidade";
            // 
            // PrecoVenda
            // 
            PrecoVenda.HeaderText = "Preco";
            PrecoVenda.Name = "PrecoVenda";
            PrecoVenda.Visible = false;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(12, 280);
            label1.Name = "label1";
            label1.Size = new Size(468, 183);
            label1.TabIndex = 78;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 274);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 79;
            label2.Text = "Itens adicionados:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(26, 439);
            label3.Name = "label3";
            label3.Size = new Size(188, 12);
            label3.TabIndex = 80;
            label3.Text = "* Para remover, selecione e aperte DELETE";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BtnItem
            // 
            BtnItem.Location = new Point(26, 247);
            BtnItem.Name = "BtnItem";
            BtnItem.Size = new Size(438, 23);
            BtnItem.TabIndex = 81;
            BtnItem.Text = "&Adicionar Item";
            BtnItem.UseVisualStyleBackColor = true;
            BtnItem.Click += BtnItem_Click;
            // 
            // CreateInboundSubItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 513);
            Controls.Add(BtnItem);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(DgvSubItem);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnSalvar);
            Controls.Add(DgItens);
            Controls.Add(TbFiltro);
            Controls.Add(LbProcurar);
            Controls.Add(LbDivisao);
            Controls.Add(LbTitulo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CreateInboundSubItem";
            Text = "Adicionar Produto";
            Shown += CreateInboundSubItem_Shown;
            ((System.ComponentModel.ISupportInitialize)DgItens).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvSubItem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbTitulo;
        private Label LbDivisao;
        private TextBox TbFiltro;
        private Label LbProcurar;
        private DataGridViewTextBoxColumn CodigoProduto;
        private DataGridViewTextBoxColumn DescProduto;
        private DataGridViewTextBoxColumn CodProduto;
        private DataGridViewTextBoxColumn DcProduto;
        private DataGridView DgItens;
        private Button BtnSalvar;
        private Button BtnCancelar;
        private DataGridView DgvSubItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button BtnItem;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn preco;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn PrecoVenda;
    }
}