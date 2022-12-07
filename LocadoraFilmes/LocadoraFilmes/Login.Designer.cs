
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
            this.btnTelaLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcpfCadastro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsenhalogin = new System.Windows.Forms.TextBox();
            this.btnentrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTelaLogin
            // 
            this.btnTelaLogin.Location = new System.Drawing.Point(72, 53);
            this.btnTelaLogin.Name = "btnTelaLogin";
            this.btnTelaLogin.Size = new System.Drawing.Size(75, 23);
            this.btnTelaLogin.TabIndex = 0;
            this.btnTelaLogin.Text = "Voltar";
            this.btnTelaLogin.UseVisualStyleBackColor = true;
            this.btnTelaLogin.Click += new System.EventHandler(this.btnTelaInicialLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Digite seu CPF";
            // 
            // txtcpfCadastro
            // 
            this.txtcpfCadastro.Location = new System.Drawing.Point(72, 163);
            this.txtcpfCadastro.Name = "txtcpfCadastro";
            this.txtcpfCadastro.Size = new System.Drawing.Size(100, 20);
            this.txtcpfCadastro.TabIndex = 7;
            this.txtcpfCadastro.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Digite sua senha";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtsenhalogin
            // 
            this.txtsenhalogin.Location = new System.Drawing.Point(73, 254);
            this.txtsenhalogin.Name = "txtsenhalogin";
            this.txtsenhalogin.Size = new System.Drawing.Size(100, 20);
            this.txtsenhalogin.TabIndex = 12;
            this.txtsenhalogin.Tag = "";
            // 
            // btnentrar
            // 
            this.btnentrar.Location = new System.Drawing.Point(73, 333);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(75, 23);
            this.btnentrar.TabIndex = 13;
            this.btnentrar.Text = "Entrar";
            this.btnentrar.UseVisualStyleBackColor = true;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.txtsenhalogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcpfCadastro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTelaLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTelaLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcpfCadastro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsenhalogin;
        private System.Windows.Forms.Button btnentrar;
    }
}