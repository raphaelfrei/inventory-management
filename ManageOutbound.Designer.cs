namespace INVT {
    partial class ManageOutbound {
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
            LbID = new Label();
            TbNota = new TextBox();
            label2 = new Label();
            BtnExcluir = new Button();
            BtnEditar = new Button();
            BtnCriar = new Button();
            DtAte = new DateTimePicker();
            DtDe = new DateTimePicker();
            CbData = new CheckBox();
            CbProduto = new CheckBox();
            CbUsuario = new CheckBox();
            LbE = new Label();
            TbDescricao = new TextBox();
            TbCodigo = new TextBox();
            label1 = new Label();
            LbFiltro = new Label();
            LbDivisao = new Label();
            BtnRelatorio = new Button();
            label3 = new Label();
            label4 = new Label();
            ID = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            RE = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DgItens).BeginInit();
            SuspendLayout();
            // 
            // LbTitulo
            // 
            LbTitulo.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            LbTitulo.Location = new Point(12, 9);
            LbTitulo.Name = "LbTitulo";
            LbTitulo.Size = new Size(931, 62);
            LbTitulo.TabIndex = 3;
            LbTitulo.Text = "Gerenciar Saídas de Material";
            LbTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DgItens
            // 
            DgItens.AllowUserToAddRows = false;
            DgItens.AllowUserToDeleteRows = false;
            DgItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgItens.Columns.AddRange(new DataGridViewColumn[] { ID, Data, Usuario, RE });
            DgItens.Location = new Point(12, 79);
            DgItens.MultiSelect = false;
            DgItens.Name = "DgItens";
            DgItens.ReadOnly = true;
            DgItens.RowTemplate.Height = 25;
            DgItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgItens.Size = new Size(625, 318);
            DgItens.TabIndex = 19;
            DgItens.CellClick += DgItens_CellClick;
            // 
            // LbID
            // 
            LbID.AutoSize = true;
            LbID.Location = new Point(652, 202);
            LbID.Name = "LbID";
            LbID.Size = new Size(88, 15);
            LbID.TabIndex = 65;
            LbID.Text = "ID Selecionado:";
            // 
            // TbNota
            // 
            TbNota.Location = new Point(760, 199);
            TbNota.MaxLength = 20;
            TbNota.Name = "TbNota";
            TbNota.ReadOnly = true;
            TbNota.Size = new Size(174, 23);
            TbNota.TabIndex = 64;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(644, 187);
            label2.Name = "label2";
            label2.Size = new Size(300, 47);
            label2.TabIndex = 63;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Location = new Point(652, 304);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(282, 23);
            BtnExcluir.TabIndex = 62;
            BtnExcluir.Text = "E&xcluir Saída";
            BtnExcluir.UseVisualStyleBackColor = true;
            BtnExcluir.Click += BtnExcluir_Click;
            // 
            // BtnEditar
            // 
            BtnEditar.Enabled = false;
            BtnEditar.Location = new Point(652, 275);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(282, 23);
            BtnEditar.TabIndex = 61;
            BtnEditar.Text = "&Editar Saída";
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnCriar
            // 
            BtnCriar.Location = new Point(652, 246);
            BtnCriar.Name = "BtnCriar";
            BtnCriar.Size = new Size(282, 23);
            BtnCriar.TabIndex = 60;
            BtnCriar.Text = "&Criar Saída";
            BtnCriar.UseVisualStyleBackColor = true;
            BtnCriar.Click += BtnCriar_Click;
            // 
            // DtAte
            // 
            DtAte.Enabled = false;
            DtAte.Format = DateTimePickerFormat.Short;
            DtAte.Location = new Point(854, 152);
            DtAte.Name = "DtAte";
            DtAte.Size = new Size(80, 23);
            DtAte.TabIndex = 59;
            DtAte.ValueChanged += DtAte_ValueChanged;
            // 
            // DtDe
            // 
            DtDe.Enabled = false;
            DtDe.Format = DateTimePickerFormat.Short;
            DtDe.Location = new Point(741, 152);
            DtDe.Name = "DtDe";
            DtDe.Size = new Size(80, 23);
            DtDe.TabIndex = 58;
            DtDe.ValueChanged += DtDe_ValueChanged;
            // 
            // CbData
            // 
            CbData.AutoSize = true;
            CbData.Location = new Point(651, 154);
            CbData.Name = "CbData";
            CbData.Size = new Size(84, 19);
            CbData.TabIndex = 57;
            CbData.Text = "Saída entre";
            CbData.UseVisualStyleBackColor = true;
            CbData.CheckedChanged += CbData_CheckedChanged;
            // 
            // CbProduto
            // 
            CbProduto.AutoSize = true;
            CbProduto.Location = new Point(651, 124);
            CbProduto.Name = "CbProduto";
            CbProduto.Size = new Size(72, 19);
            CbProduto.TabIndex = 56;
            CbProduto.Text = "Produto:";
            CbProduto.UseVisualStyleBackColor = true;
            CbProduto.CheckedChanged += CbProduto_CheckedChanged;
            // 
            // CbUsuario
            // 
            CbUsuario.AutoSize = true;
            CbUsuario.Location = new Point(651, 95);
            CbUsuario.Name = "CbUsuario";
            CbUsuario.Size = new Size(87, 19);
            CbUsuario.TabIndex = 55;
            CbUsuario.Text = "Usuário/RE:";
            CbUsuario.UseVisualStyleBackColor = true;
            CbUsuario.CheckedChanged += CbUsuario_CheckedChanged;
            // 
            // LbE
            // 
            LbE.AutoSize = true;
            LbE.Location = new Point(827, 155);
            LbE.Name = "LbE";
            LbE.Size = new Size(23, 15);
            LbE.TabIndex = 54;
            LbE.Text = "até";
            LbE.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TbDescricao
            // 
            TbDescricao.Location = new Point(729, 123);
            TbDescricao.MaxLength = 20;
            TbDescricao.Name = "TbDescricao";
            TbDescricao.PlaceholderText = "Produto";
            TbDescricao.ReadOnly = true;
            TbDescricao.Size = new Size(205, 23);
            TbDescricao.TabIndex = 53;
            TbDescricao.TextChanged += TbDescricao_TextChanged;
            // 
            // TbCodigo
            // 
            TbCodigo.Location = new Point(741, 95);
            TbCodigo.MaxLength = 20;
            TbCodigo.Name = "TbCodigo";
            TbCodigo.PlaceholderText = "Nome ou RE";
            TbCodigo.ReadOnly = true;
            TbCodigo.Size = new Size(193, 23);
            TbCodigo.TabIndex = 52;
            TbCodigo.TextChanged += TbCodigo_TextChanged;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(644, 234);
            label1.Name = "label1";
            label1.Size = new Size(300, 105);
            label1.TabIndex = 51;
            // 
            // LbFiltro
            // 
            LbFiltro.AutoSize = true;
            LbFiltro.Location = new Point(652, 71);
            LbFiltro.Name = "LbFiltro";
            LbFiltro.Size = new Size(40, 15);
            LbFiltro.TabIndex = 50;
            LbFiltro.Text = "Filtrar:";
            // 
            // LbDivisao
            // 
            LbDivisao.BorderStyle = BorderStyle.Fixed3D;
            LbDivisao.Location = new Point(644, 79);
            LbDivisao.Name = "LbDivisao";
            LbDivisao.Size = new Size(300, 108);
            LbDivisao.TabIndex = 49;
            // 
            // BtnRelatorio
            // 
            BtnRelatorio.Location = new Point(651, 347);
            BtnRelatorio.Name = "BtnRelatorio";
            BtnRelatorio.Size = new Size(282, 23);
            BtnRelatorio.TabIndex = 66;
            BtnRelatorio.Text = "&Gerar Relatório";
            BtnRelatorio.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(652, 373);
            label3.Name = "label3";
            label3.Size = new Size(185, 12);
            label3.TabIndex = 67;
            label3.Text = "* O relatório segue os filtros selecionados";
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(643, 339);
            label4.Name = "label4";
            label4.Size = new Size(300, 58);
            label4.TabIndex = 68;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Data
            // 
            Data.HeaderText = "Data de Saída";
            Data.Name = "Data";
            Data.ReadOnly = true;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuário";
            Usuario.Name = "Usuario";
            Usuario.ReadOnly = true;
            // 
            // RE
            // 
            RE.HeaderText = "RE";
            RE.Name = "RE";
            RE.ReadOnly = true;
            // 
            // ManageOutbound
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 413);
            Controls.Add(label3);
            Controls.Add(BtnRelatorio);
            Controls.Add(LbID);
            Controls.Add(TbNota);
            Controls.Add(label2);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnEditar);
            Controls.Add(BtnCriar);
            Controls.Add(DtAte);
            Controls.Add(DtDe);
            Controls.Add(CbData);
            Controls.Add(CbProduto);
            Controls.Add(CbUsuario);
            Controls.Add(LbE);
            Controls.Add(TbDescricao);
            Controls.Add(TbCodigo);
            Controls.Add(label1);
            Controls.Add(LbFiltro);
            Controls.Add(LbDivisao);
            Controls.Add(DgItens);
            Controls.Add(LbTitulo);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ManageOutbound";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gerenciar Saída de Material";
            Shown += ManageOutbound_Shown;
            ((System.ComponentModel.ISupportInitialize)DgItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbTitulo;
        private DataGridView DgItens;
        private Label LbID;
        private TextBox TbNota;
        private Label label2;
        private Button BtnExcluir;
        private Button BtnEditar;
        private Button BtnCriar;
        private DateTimePicker DtAte;
        private DateTimePicker DtDe;
        private CheckBox CbData;
        private CheckBox CbProduto;
        private CheckBox CbUsuario;
        private Label LbE;
        private TextBox TbDescricao;
        private TextBox TbCodigo;
        private Label label1;
        private Label LbFiltro;
        private Label LbDivisao;
        private Button BtnRelatorio;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn RE;
    }
}