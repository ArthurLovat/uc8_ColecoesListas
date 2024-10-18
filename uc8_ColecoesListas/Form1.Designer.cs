namespace uc8_ColecoesListas
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
            label1 = new Label();
            txtNome = new TextBox();
            btnAdicionar = new Button();
            txtLista = new TextBox();
            btnExcluir = new Button();
            label2 = new Label();
            txtNovoNome = new TextBox();
            brnAlterar = new Button();
            btnCrescente = new Button();
            btnDecrescente = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 40);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(94, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(94, 83);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(100, 23);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtLista
            // 
            txtLista.Location = new Point(266, 41);
            txtLista.Multiline = true;
            txtLista.Name = "txtLista";
            txtLista.ScrollBars = ScrollBars.Horizontal;
            txtLista.Size = new Size(100, 312);
            txtLista.TabIndex = 3;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(94, 112);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(100, 23);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 183);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 5;
            label2.Text = "Novo Nome";
            // 
            // txtNovoNome
            // 
            txtNovoNome.Location = new Point(94, 180);
            txtNovoNome.Name = "txtNovoNome";
            txtNovoNome.Size = new Size(100, 23);
            txtNovoNome.TabIndex = 6;
            // 
            // brnAlterar
            // 
            brnAlterar.Location = new Point(94, 209);
            brnAlterar.Name = "brnAlterar";
            brnAlterar.Size = new Size(100, 23);
            brnAlterar.TabIndex = 7;
            brnAlterar.Text = "Alterar";
            brnAlterar.UseVisualStyleBackColor = true;
            brnAlterar.Click += brnAlterar_Click;
            // 
            // btnCrescente
            // 
            btnCrescente.Location = new Point(94, 279);
            btnCrescente.Name = "btnCrescente";
            btnCrescente.Size = new Size(130, 23);
            btnCrescente.TabIndex = 8;
            btnCrescente.Text = "Order Crescente";
            btnCrescente.UseVisualStyleBackColor = true;
            btnCrescente.Click += btnCrescente_Click;
            // 
            // btnDecrescente
            // 
            btnDecrescente.Location = new Point(94, 330);
            btnDecrescente.Name = "btnDecrescente";
            btnDecrescente.Size = new Size(130, 23);
            btnDecrescente.TabIndex = 9;
            btnDecrescente.Text = "Ordem Decrescente";
            btnDecrescente.UseVisualStyleBackColor = true;
            btnDecrescente.Click += btnDecrescente_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 450);
            Controls.Add(btnDecrescente);
            Controls.Add(btnCrescente);
            Controls.Add(brnAlterar);
            Controls.Add(txtNovoNome);
            Controls.Add(label2);
            Controls.Add(btnExcluir);
            Controls.Add(txtLista);
            Controls.Add(btnAdicionar);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Button btnAdicionar;
        private TextBox txtLista;
        private Button btnExcluir;
        private Label label2;
        private TextBox txtNovoNome;
        private Button brnAlterar;
        private Button btnCrescente;
        private Button btnDecrescente;
    }
}
