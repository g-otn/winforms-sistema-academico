namespace SistemaAcademico.forms.Admin
{
    partial class FormNotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvNotasAlunos = new System.Windows.Forms.DataGridView();
            this.RA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MediaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.gpbNotasAlunos = new System.Windows.Forms.GroupBox();
            this.cmbMaterias = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvNotasPesos = new System.Windows.Forms.DataGridView();
            this.NomeNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbNotasPesos = new System.Windows.Forms.GroupBox();
            this.btnAdicionarNota = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeNota = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotasAlunos)).BeginInit();
            this.gpbNotasAlunos.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotasPesos)).BeginInit();
            this.gpbNotasPesos.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(21, 16);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(12, 7, 12, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(69, 24);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Notas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvNotasAlunos
            // 
            this.dgvNotasAlunos.AllowUserToAddRows = false;
            this.dgvNotasAlunos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Azure;
            this.dgvNotasAlunos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNotasAlunos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.dgvNotasAlunos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNotasAlunos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvNotasAlunos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotasAlunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNotasAlunos.ColumnHeadersHeight = 25;
            this.dgvNotasAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RA,
            this.Nome,
            this.MediaFinal});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotasAlunos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNotasAlunos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNotasAlunos.Enabled = false;
            this.dgvNotasAlunos.GridColor = System.Drawing.Color.White;
            this.dgvNotasAlunos.Location = new System.Drawing.Point(0, 0);
            this.dgvNotasAlunos.MultiSelect = false;
            this.dgvNotasAlunos.Name = "dgvNotasAlunos";
            this.dgvNotasAlunos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotasAlunos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNotasAlunos.RowHeadersVisible = false;
            this.dgvNotasAlunos.RowHeadersWidth = 25;
            this.dgvNotasAlunos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle6.NullValue = "-";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Azure;
            this.dgvNotasAlunos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNotasAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotasAlunos.Size = new System.Drawing.Size(656, 404);
            this.dgvNotasAlunos.TabIndex = 5;
            this.dgvNotasAlunos.TabStop = false;
            this.dgvNotasAlunos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotasAlunos_CellEndEdit);
            this.dgvNotasAlunos.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvNotasAlunos_ColumnAdded);
            // 
            // RA
            // 
            this.RA.FillWeight = 60.33395F;
            this.RA.HeaderText = "RA";
            this.RA.MinimumWidth = 75;
            this.RA.Name = "RA";
            this.RA.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.FillWeight = 45.79471F;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // MediaFinal
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediaFinal.DefaultCellStyle = dataGridViewCellStyle3;
            this.MediaFinal.FillWeight = 52.3485F;
            this.MediaFinal.HeaderText = "Média Final";
            this.MediaFinal.Name = "MediaFinal";
            this.MediaFinal.ReadOnly = true;
            // 
            // cmbCurso
            // 
            this.cmbCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurso.Enabled = false;
            this.cmbCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCurso.ForeColor = System.Drawing.Color.Azure;
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(54, 21);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(98, 24);
            this.cmbCurso.TabIndex = 24;
            this.cmbCurso.SelectedIndexChanged += new System.EventHandler(this.cmbCurso_SelectedIndexChanged);
            // 
            // gpbNotasAlunos
            // 
            this.gpbNotasAlunos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbNotasAlunos.Controls.Add(this.cmbMaterias);
            this.gpbNotasAlunos.Controls.Add(this.label2);
            this.gpbNotasAlunos.Controls.Add(this.label4);
            this.gpbNotasAlunos.Controls.Add(this.cmbCurso);
            this.gpbNotasAlunos.Controls.Add(this.panel1);
            this.gpbNotasAlunos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbNotasAlunos.Location = new System.Drawing.Point(12, 54);
            this.gpbNotasAlunos.Name = "gpbNotasAlunos";
            this.gpbNotasAlunos.Size = new System.Drawing.Size(668, 461);
            this.gpbNotasAlunos.TabIndex = 27;
            this.gpbNotasAlunos.TabStop = false;
            this.gpbNotasAlunos.Text = "Notas dos Alunos";
            // 
            // cmbMaterias
            // 
            this.cmbMaterias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMaterias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.cmbMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterias.Enabled = false;
            this.cmbMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaterias.ForeColor = System.Drawing.Color.Azure;
            this.cmbMaterias.FormattingEnabled = true;
            this.cmbMaterias.Location = new System.Drawing.Point(227, 21);
            this.cmbMaterias.Name = "cmbMaterias";
            this.cmbMaterias.Size = new System.Drawing.Size(435, 24);
            this.cmbMaterias.TabIndex = 25;
            this.cmbMaterias.SelectedIndexChanged += new System.EventHandler(this.cmbMaterias_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Curso";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Matéria";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvNotasAlunos);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(6, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 404);
            this.panel1.TabIndex = 26;
            // 
            // dgvNotasPesos
            // 
            this.dgvNotasPesos.AllowUserToAddRows = false;
            this.dgvNotasPesos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Azure;
            this.dgvNotasPesos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvNotasPesos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotasPesos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.dgvNotasPesos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNotasPesos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvNotasPesos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotasPesos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvNotasPesos.ColumnHeadersHeight = 30;
            this.dgvNotasPesos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeNota,
            this.Peso,
            this.NumNota});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotasPesos.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvNotasPesos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNotasPesos.GridColor = System.Drawing.Color.White;
            this.dgvNotasPesos.Location = new System.Drawing.Point(0, 0);
            this.dgvNotasPesos.MultiSelect = false;
            this.dgvNotasPesos.Name = "dgvNotasPesos";
            this.dgvNotasPesos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotasPesos.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvNotasPesos.RowHeadersVisible = false;
            this.dgvNotasPesos.RowHeadersWidth = 30;
            this.dgvNotasPesos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle12.NullValue = "-";
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Azure;
            this.dgvNotasPesos.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvNotasPesos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvNotasPesos.Size = new System.Drawing.Size(240, 406);
            this.dgvNotasPesos.TabIndex = 26;
            this.dgvNotasPesos.TabStop = false;
            this.dgvNotasPesos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotasPesos_CellClick);
            this.dgvNotasPesos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotasPesos_CellEndEdit);
            // 
            // NomeNota
            // 
            this.NomeNota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeNota.FillWeight = 150F;
            this.NomeNota.HeaderText = "Nome da Nota";
            this.NomeNota.MaxInputLength = 30;
            this.NomeNota.Name = "NomeNota";
            this.NomeNota.ReadOnly = true;
            // 
            // Peso
            // 
            this.Peso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.NullValue = "0";
            this.Peso.DefaultCellStyle = dataGridViewCellStyle9;
            this.Peso.HeaderText = "Peso";
            this.Peso.MaxInputLength = 4;
            this.Peso.Name = "Peso";
            // 
            // NumNota
            // 
            this.NumNota.HeaderText = "NumNota";
            this.NumNota.Name = "NumNota";
            this.NumNota.ReadOnly = true;
            this.NumNota.Visible = false;
            // 
            // gpbNotasPesos
            // 
            this.gpbNotasPesos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbNotasPesos.Controls.Add(this.btnAdicionarNota);
            this.gpbNotasPesos.Controls.Add(this.label1);
            this.gpbNotasPesos.Controls.Add(this.txtNomeNota);
            this.gpbNotasPesos.Controls.Add(this.panel2);
            this.gpbNotasPesos.Enabled = false;
            this.gpbNotasPesos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbNotasPesos.Location = new System.Drawing.Point(686, 54);
            this.gpbNotasPesos.Name = "gpbNotasPesos";
            this.gpbNotasPesos.Size = new System.Drawing.Size(252, 461);
            this.gpbNotasPesos.TabIndex = 29;
            this.gpbNotasPesos.TabStop = false;
            this.gpbNotasPesos.Text = "Notas e Pesos";
            // 
            // btnAdicionarNota
            // 
            this.btnAdicionarNota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarNota.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdicionarNota.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdicionarNota.FlatAppearance.BorderSize = 0;
            this.btnAdicionarNota.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAdicionarNota.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAdicionarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarNota.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarNota.Location = new System.Drawing.Point(214, 21);
            this.btnAdicionarNota.Margin = new System.Windows.Forms.Padding(3, 9, 15, 3);
            this.btnAdicionarNota.MaximumSize = new System.Drawing.Size(197, 32);
            this.btnAdicionarNota.MinimumSize = new System.Drawing.Size(22, 22);
            this.btnAdicionarNota.Name = "btnAdicionarNota";
            this.btnAdicionarNota.Size = new System.Drawing.Size(26, 22);
            this.btnAdicionarNota.TabIndex = 28;
            this.btnAdicionarNota.Text = "+";
            this.btnAdicionarNota.UseVisualStyleBackColor = false;
            this.btnAdicionarNota.Click += new System.EventHandler(this.btnAdicionarNota_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nome da Nota";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNomeNota
            // 
            this.txtNomeNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeNota.Location = new System.Drawing.Point(108, 21);
            this.txtNomeNota.Name = "txtNomeNota";
            this.txtNomeNota.Size = new System.Drawing.Size(100, 22);
            this.txtNomeNota.TabIndex = 27;
            this.txtNomeNota.TextChanged += new System.EventHandler(this.txtNomeNota_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dgvNotasPesos);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(6, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 406);
            this.panel2.TabIndex = 29;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(520, 13);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 9, 15, 3);
            this.btnSalvar.MaximumSize = new System.Drawing.Size(197, 32);
            this.btnSalvar.MinimumSize = new System.Drawing.Size(98, 32);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(197, 32);
            this.btnSalvar.TabIndex = 27;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(735, 13);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 9, 15, 3);
            this.btnCancelar.MaximumSize = new System.Drawing.Size(197, 32);
            this.btnCancelar.MinimumSize = new System.Drawing.Size(98, 32);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(197, 32);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 527);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gpbNotasPesos);
            this.Controls.Add(this.gpbNotasAlunos);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNotas";
            this.Text = "Notas - Sistema Acadêmico";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotasAlunos)).EndInit();
            this.gpbNotasAlunos.ResumeLayout(false);
            this.gpbNotasAlunos.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotasPesos)).EndInit();
            this.gpbNotasPesos.ResumeLayout(false);
            this.gpbNotasPesos.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvNotasAlunos;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.GroupBox gpbNotasAlunos;
        private System.Windows.Forms.ComboBox cmbMaterias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvNotasPesos;
        private System.Windows.Forms.GroupBox gpbNotasPesos;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNomeNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdicionarNota;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn MediaFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumNota;
    }
}