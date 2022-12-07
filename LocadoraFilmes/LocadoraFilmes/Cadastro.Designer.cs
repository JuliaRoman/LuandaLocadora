
namespace LocadoraFilmes
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.labelcadastro = new System.Windows.Forms.Label();
            this.btnTelaInicialCad = new System.Windows.Forms.Button();
            this.txtNomeCadastro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcpfCadastro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtsenhacadastro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsenhadnvcadastro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelcadastro
            // 
            this.labelcadastro.AutoSize = true;
            this.labelcadastro.Location = new System.Drawing.Point(370, 70);
            this.labelcadastro.Name = "labelcadastro";
            this.labelcadastro.Size = new System.Drawing.Size(49, 13);
            this.labelcadastro.TabIndex = 0;
            this.labelcadastro.Text = "Cadastro";
            this.labelcadastro.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnTelaInicialCad
            // 
            this.btnTelaInicialCad.Location = new System.Drawing.Point(64, 60);
            this.btnTelaInicialCad.Name = "btnTelaInicialCad";
            this.btnTelaInicialCad.Size = new System.Drawing.Size(75, 23);
            this.btnTelaInicialCad.TabIndex = 1;
            this.btnTelaInicialCad.Text = "Voltar";
            this.btnTelaInicialCad.UseVisualStyleBackColor = true;
            this.btnTelaInicialCad.Click += new System.EventHandler(this.btnTelaInicialCad_Click);
            // 
            // txtNomeCadastro
            // 
            this.txtNomeCadastro.Location = new System.Drawing.Point(73, 159);
            this.txtNomeCadastro.Name = "txtNomeCadastro";
            this.txtNomeCadastro.Size = new System.Drawing.Size(100, 20);
            this.txtNomeCadastro.TabIndex = 2;
            this.txtNomeCadastro.Tag = "";
            this.txtNomeCadastro.TextChanged += new System.EventHandler(this.txtNomeCadastro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite seu nome";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(78, 378);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Enviar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Digite seu CPF";
            // 
            // txtcpfCadastro
            // 
            this.txtcpfCadastro.Location = new System.Drawing.Point(73, 234);
            this.txtcpfCadastro.Name = "txtcpfCadastro";
            this.txtcpfCadastro.Size = new System.Drawing.Size(100, 20);
            this.txtcpfCadastro.TabIndex = 6;
            this.txtcpfCadastro.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Insira sua data de nascimento";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(73, 311);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtsenhacadastro
            // 
            this.txtsenhacadastro.Location = new System.Drawing.Point(450, 159);
            this.txtsenhacadastro.Name = "txtsenhacadastro";
            this.txtsenhacadastro.Size = new System.Drawing.Size(100, 20);
            this.txtsenhacadastro.TabIndex = 9;
            this.txtsenhacadastro.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Defina uma senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Digite a senha novamente";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtsenhadnvcadastro
            // 
            this.txtsenhadnvcadastro.Location = new System.Drawing.Point(450, 234);
            this.txtsenhadnvcadastro.Name = "txtsenhadnvcadastro";
            this.txtsenhadnvcadastro.Size = new System.Drawing.Size(100, 20);
            this.txtsenhadnvcadastro.TabIndex = 12;
            this.txtsenhadnvcadastro.Tag = "";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtsenhadnvcadastro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsenhacadastro);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcpfCadastro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeCadastro);
            this.Controls.Add(this.btnTelaInicialCad);
            this.Controls.Add(this.labelcadastro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastro";
            this.Text = "Tela de cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelcadastro;
        private System.Windows.Forms.Button btnTelaInicialCad;
        private System.Windows.Forms.TextBox txtNomeCadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcpfCadastro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtsenhacadastro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsenhadnvcadastro;
    }
}