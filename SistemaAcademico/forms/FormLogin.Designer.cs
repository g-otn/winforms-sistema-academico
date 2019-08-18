namespace SistemaAcademico.forms
{
    partial class FormLogin
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
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.panLogin = new System.Windows.Forms.Panel();
            this.panSenha = new System.Windows.Forms.Panel();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.panLogin.SuspendLayout();
            this.panSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.Color.Gray;
            this.txtLogin.Location = new System.Drawing.Point(10, 7);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(0);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(232, 19);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.Text = "Email ou Usuário";
            this.txtLogin.Enter += new System.EventHandler(this.txtLogin_Enter);
            this.txtLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLogin_KeyDown);
            this.txtLogin.Leave += new System.EventHandler(this.txtLogin_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema Acadêmico";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEntrar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Location = new System.Drawing.Point(21, 124);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(252, 32);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // panLogin
            // 
            this.panLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panLogin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panLogin.Controls.Add(this.txtLogin);
            this.panLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panLogin.Location = new System.Drawing.Point(21, 47);
            this.panLogin.Name = "panLogin";
            this.panLogin.Size = new System.Drawing.Size(252, 32);
            this.panLogin.TabIndex = 1;
            this.panLogin.Click += new System.EventHandler(this.panLogin_Click);
            // 
            // panSenha
            // 
            this.panSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panSenha.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panSenha.Controls.Add(this.txtSenha);
            this.panSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panSenha.Location = new System.Drawing.Point(21, 85);
            this.panSenha.Name = "panSenha";
            this.panSenha.Size = new System.Drawing.Size(252, 32);
            this.panSenha.TabIndex = 2;
            this.panSenha.Click += new System.EventHandler(this.panSenha_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenha.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.Gray;
            this.txtSenha.Location = new System.Drawing.Point(10, 7);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(0);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(232, 19);
            this.txtSenha.TabIndex = 0;
            this.txtSenha.Text = "Senha";
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 173);
            this.Controls.Add(this.panSenha);
            this.Controls.Add(this.panLogin);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(200, 170);
            this.Name = "FormLogin";
            this.Padding = new System.Windows.Forms.Padding(18, 10, 18, 18);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Acadêmico";
            this.panLogin.ResumeLayout(false);
            this.panLogin.PerformLayout();
            this.panSenha.ResumeLayout(false);
            this.panSenha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Panel panLogin;
        private System.Windows.Forms.Panel panSenha;
        private System.Windows.Forms.TextBox txtSenha;
    }
}