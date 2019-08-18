namespace SistemaAcademico.forms.Admin
{
    partial class FormVisaoGeral
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gpbUsuarios = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInfoUsuarios = new System.Windows.Forms.Label();
            this.lblNUsuarios = new System.Windows.Forms.Label();
            this.lblNProfessores = new System.Windows.Forms.Label();
            this.lblNAlunos = new System.Windows.Forms.Label();
            this.lblNAdmins = new System.Windows.Forms.Label();
            this.gpbCursos = new System.Windows.Forms.GroupBox();
            this.tlpCursos = new System.Windows.Forms.TableLayoutPanel();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblAlunos = new System.Windows.Forms.Label();
            this.lblMaterias = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gpbUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gpbCursos.SuspendLayout();
            this.tlpCursos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(27, 24);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(9, 6, 9, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(127, 24);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Visão Geral";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpbUsuarios
            // 
            this.gpbUsuarios.AutoSize = true;
            this.gpbUsuarios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gpbUsuarios.Controls.Add(this.splitContainer1);
            this.gpbUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbUsuarios.Location = new System.Drawing.Point(0, 0);
            this.gpbUsuarios.Margin = new System.Windows.Forms.Padding(0);
            this.gpbUsuarios.Name = "gpbUsuarios";
            this.gpbUsuarios.Padding = new System.Windows.Forms.Padding(0);
            this.gpbUsuarios.Size = new System.Drawing.Size(645, 169);
            this.gpbUsuarios.TabIndex = 2;
            this.gpbUsuarios.TabStop = false;
            this.gpbUsuarios.Text = "Usuários cadastrados";
            this.gpbUsuarios.UseWaitCursor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(3, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lblInfoUsuarios);
            this.splitContainer1.Panel1.UseWaitCursor = true;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblNUsuarios);
            this.splitContainer1.Panel2.Controls.Add(this.lblNProfessores);
            this.splitContainer1.Panel2.Controls.Add(this.lblNAlunos);
            this.splitContainer1.Panel2.Controls.Add(this.lblNAdmins);
            this.splitContainer1.Panel2.UseWaitCursor = true;
            this.splitContainer1.Size = new System.Drawing.Size(639, 119);
            this.splitContainer1.SplitterDistance = 168;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Professores";
            this.label3.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(168, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total de Usuários";
            this.label5.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alunos";
            this.label1.UseWaitCursor = true;
            // 
            // lblInfoUsuarios
            // 
            this.lblInfoUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoUsuarios.Location = new System.Drawing.Point(0, 0);
            this.lblInfoUsuarios.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblInfoUsuarios.Name = "lblInfoUsuarios";
            this.lblInfoUsuarios.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.lblInfoUsuarios.Size = new System.Drawing.Size(168, 20);
            this.lblInfoUsuarios.TabIndex = 0;
            this.lblInfoUsuarios.Text = "Administradores";
            this.lblInfoUsuarios.UseWaitCursor = true;
            // 
            // lblNUsuarios
            // 
            this.lblNUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNUsuarios.Location = new System.Drawing.Point(0, 90);
            this.lblNUsuarios.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblNUsuarios.Name = "lblNUsuarios";
            this.lblNUsuarios.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.lblNUsuarios.Size = new System.Drawing.Size(467, 20);
            this.lblNUsuarios.TabIndex = 5;
            this.lblNUsuarios.Text = "0";
            this.lblNUsuarios.UseWaitCursor = true;
            // 
            // lblNProfessores
            // 
            this.lblNProfessores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNProfessores.Location = new System.Drawing.Point(0, 60);
            this.lblNProfessores.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblNProfessores.Name = "lblNProfessores";
            this.lblNProfessores.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.lblNProfessores.Size = new System.Drawing.Size(467, 20);
            this.lblNProfessores.TabIndex = 3;
            this.lblNProfessores.Text = "0";
            this.lblNProfessores.UseWaitCursor = true;
            // 
            // lblNAlunos
            // 
            this.lblNAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNAlunos.Location = new System.Drawing.Point(0, 30);
            this.lblNAlunos.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblNAlunos.Name = "lblNAlunos";
            this.lblNAlunos.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.lblNAlunos.Size = new System.Drawing.Size(467, 20);
            this.lblNAlunos.TabIndex = 3;
            this.lblNAlunos.Text = "0";
            this.lblNAlunos.UseWaitCursor = true;
            // 
            // lblNAdmins
            // 
            this.lblNAdmins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNAdmins.Location = new System.Drawing.Point(0, 0);
            this.lblNAdmins.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblNAdmins.Name = "lblNAdmins";
            this.lblNAdmins.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.lblNAdmins.Size = new System.Drawing.Size(467, 20);
            this.lblNAdmins.TabIndex = 3;
            this.lblNAdmins.Text = "0";
            this.lblNAdmins.UseWaitCursor = true;
            // 
            // gpbCursos
            // 
            this.gpbCursos.AutoSize = true;
            this.gpbCursos.Controls.Add(this.tlpCursos);
            this.gpbCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbCursos.Location = new System.Drawing.Point(0, 169);
            this.gpbCursos.Margin = new System.Windows.Forms.Padding(0);
            this.gpbCursos.Name = "gpbCursos";
            this.gpbCursos.Padding = new System.Windows.Forms.Padding(6, 6, 6, 0);
            this.gpbCursos.Size = new System.Drawing.Size(645, 152);
            this.gpbCursos.TabIndex = 3;
            this.gpbCursos.TabStop = false;
            this.gpbCursos.Text = "Cursos";
            this.gpbCursos.UseWaitCursor = true;
            // 
            // tlpCursos
            // 
            this.tlpCursos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCursos.AutoSize = true;
            this.tlpCursos.ColumnCount = 3;
            this.tlpCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpCursos.Controls.Add(this.lblNome, 0, 0);
            this.tlpCursos.Controls.Add(this.lblAlunos, 1, 0);
            this.tlpCursos.Controls.Add(this.lblMaterias, 2, 0);
            this.tlpCursos.Location = new System.Drawing.Point(9, 29);
            this.tlpCursos.Margin = new System.Windows.Forms.Padding(9, 9, 9, 0);
            this.tlpCursos.Name = "tlpCursos";
            this.tlpCursos.RowCount = 1;
            this.tlpCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCursos.Size = new System.Drawing.Size(627, 103);
            this.tlpCursos.TabIndex = 26;
            this.tlpCursos.UseWaitCursor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(3, 3);
            this.lblNome.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 24;
            this.lblNome.Text = "Nome\r\n";
            this.lblNome.UseWaitCursor = true;
            // 
            // lblAlunos
            // 
            this.lblAlunos.AutoSize = true;
            this.lblAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlunos.Location = new System.Drawing.Point(60, 3);
            this.lblAlunos.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblAlunos.Name = "lblAlunos";
            this.lblAlunos.Size = new System.Drawing.Size(58, 20);
            this.lblAlunos.TabIndex = 25;
            this.lblAlunos.Text = "Alunos\r\n";
            this.lblAlunos.UseWaitCursor = true;
            // 
            // lblMaterias
            // 
            this.lblMaterias.AutoSize = true;
            this.lblMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterias.Location = new System.Drawing.Point(190, 3);
            this.lblMaterias.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblMaterias.Name = "lblMaterias";
            this.lblMaterias.Size = new System.Drawing.Size(70, 20);
            this.lblMaterias.TabIndex = 26;
            this.lblMaterias.Text = "Matérias\r\n";
            this.lblMaterias.UseWaitCursor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.gpbCursos);
            this.panel1.Controls.Add(this.gpbUsuarios);
            this.panel1.Location = new System.Drawing.Point(21, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 412);
            this.panel1.TabIndex = 1;
            // 
            // FormVisaoGeral
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(687, 493);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVisaoGeral";
            this.Padding = new System.Windows.Forms.Padding(18);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Visão Geral - Sistema Acadêmico";
            this.gpbUsuarios.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gpbCursos.ResumeLayout(false);
            this.gpbCursos.PerformLayout();
            this.tlpCursos.ResumeLayout(false);
            this.tlpCursos.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gpbUsuarios;
        private System.Windows.Forms.GroupBox gpbCursos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInfoUsuarios;
        private System.Windows.Forms.Label lblNProfessores;
        private System.Windows.Forms.Label lblNAlunos;
        private System.Windows.Forms.Label lblNAdmins;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNUsuarios;
        private System.Windows.Forms.TableLayoutPanel tlpCursos;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblAlunos;
        private System.Windows.Forms.Label lblMaterias;
    }
}