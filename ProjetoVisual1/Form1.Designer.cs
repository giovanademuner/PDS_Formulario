namespace ProjetoVisual1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MENU = new System.Windows.Forms.Label();
            this.btCadastro = new System.Windows.Forms.Button();
            this.btListar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MENU
            // 
            this.MENU.AutoSize = true;
            this.MENU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MENU.Location = new System.Drawing.Point(321, 19);
            this.MENU.Name = "MENU";
            this.MENU.Size = new System.Drawing.Size(145, 24);
            this.MENU.TabIndex = 1;
            this.MENU.Text = "MENU INICIAL";
            // 
            // btCadastro
            // 
            this.btCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastro.Location = new System.Drawing.Point(255, 155);
            this.btCadastro.Name = "btCadastro";
            this.btCadastro.Size = new System.Drawing.Size(261, 62);
            this.btCadastro.TabIndex = 2;
            this.btCadastro.Text = "CADASTRO DE CONTATO";
            this.btCadastro.UseVisualStyleBackColor = true;
            this.btCadastro.Click += new System.EventHandler(this.btCadastro_Click);
            // 
            // btListar
            // 
            this.btListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListar.Location = new System.Drawing.Point(255, 236);
            this.btListar.Name = "btListar";
            this.btListar.Size = new System.Drawing.Size(261, 64);
            this.btListar.TabIndex = 4;
            this.btListar.Text = "LISTAR CONTATOS";
            this.btListar.UseVisualStyleBackColor = true;
            this.btListar.Click += new System.EventHandler(this.btListar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btListar);
            this.Controls.Add(this.btCadastro);
            this.Controls.Add(this.MENU);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MENU;
        private System.Windows.Forms.Button btCadastro;
        private System.Windows.Forms.Button btListar;
    }
}

