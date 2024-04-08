namespace INVT {
    partial class Main {
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
            LbDivisao1 = new Label();
            DgEstoqueBaixo = new DataGridView();
            CodigoProduto = new DataGridViewTextBoxColumn();
            DescricaoPr = new DataGridViewTextBoxColumn();
            EstoqueAtual = new DataGridViewTextBoxColumn();
            EstoqueMinimo = new DataGridViewTextBoxColumn();
            TipoProduto = new DataGridViewTextBoxColumn();
            LbEstoque = new Label();
            BtnEntrada = new Button();
            BtnSaida = new Button();
            BtnInventario = new Button();
            LbDivisao2 = new Label();
            BtnFornecedor = new Button();
            BtnFuncionario = new Button();
            BtnHistEntrada = new Button();
            BtnHistSaida = new Button();
            BtnProdutos = new Button();
            ((System.ComponentModel.ISupportInitialize)DgEstoqueBaixo).BeginInit();
            SuspendLayout();
            // 
            // LbTitulo
            // 
            LbTitulo.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            LbTitulo.Location = new Point(12, 9);
            LbTitulo.Name = "LbTitulo";
            LbTitulo.Size = new Size(852, 62);
            LbTitulo.TabIndex = 0;
            LbTitulo.Text = "Controle de Inventário";
            LbTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LbDivisao1
            // 
            LbDivisao1.BorderStyle = BorderStyle.Fixed3D;
            LbDivisao1.Location = new Point(228, 80);
            LbDivisao1.Name = "LbDivisao1";
            LbDivisao1.Size = new Size(636, 244);
            LbDivisao1.TabIndex = 1;
            // 
            // DgEstoqueBaixo
            // 
            DgEstoqueBaixo.AllowUserToAddRows = false;
            DgEstoqueBaixo.AllowUserToDeleteRows = false;
            DgEstoqueBaixo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgEstoqueBaixo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgEstoqueBaixo.Columns.AddRange(new DataGridViewColumn[] { CodigoProduto, DescricaoPr, EstoqueAtual, EstoqueMinimo, TipoProduto });
            DgEstoqueBaixo.Location = new Point(243, 110);
            DgEstoqueBaixo.MultiSelect = false;
            DgEstoqueBaixo.Name = "DgEstoqueBaixo";
            DgEstoqueBaixo.ReadOnly = true;
            DgEstoqueBaixo.RowTemplate.Height = 25;
            DgEstoqueBaixo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgEstoqueBaixo.Size = new Size(604, 196);
            DgEstoqueBaixo.TabIndex = 2;
            // 
            // CodigoProduto
            // 
            CodigoProduto.HeaderText = "Código";
            CodigoProduto.Name = "CodigoProduto";
            CodigoProduto.ReadOnly = true;
            // 
            // DescricaoPr
            // 
            DescricaoPr.HeaderText = "Descrição";
            DescricaoPr.Name = "DescricaoPr";
            DescricaoPr.ReadOnly = true;
            // 
            // EstoqueAtual
            // 
            EstoqueAtual.HeaderText = "Estoque Atual";
            EstoqueAtual.Name = "EstoqueAtual";
            EstoqueAtual.ReadOnly = true;
            // 
            // EstoqueMinimo
            // 
            EstoqueMinimo.HeaderText = "Estoque Mínimo";
            EstoqueMinimo.Name = "EstoqueMinimo";
            EstoqueMinimo.ReadOnly = true;
            // 
            // TipoProduto
            // 
            TipoProduto.HeaderText = "Tipo do Produto";
            TipoProduto.Name = "TipoProduto";
            TipoProduto.ReadOnly = true;
            // 
            // LbEstoque
            // 
            LbEstoque.AutoSize = true;
            LbEstoque.Location = new Point(243, 92);
            LbEstoque.Name = "LbEstoque";
            LbEstoque.Size = new Size(139, 15);
            LbEstoque.TabIndex = 3;
            LbEstoque.Text = "Itens com Estoque Baixo:";
            // 
            // BtnEntrada
            // 
            BtnEntrada.Location = new Point(22, 92);
            BtnEntrada.Name = "BtnEntrada";
            BtnEntrada.Size = new Size(187, 23);
            BtnEntrada.TabIndex = 4;
            BtnEntrada.Text = "&Entrada de Material";
            BtnEntrada.UseVisualStyleBackColor = true;
            BtnEntrada.Click += BtnEntrada_Click;
            // 
            // BtnSaida
            // 
            BtnSaida.Location = new Point(22, 121);
            BtnSaida.Name = "BtnSaida";
            BtnSaida.Size = new Size(187, 23);
            BtnSaida.TabIndex = 5;
            BtnSaida.Text = "&Saída de Material";
            BtnSaida.UseVisualStyleBackColor = true;
            BtnSaida.Click += BtnSaida_Click;
            // 
            // BtnInventario
            // 
            BtnInventario.Location = new Point(22, 241);
            BtnInventario.Name = "BtnInventario";
            BtnInventario.Size = new Size(187, 23);
            BtnInventario.TabIndex = 8;
            BtnInventario.Text = "Consultar Inventário";
            BtnInventario.UseVisualStyleBackColor = true;
            // 
            // LbDivisao2
            // 
            LbDivisao2.BorderStyle = BorderStyle.Fixed3D;
            LbDivisao2.Location = new Point(12, 80);
            LbDivisao2.Name = "LbDivisao2";
            LbDivisao2.Size = new Size(210, 158);
            LbDivisao2.TabIndex = 9;
            // 
            // BtnFornecedor
            // 
            BtnFornecedor.Location = new Point(22, 150);
            BtnFornecedor.Name = "BtnFornecedor";
            BtnFornecedor.Size = new Size(187, 23);
            BtnFornecedor.TabIndex = 10;
            BtnFornecedor.Text = "&Fornecedores";
            BtnFornecedor.UseVisualStyleBackColor = true;
            BtnFornecedor.Click += BtnFornecedor_Click;
            // 
            // BtnFuncionario
            // 
            BtnFuncionario.Location = new Point(22, 179);
            BtnFuncionario.Name = "BtnFuncionario";
            BtnFuncionario.Size = new Size(187, 23);
            BtnFuncionario.TabIndex = 11;
            BtnFuncionario.Text = "F&uncionários";
            BtnFuncionario.UseVisualStyleBackColor = true;
            BtnFuncionario.Click += BtnFuncionario_Click;
            // 
            // BtnHistEntrada
            // 
            BtnHistEntrada.Location = new Point(22, 270);
            BtnHistEntrada.Name = "BtnHistEntrada";
            BtnHistEntrada.Size = new Size(187, 23);
            BtnHistEntrada.TabIndex = 12;
            BtnHistEntrada.Text = "Consultar Histórico de Entrada";
            BtnHistEntrada.UseVisualStyleBackColor = true;
            // 
            // BtnHistSaida
            // 
            BtnHistSaida.Location = new Point(22, 299);
            BtnHistSaida.Name = "BtnHistSaida";
            BtnHistSaida.Size = new Size(187, 23);
            BtnHistSaida.TabIndex = 13;
            BtnHistSaida.Text = "Consultar Histórico de Saída";
            BtnHistSaida.UseVisualStyleBackColor = true;
            // 
            // BtnProdutos
            // 
            BtnProdutos.Location = new Point(22, 208);
            BtnProdutos.Name = "BtnProdutos";
            BtnProdutos.Size = new Size(187, 23);
            BtnProdutos.TabIndex = 14;
            BtnProdutos.Text = "&Produtos";
            BtnProdutos.UseVisualStyleBackColor = true;
            BtnProdutos.Click += BtnProdutos_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 339);
            Controls.Add(BtnProdutos);
            Controls.Add(BtnHistSaida);
            Controls.Add(BtnHistEntrada);
            Controls.Add(BtnFuncionario);
            Controls.Add(BtnFornecedor);
            Controls.Add(BtnInventario);
            Controls.Add(BtnSaida);
            Controls.Add(BtnEntrada);
            Controls.Add(LbEstoque);
            Controls.Add(DgEstoqueBaixo);
            Controls.Add(LbDivisao1);
            Controls.Add(LbTitulo);
            Controls.Add(LbDivisao2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Main";
            Text = "Controle de Inventário - Menu Principal";
            ((System.ComponentModel.ISupportInitialize)DgEstoqueBaixo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbTitulo;
        private Label LbDivisao1;
        private DataGridView DgEstoqueBaixo;
        private Label LbEstoque;
        private Button BtnEntrada;
        private Button BtnSaida;
        private Button BtnInventario;
        private Label LbDivisao2;
        private Button BtnFornecedor;
        private Button BtnFuncionario;
        private Button BtnHistEntrada;
        private Button BtnHistSaida;
        private Button BtnProdutos;
        private DataGridViewTextBoxColumn CodigoProduto;
        private DataGridViewTextBoxColumn DescricaoPr;
        private DataGridViewTextBoxColumn EstoqueAtual;
        private DataGridViewTextBoxColumn EstoqueMinimo;
        private DataGridViewTextBoxColumn TipoProduto;
    }
}