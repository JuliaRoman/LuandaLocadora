
namespace LocadoraFilmes
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnTelaLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.campoSenhalogin = new System.Windows.Forms.TextBox();
            this.btnentrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVisualizarLogin = new System.Windows.Forms.Button();
            this.campoCpfLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTelaLogin
            // 
            this.btnTelaLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTelaLogin.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.25F);
            this.btnTelaLogin.ForeColor = System.Drawing.Color.Black;
            this.btnTelaLogin.Location = new System.Drawing.Point(522, 450);
            this.btnTelaLogin.Name = "btnTelaLogin";
            this.btnTelaLogin.Size = new System.Drawing.Size(99, 35);
            this.btnTelaLogin.TabIndex = 0;
            this.btnTelaLogin.Text = "Voltar";
            this.btnTelaLogin.UseVisualStyleBackColor = false;
            this.btnTelaLogin.Click += new System.EventHandler(this.btnTelaInicialLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 23.25F);
            this.label2.Location = new System.Drawing.Point(494, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Digite seu CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 23.25F);
            this.label4.Location = new System.Drawing.Point(485, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 37);
            this.label4.TabIndex = 11;
            this.label4.Text = "Digite sua senha";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // campoSenhalogin
            // 
            this.campoSenhalogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.campoSenhalogin.Location = new System.Drawing.Point(478, 318);
            this.campoSenhalogin.Name = "campoSenhalogin";
            this.campoSenhalogin.Size = new System.Drawing.Size(162, 32);
            this.campoSenhalogin.TabIndex = 12;
            this.campoSenhalogin.Tag = "";
            this.campoSenhalogin.UseSystemPasswordChar = true;
            // 
            // btnentrar
            // 
            this.btnentrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnentrar.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.25F);
            this.btnentrar.ForeColor = System.Drawing.Color.Black;
            this.btnentrar.Location = new System.Drawing.Point(522, 379);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(99, 35);
            this.btnentrar.TabIndex = 13;
            this.btnentrar.Text = "Entrar";
            this.btnentrar.UseVisualStyleBackColor = false;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 30.25F);
            this.label1.Location = new System.Drawing.Point(527, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 49);
            this.label1.TabIndex = 14;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnVisualizarLogin
            // 
            this.btnVisualizarLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVisualizarLogin.Image = global::LocadoraFilmes.Properties.Resources.olho;
            this.btnVisualizarLogin.Location = new System.Drawing.Point(646, 318);
            this.btnVisualizarLogin.Name = "btnVisualizarLogin";
            this.btnVisualizarLogin.Size = new System.Drawing.Size(30, 32);
            this.btnVisualizarLogin.TabIndex = 15;
            this.btnVisualizarLogin.UseVisualStyleBackColor = true;
            this.btnVisualizarLogin.Click += new System.EventHandler(this.btnVisualizarLogin_Click);
            // 
            // campoCpfLogin
            // 
            this.campoCpfLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.campoCpfLogin.Location = new System.Drawing.Point(492, 215);
            this.campoCpfLogin.Name = "campoCpfLogin";
            this.campoCpfLogin.Size = new System.Drawing.Size(162, 32);
            this.campoCpfLogin.TabIndex = 16;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1129, 593);
            this.Controls.Add(this.campoCpfLogin);
            this.Controls.Add(this.btnVisualizarLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.campoSenhalogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTelaLogin);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTelaLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox campoSenhalogin;
        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVisualizarLogin;
        private System.Windows.Forms.TextBox campoCpfLogin;
    }
}