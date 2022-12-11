
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcpfCadastro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.campodatanasc = new System.Windows.Forms.DateTimePicker();
            this.camposenhacadastro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.camposenhadnvcadastro = new System.Windows.Forms.TextBox();
            this.btnVisualizarSenha = new System.Windows.Forms.Button();
            this.btnVisualizarConfirm = new System.Windows.Forms.Button();
            this.txtNomeCadastro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelcadastro
            // 
            this.labelcadastro.AutoSize = true;
            this.labelcadastro.BackColor = System.Drawing.Color.Purple;
            this.labelcadastro.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcadastro.ForeColor = System.Drawing.Color.White;
            this.labelcadastro.Location = new System.Drawing.Point(480, 84);
            this.labelcadastro.Name = "labelcadastro";
            this.labelcadastro.Size = new System.Drawing.Size(121, 42);
            this.labelcadastro.TabIndex = 0;
            this.labelcadastro.Text = "Cadastro";
            this.labelcadastro.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnTelaInicialCad
            // 
            this.btnTelaInicialCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTelaInicialCad.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaInicialCad.ForeColor = System.Drawing.Color.Black;
            this.btnTelaInicialCad.Location = new System.Drawing.Point(255, 110);
            this.btnTelaInicialCad.Name = "btnTelaInicialCad";
            this.btnTelaInicialCad.Size = new System.Drawing.Size(87, 31);
            this.btnTelaInicialCad.TabIndex = 1;
            this.btnTelaInicialCad.Text = "Voltar";
            this.btnTelaInicialCad.UseVisualStyleBackColor = false;
            this.btnTelaInicialCad.Click += new System.EventHandler(this.btnTelaInicialCad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.25F);
            this.label1.Location = new System.Drawing.Point(247, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite seu nome";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCadastrar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Location = new System.Drawing.Point(255, 418);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(87, 38);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Enviar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Digite seu CPF";
            // 
            // txtcpfCadastro
            // 
            this.txtcpfCadastro.Location = new System.Drawing.Point(250, 274);
            this.txtcpfCadastro.Name = "txtcpfCadastro";
            this.txtcpfCadastro.Size = new System.Drawing.Size(186, 20);
            this.txtcpfCadastro.TabIndex = 6;
            this.txtcpfCadastro.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Insira sua data de nascimento";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // campodatanasc
            // 
            this.campodatanasc.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campodatanasc.Location = new System.Drawing.Point(250, 351);
            this.campodatanasc.Name = "campodatanasc";
            this.campodatanasc.Size = new System.Drawing.Size(286, 30);
            this.campodatanasc.TabIndex = 8;
            this.campodatanasc.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // camposenhacadastro
            // 
            this.camposenhacadastro.Location = new System.Drawing.Point(627, 199);
            this.camposenhacadastro.Name = "camposenhacadastro";
            this.camposenhacadastro.Size = new System.Drawing.Size(186, 20);
            this.camposenhacadastro.TabIndex = 9;
            this.camposenhacadastro.Tag = "";
            this.camposenhacadastro.UseSystemPasswordChar = true;
            this.camposenhacadastro.TextChanged += new System.EventHandler(this.camposenhacadastro_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(624, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Defina uma senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(624, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Digite a senha novamente";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // camposenhadnvcadastro
            // 
            this.camposenhadnvcadastro.Location = new System.Drawing.Point(627, 274);
            this.camposenhadnvcadastro.Name = "camposenhadnvcadastro";
            this.camposenhadnvcadastro.Size = new System.Drawing.Size(186, 20);
            this.camposenhadnvcadastro.TabIndex = 12;
            this.camposenhadnvcadastro.Tag = "";
            this.camposenhadnvcadastro.UseSystemPasswordChar = true;
            // 
            // btnVisualizarSenha
            // 
            this.btnVisualizarSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVisualizarSenha.Image = global::LocadoraFilmes.Properties.Resources.olho;
            this.btnVisualizarSenha.Location = new System.Drawing.Point(819, 199);
            this.btnVisualizarSenha.Name = "btnVisualizarSenha";
            this.btnVisualizarSenha.Size = new System.Drawing.Size(26, 20);
            this.btnVisualizarSenha.TabIndex = 16;
            this.btnVisualizarSenha.UseVisualStyleBackColor = true;
            this.btnVisualizarSenha.Click += new System.EventHandler(this.btnVisualizarSenha_Click);
            // 
            // btnVisualizarConfirm
            // 
            this.btnVisualizarConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVisualizarConfirm.Image = global::LocadoraFilmes.Properties.Resources.olho;
            this.btnVisualizarConfirm.Location = new System.Drawing.Point(819, 274);
            this.btnVisualizarConfirm.Name = "btnVisualizarConfirm";
            this.btnVisualizarConfirm.Size = new System.Drawing.Size(26, 20);
            this.btnVisualizarConfirm.TabIndex = 17;
            this.btnVisualizarConfirm.UseVisualStyleBackColor = true;
            this.btnVisualizarConfirm.Click += new System.EventHandler(this.btnVisualizarConfirm_Click);
            // 
            // txtNomeCadastro
            // 
            this.txtNomeCadastro.Location = new System.Drawing.Point(250, 200);
            this.txtNomeCadastro.Name = "txtNomeCadastro";
            this.txtNomeCadastro.Size = new System.Drawing.Size(186, 20);
            this.txtNomeCadastro.TabIndex = 18;
            this.txtNomeCadastro.Tag = "";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1129, 593);
            this.Controls.Add(this.txtNomeCadastro);
            this.Controls.Add(this.btnVisualizarConfirm);
            this.Controls.Add(this.btnVisualizarSenha);
            this.Controls.Add(this.camposenhadnvcadastro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.camposenhacadastro);
            this.Controls.Add(this.campodatanasc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcpfCadastro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTelaInicialCad);
            this.Controls.Add(this.labelcadastro);
            this.ForeColor = System.Drawing.Color.White;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcpfCadastro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker campodatanasc;
        private System.Windows.Forms.TextBox camposenhacadastro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox camposenhadnvcadastro;
        private System.Windows.Forms.Button btnVisualizarSenha;
        private System.Windows.Forms.Button btnVisualizarConfirm;
        private System.Windows.Forms.TextBox txtNomeCadastro;
    }
}