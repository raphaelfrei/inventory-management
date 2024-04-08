namespace INVT {
    partial class CreateOutbound {
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
            DtCompra = new DateTimePicker();
            LbDataRet = new Label();
            TbNome = new TextBox();
            TbDepto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BtnFunc = new Button();
            label5 = new Label();
            label6 = new Label();
            BtnProduto = new Button();
            BtnCancelar = new Button();
            BtnSalvar = new Button();
            DgItens = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            Preco = new DataGridViewTextBoxColumn();
            label7 = new Label();
            TbCodigoBarras = new TextBox();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgItens).BeginInit();
            SuspendLayout();
            // 
            // LbTitulo
            // 
            LbTitulo.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            LbTitulo.Location = new Point(12, 9);
            LbTitulo.Name = "LbTitulo";
            LbTitulo.Size = new Size(463, 62);
            LbTitulo.TabIndex = 2;
            LbTitulo.Text = "Saída de Material";
            LbTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DtCompra
            // 
            DtCompra.Format = DateTimePickerFormat.Short;
            DtCompra.Location = new Point(117, 88);
            DtCompra.Name = "DtCompra";
            DtCompra.Size = new Size(103, 23);
            DtCompra.TabIndex = 6;
            // 
            // LbDataRet
            // 
            LbDataRet.AutoSize = true;
            LbDataRet.Location = new Point(15, 91);
            LbDataRet.Name = "LbDataRet";
            LbDataRet.Size = new Size(96, 15);
            LbDataRet.TabIndex = 5;
            LbDataRet.Text = "Data de Retirada:";
            LbDataRet.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TbNome
            // 
            TbNome.Location = new Point(71, 144);
            TbNome.MaxLength = 20;
            TbNome.Name = "TbNome";
            TbNome.ReadOnly = true;
            TbNome.Size = new Size(392, 23);
            TbNome.TabIndex = 19;
            // 
            // TbDepto
            // 
            TbDepto.Location = new Point(114, 173);
            TbDepto.MaxLength = 20;
            TbDepto.Name = "TbDepto";
            TbDepto.ReadOnly = true;
            TbDepto.Size = new Size(349, 23);
            TbDepto.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 147);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 22;
            label1.Text = "Nome:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 176);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 23;
            label2.Text = "Departamento:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(12, 127);
            label3.Name = "label3";
            label3.Size = new Size(463, 110);
            label3.TabIndex = 64;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 119);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 65;
            label4.Text = "Funcionário:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BtnFunc
            // 
            BtnFunc.Location = new Point(22, 202);
            BtnFunc.Name = "BtnFunc";
            BtnFunc.Size = new Size(441, 23);
            BtnFunc.TabIndex = 66;
            BtnFunc.Text = "&Buscar Funcionário";
            BtnFunc.UseVisualStyleBackColor = true;
            BtnFunc.Click += BtnFunc_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 229);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 68;
            label5.Text = "Produtos:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Location = new Point(12, 237);
            label6.Name = "label6";
            label6.Size = new Size(463, 254);
            label6.TabIndex = 67;
            // 
            // BtnProduto
            // 
            BtnProduto.Location = new Point(22, 445);
            BtnProduto.Name = "BtnProduto";
            BtnProduto.Size = new Size(441, 23);
            BtnProduto.TabIndex = 72;
            BtnProduto.Text = "Buscar &Produto";
            BtnProduto.UseVisualStyleBackColor = true;
            BtnProduto.Click += BtnProduto_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(263, 499);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(103, 23);
            BtnCancelar.TabIndex = 75;
            BtnCancelar.Text = "&Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(372, 499);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(103, 23);
            BtnSalvar.TabIndex = 74;
            BtnSalvar.Text = "&Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // DgItens
            // 
            DgItens.AllowUserToAddRows = false;
            DgItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgItens.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, Quantidade, Preco });
            DgItens.Location = new Point(22, 247);
            DgItens.MultiSelect = false;
            DgItens.Name = "DgItens";
            DgItens.RowTemplate.Height = 25;
            DgItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgItens.Size = new Size(441, 133);
            DgItens.TabIndex = 76;
            DgItens.RowsRemoved += DgItens_RowsRemoved;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Código";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Quantidade
            // 
            Quantidade.HeaderText = "Quantidade";
            Quantidade.Name = "Quantidade";
            // 
            // Preco
            // 
            Preco.HeaderText = "Preco";
            Preco.Name = "Preco";
            Preco.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(22, 471);
            label7.Name = "label7";
            label7.Size = new Size(389, 12);
            label7.TabIndex = 81;
            label7.Text = "* Para remover, selecione e aperte DELETE - Para editar a quantidade, clique duas vezes.";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TbCodigoBarras
            // 
            TbCodigoBarras.Location = new Point(22, 401);
            TbCodigoBarras.MaxLength = 20;
            TbCodigoBarras.Name = "TbCodigoBarras";
            TbCodigoBarras.PlaceholderText = "Enter para pesquisar";
            TbCodigoBarras.Size = new Size(441, 23);
            TbCodigoBarras.TabIndex = 82;
            TbCodigoBarras.TextChanged += TbCodigoBarras_TextChanged;
            TbCodigoBarras.KeyPress += TbCodigoBarras_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 383);
            label8.Name = "label8";
            label8.Size = new Size(100, 15);
            label8.TabIndex = 83;
            label8.Text = "Código de Barras:";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Location = new Point(22, 427);
            label9.Name = "label9";
            label9.Size = new Size(441, 15);
            label9.TabIndex = 84;
            label9.Text = "ou";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CreateOutbound
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 536);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(TbCodigoBarras);
            Controls.Add(label7);
            Controls.Add(DgItens);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnSalvar);
            Controls.Add(BtnProduto);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(BtnFunc);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TbDepto);
            Controls.Add(TbNome);
            Controls.Add(DtCompra);
            Controls.Add(LbDataRet);
            Controls.Add(LbTitulo);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CreateOutbound";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Criar Saída de Material";
            ((System.ComponentModel.ISupportInitialize)DgItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbTitulo;
        private DateTimePicker DtCompra;
        private Label LbDataRet;
        private TextBox TbNome;
        private TextBox TbDepto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BtnFunc;
        private Label label5;
        private Label label6;
        private Button BtnProduto;
        private Button BtnCancelar;
        private Button BtnSalvar;
        private DataGridView DgItens;
        private Label label7;
        private TextBox TbCodigoBarras;
        private Label label8;
        private Label label9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Preco;
    }
}