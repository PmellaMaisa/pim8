namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.txt_endereço = new System.Windows.Forms.TextBox();
            this.lbl_endereço = new System.Windows.Forms.Label();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.bl_bairro = new System.Windows.Forms.Label();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.txt_cep = new System.Windows.Forms.TextBox();
            this.lbl_cep = new System.Windows.Forms.Label();
            this.btn_concluir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(187, 56);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(50, 20);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            this.lbl_nome.Click += new System.EventHandler(this.lblnome_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nome.Location = new System.Drawing.Point(265, 49);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(227, 27);
            this.txt_nome.TabIndex = 1;
            // 
            // txt_cpf
            // 
            this.txt_cpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cpf.Location = new System.Drawing.Point(265, 104);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(227, 27);
            this.txt_cpf.TabIndex = 3;
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(187, 111);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(33, 20);
            this.lbl_cpf.TabIndex = 2;
            this.lbl_cpf.Text = "CPF";
            this.lbl_cpf.Click += new System.EventHandler(this.lbl_cpf_Click);
            // 
            // txt_endereço
            // 
            this.txt_endereço.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_endereço.Location = new System.Drawing.Point(265, 157);
            this.txt_endereço.Name = "txt_endereço";
            this.txt_endereço.Size = new System.Drawing.Size(227, 27);
            this.txt_endereço.TabIndex = 5;
            // 
            // lbl_endereço
            // 
            this.lbl_endereço.AutoSize = true;
            this.lbl_endereço.Location = new System.Drawing.Point(187, 164);
            this.lbl_endereço.Name = "lbl_endereço";
            this.lbl_endereço.Size = new System.Drawing.Size(71, 20);
            this.lbl_endereço.TabIndex = 4;
            this.lbl_endereço.Text = "Endereço";
            this.lbl_endereço.Click += new System.EventHandler(this.lbl_endereço_Click);
            // 
            // txt_estado
            // 
            this.txt_estado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_estado.Location = new System.Drawing.Point(265, 216);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(227, 27);
            this.txt_estado.TabIndex = 7;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(187, 223);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(54, 20);
            this.lbl_estado.TabIndex = 6;
            this.lbl_estado.Text = "Estado";
            // 
            // txt_bairro
            // 
            this.txt_bairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_bairro.Location = new System.Drawing.Point(265, 261);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(227, 27);
            this.txt_bairro.TabIndex = 9;
            // 
            // bl_bairro
            // 
            this.bl_bairro.AutoSize = true;
            this.bl_bairro.Location = new System.Drawing.Point(188, 268);
            this.bl_bairro.Name = "bl_bairro";
            this.bl_bairro.Size = new System.Drawing.Size(49, 20);
            this.bl_bairro.TabIndex = 8;
            this.bl_bairro.Text = "Bairro";
            // 
            // txt_telefone
            // 
            this.txt_telefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_telefone.Location = new System.Drawing.Point(265, 310);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(227, 27);
            this.txt_telefone.TabIndex = 11;
            this.txt_telefone.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new System.Drawing.Point(187, 317);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(66, 20);
            this.lbl_telefone.TabIndex = 10;
            this.lbl_telefone.Text = "Telefone";
            this.lbl_telefone.Click += new System.EventHandler(this.lbltelefone_Click);
            // 
            // txt_cep
            // 
            this.txt_cep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cep.Location = new System.Drawing.Point(265, 360);
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(227, 27);
            this.txt_cep.TabIndex = 13;
            // 
            // lbl_cep
            // 
            this.lbl_cep.AutoSize = true;
            this.lbl_cep.Location = new System.Drawing.Point(188, 360);
            this.lbl_cep.Name = "lbl_cep";
            this.lbl_cep.Size = new System.Drawing.Size(34, 20);
            this.lbl_cep.TabIndex = 12;
            this.lbl_cep.Text = "CEP";
            this.lbl_cep.Click += new System.EventHandler(this.lbl_cep_Click);
            // 
            // btn_concluir
            // 
            this.btn_concluir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_concluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_concluir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_concluir.Location = new System.Drawing.Point(557, 429);
            this.btn_concluir.Name = "btn_concluir";
            this.btn_concluir.Size = new System.Drawing.Size(89, 33);
            this.btn_concluir.TabIndex = 14;
            this.btn_concluir.Text = "Concluir";
            this.btn_concluir.UseVisualStyleBackColor = false;
            this.btn_concluir.Click += new System.EventHandler(this.enviar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.Location = new System.Drawing.Point(676, 429);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(89, 33);
            this.btn_cancelar.TabIndex = 15;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_concluir);
            this.Controls.Add(this.txt_cep);
            this.Controls.Add(this.lbl_cep);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.lbl_telefone);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.bl_bairro);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.txt_endereço);
            this.Controls.Add(this.lbl_endereço);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Formulario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_nome;
        private TextBox txt_nome;
        private TextBox txt_cpf;
        private Label lbl_cpf;
        private TextBox txt_endereço;
        private Label lbl_endereço;
        private TextBox txt_estado;
        private Label lbl_estado;
        private TextBox txt_bairro;
        private Label bl_bairro;
        private TextBox txt_telefone;
        private Label lbl_telefone;
        private TextBox txt_cep;
        private Label lbl_cep;
        private Button btn_concluir;
        private Button btn_cancelar;
    }
}