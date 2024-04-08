namespace INVT {
    partial class SelectEmployee {
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
            DgItens = new DataGridView();
            RE = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Setor = new DataGridViewTextBoxColumn();
            LbDivisao = new Label();
            LbTitulo = new Label();
            TbFiltro = new TextBox();
            label1 = new Label();
            BtnCriarFunc = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TbRE = new TextBox();
            TbNome = new TextBox();
            TbSetor = new TextBox();
            BtnCancelar = new Button();
            BtnSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)DgItens).BeginInit();
            SuspendLayout();
            // 
            // DgItens
            // 
            DgItens.AllowUserToAddRows = false;
            DgItens.AllowUserToDeleteRows = false;
            DgItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgItens.Columns.AddRange(new DataGridViewColumn[] { RE, Nome, Setor });
            DgItens.Location = new Point(21, 137);
            DgItens.MultiSelect = false;
            DgItens.Name = "DgItens";
            DgItens.RowTemplate.Height = 25;
            DgItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgItens.Size = new Size(443, 155);
            DgItens.TabIndex = 19;
            DgItens.CellClick += DgItens_CellClick;
            DgItens.CellContentDoubleClick += DgItens_CellContentDoubleClick;
            // 
            // RE
            // 
            RE.HeaderText = "RE";
            RE.Name = "RE";
            RE.ReadOnly = true;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // Setor
            // 
            Setor.HeaderText = "Setor";
            Setor.Name = "Setor";
            Setor.ReadOnly = true;
            // 
            // LbDivisao
            // 
            LbDivisao.BorderStyle = BorderStyle.Fixed3D;
            LbDivisao.Location = new Point(12, 88);
            LbDivisao.Name = "LbDivisao";
            LbDivisao.Size = new Size(464, 247);
            LbDivisao.TabIndex = 18;
            // 
            // LbTitulo
            // 
            LbTitulo.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            LbTitulo.Location = new Point(12, 9);
            LbTitulo.Name = "LbTitulo";
            LbTitulo.Size = new Size(463, 62);
            LbTitulo.TabIndex = 20;
            LbTitulo.Text = "Buscar Funcionário";
            LbTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TbFiltro
            // 
            TbFiltro.Location = new Point(64, 97);
            TbFiltro.MaxLength = 20;
            TbFiltro.Name = "TbFiltro";
            TbFiltro.PlaceholderText = "RE ou nome";
            TbFiltro.Size = new Size(400, 23);
            TbFiltro.TabIndex = 70;
            TbFiltro.TextChanged += TbFiltro_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 100);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 71;
            label1.Text = "Filtro:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BtnCriarFunc
            // 
            BtnCriarFunc.Location = new Point(119, 345);
            BtnCriarFunc.Name = "BtnCriarFunc";
            BtnCriarFunc.Size = new Size(345, 23);
            BtnCriarFunc.TabIndex = 72;
            BtnCriarFunc.Text = "&Criar Funcionário";
            BtnCriarFunc.UseVisualStyleBackColor = true;
            BtnCriarFunc.Click += BtnCriarFunc_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 349);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 73;
            label2.Text = "Não encontrou?";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(12, 335);
            label3.Name = "label3";
            label3.Size = new Size(464, 43);
            label3.TabIndex = 74;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 301);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 76;
            label4.Text = "Selecionado:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TbRE
            // 
            TbRE.Location = new Point(101, 298);
            TbRE.MaxLength = 20;
            TbRE.Name = "TbRE";
            TbRE.ReadOnly = true;
            TbRE.Size = new Size(74, 23);
            TbRE.TabIndex = 75;
            // 
            // TbNome
            // 
            TbNome.Location = new Point(172, 298);
            TbNome.MaxLength = 20;
            TbNome.Name = "TbNome";
            TbNome.ReadOnly = true;
            TbNome.Size = new Size(173, 23);
            TbNome.TabIndex = 77;
            // 
            // TbSetor
            // 
            TbSetor.Location = new Point(344, 298);
            TbSetor.MaxLength = 20;
            TbSetor.Name = "TbSetor";
            TbSetor.ReadOnly = true;
            TbSetor.Size = new Size(120, 23);
            TbSetor.TabIndex = 78;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(263, 390);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(103, 23);
            BtnCancelar.TabIndex = 80;
            BtnCancelar.Text = "&Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(372, 390);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(103, 23);
            BtnSalvar.TabIndex = 79;
            BtnSalvar.Text = "&Salvar e Fechar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // SelectEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 428);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnSalvar);
            Controls.Add(TbSetor);
            Controls.Add(TbNome);
            Controls.Add(label4);
            Controls.Add(TbRE);
            Controls.Add(label2);
            Controls.Add(BtnCriarFunc);
            Controls.Add(label1);
            Controls.Add(TbFiltro);
            Controls.Add(LbTitulo);
            Controls.Add(DgItens);
            Controls.Add(LbDivisao);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SelectEmployee";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Buscar Funcionário";
            Shown += SelectEmployee_Shown;
            ((System.ComponentModel.ISupportInitialize)DgItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgItens;
        private DataGridViewTextBoxColumn RE;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Setor;
        private Label LbDivisao;
        private Label LbTitulo;
        private TextBox TbFiltro;
        private Label label1;
        private Button BtnCriarFunc;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TbRE;
        private TextBox TbNome;
        private TextBox TbSetor;
        private Button BtnCancelar;
        private Button BtnSalvar;
    }
}