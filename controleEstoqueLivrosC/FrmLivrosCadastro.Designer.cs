namespace controleEstoqueLivrosC
{
    partial class FrmLivrosCadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtPrecoUnitario = new System.Windows.Forms.TextBox();
            this.txtSaldoInicial = new System.Windows.Forms.TextBox();
            this.txtEstoqueMinimo = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cnkAtivo = new System.Windows.Forms.CheckBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ISBN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Titulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Autor(es)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Preço Unitário";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estoque minimo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Saldo Inicial";
            // 
            // lblId
            // 
            this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblId.Location = new System.Drawing.Point(171, 35);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(121, 26);
            this.lblId.TabIndex = 7;
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(169, 78);
            this.txtIsbn.MaxLength = 25;
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(149, 20);
            this.txtIsbn.TabIndex = 8;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(169, 137);
            this.txtTitulo.MaxLength = 150;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(236, 20);
            this.txtTitulo.TabIndex = 9;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(169, 188);
            this.txtAutor.MaxLength = 150;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(236, 20);
            this.txtAutor.TabIndex = 10;
            // 
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.Location = new System.Drawing.Point(171, 233);
            this.txtPrecoUnitario.MaxLength = 12;
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.Size = new System.Drawing.Size(147, 20);
            this.txtPrecoUnitario.TabIndex = 11;
            // 
            // txtSaldoInicial
            // 
            this.txtSaldoInicial.Location = new System.Drawing.Point(171, 284);
            this.txtSaldoInicial.MaxLength = 12;
            this.txtSaldoInicial.Name = "txtSaldoInicial";
            this.txtSaldoInicial.Size = new System.Drawing.Size(100, 20);
            this.txtSaldoInicial.TabIndex = 12;
            // 
            // txtEstoqueMinimo
            // 
            this.txtEstoqueMinimo.Location = new System.Drawing.Point(442, 287);
            this.txtEstoqueMinimo.MaxLength = 12;
            this.txtEstoqueMinimo.Name = "txtEstoqueMinimo";
            this.txtEstoqueMinimo.Size = new System.Drawing.Size(100, 20);
            this.txtEstoqueMinimo.TabIndex = 13;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(286, 381);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(97, 34);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cnkAtivo
            // 
            this.cnkAtivo.AutoSize = true;
            this.cnkAtivo.Location = new System.Drawing.Point(77, 350);
            this.cnkAtivo.Name = "cnkAtivo";
            this.cnkAtivo.Size = new System.Drawing.Size(50, 17);
            this.cnkAtivo.TabIndex = 15;
            this.cnkAtivo.Text = "Ativo";
            this.cnkAtivo.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(460, 381);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(97, 34);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // FrmLivrosCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.cnkAtivo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtEstoqueMinimo);
            this.Controls.Add(this.txtSaldoInicial);
            this.Controls.Add(this.txtPrecoUnitario);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmLivrosCadastro";
            this.Text = "FrmLivrosCadastro";
            this.Load += new System.EventHandler(this.FrmLivrosCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtPrecoUnitario;
        private System.Windows.Forms.TextBox txtSaldoInicial;
        private System.Windows.Forms.TextBox txtEstoqueMinimo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.CheckBox cnkAtivo;
        private System.Windows.Forms.Button btnExcluir;
    }
}