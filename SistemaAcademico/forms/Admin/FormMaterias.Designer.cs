namespace SistemaAcademico.forms.Admin
{
    partial class FormMaterias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.Sigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.gpbDadosMateria = new System.Windows.Forms.GroupBox();
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.cmbDadosCurso = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbProfessores = new System.Windows.Forms.GroupBox();
            this.txtEntradaProfessor = new System.Windows.Forms.TextBox();
            this.tlpProfessor = new System.Windows.Forms.TableLayoutPanel();
            this.lblProfessorCPF = new System.Windows.Forms.Label();
            this.lblProfessorRegistro = new System.Windows.Forms.Label();
            this.lblProfessorNome = new System.Windows.Forms.Label();
            this.lblProfessorRG = new System.Windows.Forms.Label();
            this.cmbFiltroProfessor = new System.Windows.Forms.ComboBox();
            this.cmbResultadosProfessor = new System.Windows.Forms.ComboBox();
            this.gpbAlunos = new System.Windows.Forms.GroupBox();
            this.ckbMostrarNaoCursando = new System.Windows.Forms.CheckBox();
            this.txtEntradaPesquisaAluno = new System.Windows.Forms.TextBox();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.Cursando = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbFiltroPesquisaAluno = new System.Windows.Forms.ComboBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.gpbDadosMateria.SuspendLayout();
            this.gpbDados.SuspendLayout();
            this.gpbProfessores.SuspendLayout();
            this.tlpProfessor.SuspendLayout();
            this.gpbAlunos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(21, 16);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(12, 7, 12, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(95, 24);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Matérias";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Azure;
            this.dgvMaterias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMaterias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaterias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.dgvMaterias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMaterias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMaterias.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaterias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMaterias.ColumnHeadersHeight = 25;
            this.dgvMaterias.ColumnHeadersVisible = false;
            this.dgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sigla,
            this.NomeMateria});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMaterias.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMaterias.Enabled = false;
            this.dgvMaterias.GridColor = System.Drawing.Color.White;
            this.dgvMaterias.Location = new System.Drawing.Point(6, 61);
            this.dgvMaterias.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.dgvMaterias.MultiSelect = false;
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaterias.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMaterias.RowHeadersVisible = false;
            this.dgvMaterias.RowHeadersWidth = 25;
            this.dgvMaterias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle5.NullValue = "-";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Azure;
            this.dgvMaterias.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterias.Size = new System.Drawing.Size(359, 526);
            this.dgvMaterias.TabIndex = 4;
            this.dgvMaterias.TabStop = false;
            this.dgvMaterias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterias_CellClick);
            // 
            // Sigla
            // 
            this.Sigla.FillWeight = 50.76142F;
            this.Sigla.HeaderText = "Sigla";
            this.Sigla.Name = "Sigla";
            this.Sigla.ReadOnly = true;
            // 
            // NomeMateria
            // 
            this.NomeMateria.FillWeight = 149.2386F;
            this.NomeMateria.HeaderText = "Nome";
            this.NomeMateria.Name = "NomeMateria";
            this.NomeMateria.ReadOnly = true;
            // 
            // cmbCurso
            // 
            this.cmbCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurso.Enabled = false;
            this.cmbCurso.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCurso.ForeColor = System.Drawing.Color.Azure;
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(63, 26);
            this.cmbCurso.Margin = new System.Windows.Forms.Padding(0);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(84, 26);
            this.cmbCurso.TabIndex = 5;
            this.cmbCurso.SelectedIndexChanged += new System.EventHandler(this.cmbCurso_SelectedIndexChanged);
            // 
            // gpbDadosMateria
            // 
            this.gpbDadosMateria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbDadosMateria.Controls.Add(this.gpbDados);
            this.gpbDadosMateria.Controls.Add(this.gpbProfessores);
            this.gpbDadosMateria.Controls.Add(this.gpbAlunos);
            this.gpbDadosMateria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosMateria.Location = new System.Drawing.Point(0, 0);
            this.gpbDadosMateria.Margin = new System.Windows.Forms.Padding(0);
            this.gpbDadosMateria.Name = "gpbDadosMateria";
            this.gpbDadosMateria.Size = new System.Drawing.Size(816, 593);
            this.gpbDadosMateria.TabIndex = 6;
            this.gpbDadosMateria.TabStop = false;
            this.gpbDadosMateria.Text = "Criar Matéria";
            // 
            // gpbDados
            // 
            this.gpbDados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbDados.Controls.Add(this.label2);
            this.gpbDados.Controls.Add(this.txtNome);
            this.gpbDados.Controls.Add(this.label1);
            this.gpbDados.Controls.Add(this.txtSigla);
            this.gpbDados.Controls.Add(this.cmbDadosCurso);
            this.gpbDados.Controls.Add(this.label3);
            this.gpbDados.Location = new System.Drawing.Point(6, 26);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Size = new System.Drawing.Size(804, 90);
            this.gpbDados.TabIndex = 24;
            this.gpbDados.TabStop = false;
            this.gpbDados.Text = "Dados";
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
            // txtNome
            // 
            this.txtNome.AccessibleDescription = "";
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(55, 51);
            this.txtNome.MaxLength = 75;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(743, 22);
            this.txtNome.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSigla
            // 
            this.txtSigla.AccessibleDescription = "";
            this.txtSigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSigla.Location = new System.Drawing.Point(203, 21);
            this.txtSigla.MaxLength = 10;
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(89, 22);
            this.txtSigla.TabIndex = 15;
            // 
            // cmbDadosCurso
            // 
            this.cmbDadosCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.cmbDadosCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDadosCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDadosCurso.ForeColor = System.Drawing.Color.Azure;
            this.cmbDadosCurso.FormattingEnabled = true;
            this.cmbDadosCurso.Location = new System.Drawing.Point(55, 21);
            this.cmbDadosCurso.Name = "cmbDadosCurso";
            this.cmbDadosCurso.Size = new System.Drawing.Size(84, 24);
            this.cmbDadosCurso.TabIndex = 13;
            this.cmbDadosCurso.SelectedIndexChanged += new System.EventHandler(this.cmbDadosCurso_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sigla";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpbProfessores
            // 
            this.gpbProfessores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbProfessores.Controls.Add(this.txtEntradaProfessor);
            this.gpbProfessores.Controls.Add(this.tlpProfessor);
            this.gpbProfessores.Controls.Add(this.cmbFiltroProfessor);
            this.gpbProfessores.Controls.Add(this.cmbResultadosProfessor);
            this.gpbProfessores.Location = new System.Drawing.Point(6, 122);
            this.gpbProfessores.Name = "gpbProfessores";
            this.gpbProfessores.Size = new System.Drawing.Size(804, 90);
            this.gpbProfessores.TabIndex = 25;
            this.gpbProfessores.TabStop = false;
            this.gpbProfessores.Text = "Professor";
            // 
            // txtEntradaProfessor
            // 
            this.txtEntradaProfessor.AccessibleDescription = "";
            this.txtEntradaProfessor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEntradaProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntradaProfessor.Location = new System.Drawing.Point(114, 26);
            this.txtEntradaProfessor.MaxLength = 100;
            this.txtEntradaProfessor.Name = "txtEntradaProfessor";
            this.txtEntradaProfessor.Size = new System.Drawing.Size(490, 22);
            this.txtEntradaProfessor.TabIndex = 16;
            this.txtEntradaProfessor.TextChanged += new System.EventHandler(this.txtEntradaProfessor_TextChanged);
            this.txtEntradaProfessor.Leave += new System.EventHandler(this.txtEntradaProfessor_Leave);
            // 
            // tlpProfessor
            // 
            this.tlpProfessor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpProfessor.ColumnCount = 4;
            this.tlpProfessor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.94118F));
            this.tlpProfessor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.05882F));
            this.tlpProfessor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tlpProfessor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tlpProfessor.Controls.Add(this.lblProfessorCPF, 3, 0);
            this.tlpProfessor.Controls.Add(this.lblProfessorRegistro, 1, 0);
            this.tlpProfessor.Controls.Add(this.lblProfessorNome, 0, 0);
            this.tlpProfessor.Controls.Add(this.lblProfessorRG, 2, 0);
            this.tlpProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpProfessor.Location = new System.Drawing.Point(10, 56);
            this.tlpProfessor.Name = "tlpProfessor";
            this.tlpProfessor.RowCount = 1;
            this.tlpProfessor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProfessor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpProfessor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpProfessor.Size = new System.Drawing.Size(788, 24);
            this.tlpProfessor.TabIndex = 25;
            // 
            // lblProfessorCPF
            // 
            this.lblProfessorCPF.AutoSize = true;
            this.lblProfessorCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessorCPF.Location = new System.Drawing.Point(651, 3);
            this.lblProfessorCPF.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblProfessorCPF.Name = "lblProfessorCPF";
            this.lblProfessorCPF.Size = new System.Drawing.Size(40, 16);
            this.lblProfessorCPF.TabIndex = 26;
            this.lblProfessorCPF.Text = "CPF: ";
            // 
            // lblProfessorRegistro
            // 
            this.lblProfessorRegistro.AutoSize = true;
            this.lblProfessorRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessorRegistro.Location = new System.Drawing.Point(278, 3);
            this.lblProfessorRegistro.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblProfessorRegistro.Name = "lblProfessorRegistro";
            this.lblProfessorRegistro.Size = new System.Drawing.Size(65, 16);
            this.lblProfessorRegistro.TabIndex = 24;
            this.lblProfessorRegistro.Text = "Registro: ";
            // 
            // lblProfessorNome
            // 
            this.lblProfessorNome.AutoSize = true;
            this.lblProfessorNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessorNome.Location = new System.Drawing.Point(3, 3);
            this.lblProfessorNome.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblProfessorNome.Name = "lblProfessorNome";
            this.lblProfessorNome.Size = new System.Drawing.Size(51, 16);
            this.lblProfessorNome.TabIndex = 27;
            this.lblProfessorNome.Text = "Nome: ";
            // 
            // lblProfessorRG
            // 
            this.lblProfessorRG.AutoSize = true;
            this.lblProfessorRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessorRG.Location = new System.Drawing.Point(523, 3);
            this.lblProfessorRG.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblProfessorRG.Name = "lblProfessorRG";
            this.lblProfessorRG.Size = new System.Drawing.Size(34, 16);
            this.lblProfessorRG.TabIndex = 25;
            this.lblProfessorRG.Text = "RG: ";
            // 
            // cmbFiltroProfessor
            // 
            this.cmbFiltroProfessor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.cmbFiltroProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltroProfessor.ForeColor = System.Drawing.Color.Azure;
            this.cmbFiltroProfessor.FormattingEnabled = true;
            this.cmbFiltroProfessor.Items.AddRange(new object[] {
            "Registro",
            "RG",
            "CPF",
            "Nome"});
            this.cmbFiltroProfessor.Location = new System.Drawing.Point(10, 26);
            this.cmbFiltroProfessor.Name = "cmbFiltroProfessor";
            this.cmbFiltroProfessor.Size = new System.Drawing.Size(98, 24);
            this.cmbFiltroProfessor.TabIndex = 23;
            this.cmbFiltroProfessor.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroProfessor_SelectedIndexChanged);
            // 
            // cmbResultadosProfessor
            // 
            this.cmbResultadosProfessor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbResultadosProfessor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.cmbResultadosProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResultadosProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbResultadosProfessor.ForeColor = System.Drawing.Color.Azure;
            this.cmbResultadosProfessor.FormattingEnabled = true;
            this.cmbResultadosProfessor.Location = new System.Drawing.Point(610, 26);
            this.cmbResultadosProfessor.Name = "cmbResultadosProfessor";
            this.cmbResultadosProfessor.Size = new System.Drawing.Size(188, 24);
            this.cmbResultadosProfessor.TabIndex = 17;
            this.cmbResultadosProfessor.SelectedIndexChanged += new System.EventHandler(this.cmbResultadosProfessor_SelectedIndexChanged);
            // 
            // gpbAlunos
            // 
            this.gpbAlunos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbAlunos.Controls.Add(this.ckbMostrarNaoCursando);
            this.gpbAlunos.Controls.Add(this.txtEntradaPesquisaAluno);
            this.gpbAlunos.Controls.Add(this.cmbFiltroPesquisaAluno);
            this.gpbAlunos.Controls.Add(this.panel1);
            this.gpbAlunos.Location = new System.Drawing.Point(6, 218);
            this.gpbAlunos.Name = "gpbAlunos";
            this.gpbAlunos.Size = new System.Drawing.Size(804, 369);
            this.gpbAlunos.TabIndex = 24;
            this.gpbAlunos.TabStop = false;
            this.gpbAlunos.Text = "Alunos";
            // 
            // ckbMostrarNaoCursando
            // 
            this.ckbMostrarNaoCursando.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbMostrarNaoCursando.AutoSize = true;
            this.ckbMostrarNaoCursando.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMostrarNaoCursando.Location = new System.Drawing.Point(596, 28);
            this.ckbMostrarNaoCursando.Name = "ckbMostrarNaoCursando";
            this.ckbMostrarNaoCursando.Size = new System.Drawing.Size(202, 20);
            this.ckbMostrarNaoCursando.TabIndex = 28;
            this.ckbMostrarNaoCursando.Text = "Mostrar alunos não cursantes";
            this.ckbMostrarNaoCursando.UseVisualStyleBackColor = true;
            this.ckbMostrarNaoCursando.CheckedChanged += new System.EventHandler(this.ckbMostrarNaoCursando_CheckedChanged);
            // 
            // txtEntradaPesquisaAluno
            // 
            this.txtEntradaPesquisaAluno.AccessibleDescription = "";
            this.txtEntradaPesquisaAluno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEntradaPesquisaAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntradaPesquisaAluno.Location = new System.Drawing.Point(114, 26);
            this.txtEntradaPesquisaAluno.MaxLength = 100;
            this.txtEntradaPesquisaAluno.Name = "txtEntradaPesquisaAluno";
            this.txtEntradaPesquisaAluno.Size = new System.Drawing.Size(476, 22);
            this.txtEntradaPesquisaAluno.TabIndex = 26;
            this.txtEntradaPesquisaAluno.TextChanged += new System.EventHandler(this.txtEntradaPesquisaAluno_TextChanged);
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.AllowUserToAddRows = false;
            this.dgvAlunos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Azure;
            this.dgvAlunos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAlunos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.dgvAlunos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlunos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAlunos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAlunos.ColumnHeadersHeight = 25;
            this.dgvAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cursando,
            this.RA,
            this.NomeAluno,
            this.RG,
            this.CPF,
            this.ID});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlunos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAlunos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlunos.GridColor = System.Drawing.Color.White;
            this.dgvAlunos.Location = new System.Drawing.Point(0, 0);
            this.dgvAlunos.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.dgvAlunos.MultiSelect = false;
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlunos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAlunos.RowHeadersVisible = false;
            this.dgvAlunos.RowHeadersWidth = 25;
            this.dgvAlunos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle10.NullValue = "-";
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Azure;
            this.dgvAlunos.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlunos.Size = new System.Drawing.Size(788, 301);
            this.dgvAlunos.TabIndex = 13;
            this.dgvAlunos.TabStop = false;
            // 
            // Cursando
            // 
            this.Cursando.HeaderText = "Cursando";
            this.Cursando.Name = "Cursando";
            this.Cursando.Width = 75;
            // 
            // RA
            // 
            this.RA.HeaderText = "RA";
            this.RA.Name = "RA";
            this.RA.ReadOnly = true;
            this.RA.Width = 125;
            // 
            // NomeAluno
            // 
            this.NomeAluno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeAluno.HeaderText = "Nome";
            this.NomeAluno.Name = "NomeAluno";
            this.NomeAluno.ReadOnly = true;
            // 
            // RG
            // 
            this.RG.HeaderText = "RG";
            this.RG.Name = "RG";
            this.RG.ReadOnly = true;
            this.RG.Width = 125;
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            this.CPF.Width = 125;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // cmbFiltroPesquisaAluno
            // 
            this.cmbFiltroPesquisaAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.cmbFiltroPesquisaAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroPesquisaAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltroPesquisaAluno.ForeColor = System.Drawing.Color.Azure;
            this.cmbFiltroPesquisaAluno.FormattingEnabled = true;
            this.cmbFiltroPesquisaAluno.Items.AddRange(new object[] {
            "RA",
            "RG",
            "CPF",
            "Nome"});
            this.cmbFiltroPesquisaAluno.Location = new System.Drawing.Point(10, 26);
            this.cmbFiltroPesquisaAluno.Name = "cmbFiltroPesquisaAluno";
            this.cmbFiltroPesquisaAluno.Size = new System.Drawing.Size(98, 24);
            this.cmbFiltroPesquisaAluno.TabIndex = 27;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(9, 28);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(51, 20);
            this.lblCurso.TabIndex = 12;
            this.lblCurso.Text = "Curso";
            this.lblCurso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(12, 54);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.gpbDadosMateria);
            this.splitContainer.Size = new System.Drawing.Size(1191, 593);
            this.splitContainer.SplitterDistance = 371;
            this.splitContainer.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvMaterias);
            this.groupBox1.Controls.Add(this.lblCurso);
            this.groupBox1.Controls.Add(this.cmbCurso);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 593);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecionar Matéria";
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
            this.btnSalvar.Location = new System.Drawing.Point(576, 13);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 9, 15, 3);
            this.btnSalvar.MaximumSize = new System.Drawing.Size(197, 32);
            this.btnSalvar.MinimumSize = new System.Drawing.Size(98, 32);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(197, 32);
            this.btnSalvar.TabIndex = 22;
            this.btnSalvar.Text = "Criar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(791, 13);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 9, 15, 3);
            this.btnExcluir.MaximumSize = new System.Drawing.Size(197, 32);
            this.btnExcluir.MinimumSize = new System.Drawing.Size(98, 32);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(197, 32);
            this.btnExcluir.TabIndex = 23;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(1006, 13);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 9, 15, 3);
            this.btnCancelar.MaximumSize = new System.Drawing.Size(197, 32);
            this.btnCancelar.MinimumSize = new System.Drawing.Size(98, 32);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(197, 32);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvAlunos);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(10, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 301);
            this.panel1.TabIndex = 29;
            // 
            // FormMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 659);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(860, 350);
            this.Name = "FormMaterias";
            this.Text = "Matérias - Sistema Acadêmico";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.gpbDadosMateria.ResumeLayout(false);
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            this.gpbProfessores.ResumeLayout(false);
            this.gpbProfessores.PerformLayout();
            this.tlpProfessor.ResumeLayout(false);
            this.tlpProfessor.PerformLayout();
            this.gpbAlunos.ResumeLayout(false);
            this.gpbAlunos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.GroupBox gpbDadosMateria;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDadosCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.ComboBox cmbResultadosProfessor;
        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbFiltroProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sigla;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeMateria;
        private System.Windows.Forms.GroupBox gpbProfessores;
        private System.Windows.Forms.GroupBox gpbAlunos;
        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.TableLayoutPanel tlpProfessor;
        private System.Windows.Forms.Label lblProfessorNome;
        private System.Windows.Forms.Label lblProfessorRegistro;
        private System.Windows.Forms.Label lblProfessorRG;
        private System.Windows.Forms.TextBox txtEntradaProfessor;
        private System.Windows.Forms.Label lblProfessorCPF;
        private System.Windows.Forms.TextBox txtEntradaPesquisaAluno;
        private System.Windows.Forms.ComboBox cmbFiltroPesquisaAluno;
        private System.Windows.Forms.CheckBox ckbMostrarNaoCursando;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Cursando;
        private System.Windows.Forms.DataGridViewTextBoxColumn RA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Panel panel1;
    }
}