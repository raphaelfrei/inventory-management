namespace INVT {
    partial class ManageEmployee {
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
            LbID = new Label();
            TbRE = new TextBox();
            BtnExcluir = new Button();
            BtnEditar = new Button();
            BtnCriar = new Button();
            CbUsuario = new CheckBox();
            TbCodigo = new TextBox();
            label1 = new Label();
            LbFiltro = new Label();
            LbDivisao = new Label();
            DgItens = new DataGridView();
            RE = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Depto = new DataGridViewTextBoxColumn();
            LbTitulo = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)DgItens).BeginInit();
            SuspendLayout();
            // 
            // LbID
            // 
            LbID.AutoSize = true;
            LbID.Location = new Point(652, 153);
            LbID.Name = "LbID";
            LbID.Size = new Size(88, 15);
            LbID.TabIndex = 77;
            LbID.Text = "ID Selecionado:";
            // 
            // TbRE
            // 
            TbRE.Location = new Point(760, 150);
            TbRE.MaxLength = 20;
            TbRE.Name = "TbRE";
            TbRE.ReadOnly = true;
            TbRE.Size = new Size(174, 23);
            TbRE.TabIndex = 76;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Enabled = false;
            BtnExcluir.Location = new Point(651, 256);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(282, 23);
            BtnExcluir.TabIndex = 75;
            BtnExcluir.Text = "E&xcluir Funcionário";
            BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnEditar
            // 
            BtnEditar.Enabled = false;
            BtnEditar.Location = new Point(651, 227);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(282, 23);
            BtnEditar.TabIndex = 74;
            BtnEditar.Text = "&Editar Funcionário";
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnCriar
            // 
            BtnCriar.Location = new Point(651, 198);
            BtnCriar.Name = "BtnCriar";
            BtnCriar.Size = new Size(282, 23);
            BtnCriar.TabIndex = 73;
            BtnCriar.Text = "&Criar Funcionário";
            BtnCriar.UseVisualStyleBackColor = true;
            BtnCriar.Click += BtnCriar_Click;
            // 
            // CbUsuario
            // 
            CbUsuario.AutoSize = true;
            CbUsuario.Location = new Point(651, 98);
            CbUsuario.Name = "CbUsuario";
            CbUsuario.Size = new Size(87, 19);
            CbUsuario.TabIndex = 72;
            CbUsuario.Text = "Usuário/RE:";
            CbUsuario.UseVisualStyleBackColor = true;
            CbUsuario.CheckedChanged += CbUsuario_CheckedChanged;
            // 
            // TbCodigo
            // 
            TbCodigo.Location = new Point(741, 96);
            TbCodigo.MaxLength = 20;
            TbCodigo.Name = "TbCodigo";
            TbCodigo.PlaceholderText = "Nome ou RE";
            TbCodigo.ReadOnly = true;
            TbCodigo.Size = new Size(193, 23);
            TbCodigo.TabIndex = 71;
            TbCodigo.TextChanged += TbCodigo_TextChanged;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(643, 186);
            label1.Name = "label1";
            label1.Size = new Size(300, 105);
            label1.TabIndex = 70;
            // 
            // LbFiltro
            // 
            LbFiltro.AutoSize = true;
            LbFiltro.Location = new Point(652, 72);
            LbFiltro.Name = "LbFiltro";
            LbFiltro.Size = new Size(40, 15);
            LbFiltro.TabIndex = 69;
            LbFiltro.Text = "Filtrar:";
            // 
            // LbDivisao
            // 
            LbDivisao.BorderStyle = BorderStyle.Fixed3D;
            LbDivisao.Location = new Point(644, 80);
            LbDivisao.Name = "LbDivisao";
            LbDivisao.Size = new Size(300, 53);
            LbDivisao.TabIndex = 68;
            // 
            // DgItens
            // 
            DgItens.AllowUserToAddRows = false;
            DgItens.AllowUserToDeleteRows = false;
            DgItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgItens.Columns.AddRange(new DataGridViewColumn[] { RE, Nome, Depto });
            DgItens.Location = new Point(12, 80);
            DgItens.MultiSelect = false;
            DgItens.Name = "DgItens";
            DgItens.ReadOnly = true;
            DgItens.RowTemplate.Height = 25;
            DgItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgItens.Size = new Size(625, 259);
            DgItens.TabIndex = 67;
            DgItens.CellClick += DgItens_CellClick;
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
            // Depto
            // 
            Depto.HeaderText = "Departamento";
            Depto.Name = "Depto";
            Depto.ReadOnly = true;
            // 
            // LbTitulo
            // 
            LbTitulo.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            LbTitulo.Location = new Point(12, 10);
            LbTitulo.Name = "LbTitulo";
            LbTitulo.Size = new Size(931, 62);
            LbTitulo.TabIndex = 66;
            LbTitulo.Text = "Gerenciar Funcionários";
            LbTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(643, 133);
            label2.Name = "label2";
            label2.Size = new Size(300, 53);
            label2.TabIndex = 78;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(644, 291);
            label3.Name = "label3";
            label3.Size = new Size(300, 48);
            label3.TabIndex = 79;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(651, 303);
            button1.Name = "button1";
            button1.Size = new Size(282, 23);
            button1.TabIndex = 80;
            button1.Text = "&Relatório de Saídas";
            button1.UseVisualStyleBackColor = true;
            // 
            // ManageEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 351);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(LbID);
            Controls.Add(TbRE);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnEditar);
            Controls.Add(BtnCriar);
            Controls.Add(CbUsuario);
            Controls.Add(TbCodigo);
            Controls.Add(label1);
            Controls.Add(LbFiltro);
            Controls.Add(LbDivisao);
            Controls.Add(DgItens);
            Controls.Add(LbTitulo);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ManageEmployee";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gerenciar Funcionários";
            ((System.ComponentModel.ISupportInitialize)DgItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbID;
        private TextBox TbRE;
        private Button BtnExcluir;
        private Button BtnEditar;
        private Button BtnCriar;
        private CheckBox CbUsuario;
        private TextBox TbCodigo;
        private Label label1;
        private Label LbFiltro;
        private Label LbDivisao;
        private DataGridView DgItens;
        private Label LbTitulo;
        private Label label2;
        private Label label3;
        private Button button1;
        private DataGridViewTextBoxColumn RE;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Depto;
    }
}