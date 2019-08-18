namespace SistemaAcademico.forms.Admin
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panMenu = new System.Windows.Forms.Panel();
            this.btnNotas = new System.Windows.Forms.Button();
            this.btnMaterias = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnVisaoGeral = new System.Windows.Forms.Button();
            this.panUsuario = new System.Windows.Forms.FlowLayoutPanel();
            this.picUsuarioIcone = new System.Windows.Forms.PictureBox();
            this.lblUsuarioNome = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.panMenu.SuspendLayout();
            this.panUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuarioIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // panMenu
            // 
            this.panMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.panMenu.Controls.Add(this.btnNotas);
            this.panMenu.Controls.Add(this.btnMaterias);
            this.panMenu.Controls.Add(this.btnUsuarios);
            this.panMenu.Controls.Add(this.btnVisaoGeral);
            this.panMenu.Controls.Add(this.panUsuario);
            this.panMenu.Controls.Add(this.btnSair);
            resources.ApplyResources(this.panMenu, "panMenu");
            this.panMenu.ForeColor = System.Drawing.Color.Azure;
            this.panMenu.Name = "panMenu";
            // 
            // btnNotas
            // 
            resources.ApplyResources(this.btnNotas, "btnNotas");
            this.btnNotas.FlatAppearance.BorderSize = 0;
            this.btnNotas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnNotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.UseVisualStyleBackColor = false;
            this.btnNotas.Click += new System.EventHandler(this.btnNotas_Click);
            // 
            // btnMaterias
            // 
            resources.ApplyResources(this.btnMaterias, "btnMaterias");
            this.btnMaterias.FlatAppearance.BorderSize = 0;
            this.btnMaterias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnMaterias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.UseVisualStyleBackColor = false;
            this.btnMaterias.Click += new System.EventHandler(this.btnMaterias_Click);
            // 
            // btnUsuarios
            // 
            resources.ApplyResources(this.btnUsuarios, "btnUsuarios");
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnVisaoGeral
            // 
            resources.ApplyResources(this.btnVisaoGeral, "btnVisaoGeral");
            this.btnVisaoGeral.FlatAppearance.BorderSize = 0;
            this.btnVisaoGeral.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnVisaoGeral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.btnVisaoGeral.Name = "btnVisaoGeral";
            this.btnVisaoGeral.UseVisualStyleBackColor = false;
            this.btnVisaoGeral.Click += new System.EventHandler(this.btnVisaoGeral_Click);
            // 
            // panUsuario
            // 
            resources.ApplyResources(this.panUsuario, "panUsuario");
            this.panUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.panUsuario.Controls.Add(this.picUsuarioIcone);
            this.panUsuario.Controls.Add(this.lblUsuarioNome);
            this.panUsuario.Name = "panUsuario";
            // 
            // picUsuarioIcone
            // 
            this.picUsuarioIcone.BackColor = System.Drawing.Color.Transparent;
            this.picUsuarioIcone.BackgroundImage = global::SistemaAcademico.Properties.Resources.icone_default;
            resources.ApplyResources(this.picUsuarioIcone, "picUsuarioIcone");
            this.picUsuarioIcone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picUsuarioIcone.Name = "picUsuarioIcone";
            this.picUsuarioIcone.TabStop = false;
            // 
            // lblUsuarioNome
            // 
            resources.ApplyResources(this.lblUsuarioNome, "lblUsuarioNome");
            this.lblUsuarioNome.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioNome.Name = "lblUsuarioNome";
            // 
            // btnSair
            // 
            resources.ApplyResources(this.btnSair, "btnSair");
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.btnSair.Name = "btnSair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panMenu);
            this.IsMdiContainer = true;
            this.Name = "FormMenu";
            this.panMenu.ResumeLayout(false);
            this.panMenu.PerformLayout();
            this.panUsuario.ResumeLayout(false);
            this.panUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuarioIcone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.FlowLayoutPanel panUsuario;
        private System.Windows.Forms.PictureBox picUsuarioIcone;
        private System.Windows.Forms.Label lblUsuarioNome;
        private System.Windows.Forms.Button btnVisaoGeral;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnMaterias;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnNotas;
    }
}