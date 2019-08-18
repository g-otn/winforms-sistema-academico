namespace SistemaAcademico.forms.Aluno
{
    partial class FormMinhasNotas
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
            this.panMaterias = new System.Windows.Forms.Panel();
            this.tlpMateria = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panMaterias.SuspendLayout();
            this.tlpMateria.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(28, 20);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(16, 9, 16, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(145, 24);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Minhas Notas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panMaterias
            // 
            this.panMaterias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panMaterias.Controls.Add(this.tlpMateria);
            this.panMaterias.Location = new System.Drawing.Point(13, 68);
            this.panMaterias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panMaterias.Name = "panMaterias";
            this.panMaterias.Size = new System.Drawing.Size(869, 571);
            this.panMaterias.TabIndex = 5;
            // 
            // tlpMateria
            // 
            this.tlpMateria.ColumnCount = 2;
            this.tlpMateria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.64311F));
            this.tlpMateria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.35689F));
            this.tlpMateria.Controls.Add(this.label1, 0, 0);
            this.tlpMateria.Controls.Add(this.label2, 0, 1);
            this.tlpMateria.Controls.Add(this.label3, 1, 1);
            this.tlpMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpMateria.Location = new System.Drawing.Point(0, 0);
            this.tlpMateria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpMateria.Name = "tlpMateria";
            this.tlpMateria.RowCount = 5;
            this.tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMateria.Size = new System.Drawing.Size(869, 81);
            this.tlpMateria.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tlpMateria.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(861, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Materia";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Professor";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(138, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(728, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "nome do professor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormMinhasNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 652);
            this.Controls.Add(this.panMaterias);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMinhasNotas";
            this.Text = "Notas - Sistema Acadêmico";
            this.panMaterias.ResumeLayout(false);
            this.tlpMateria.ResumeLayout(false);
            this.tlpMateria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panMaterias;
        private System.Windows.Forms.TableLayoutPanel tlpMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}