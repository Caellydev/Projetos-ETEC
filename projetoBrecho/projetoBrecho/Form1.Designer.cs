namespace projetoBrecho
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
            this.produtoBox = new System.Windows.Forms.TextBox();
            this.precoBox = new System.Windows.Forms.TextBox();
            this.produtoText = new System.Windows.Forms.Label();
            this.precoText = new System.Windows.Forms.Label();
            this.categoriaProducts = new System.Windows.Forms.ComboBox();
            this.disponibilidade = new System.Windows.Forms.CheckBox();
            this.dataDeEnvio = new System.Windows.Forms.DateTimePicker();
            this.botaoEnvio = new System.Windows.Forms.Button();
            this.botaoClear = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // produtoBox
            // 
            this.produtoBox.BackColor = System.Drawing.Color.Peru;
            this.produtoBox.Location = new System.Drawing.Point(198, 144);
            this.produtoBox.Name = "produtoBox";
            this.produtoBox.Size = new System.Drawing.Size(160, 20);
            this.produtoBox.TabIndex = 0;
            this.produtoBox.TextChanged += new System.EventHandler(this.produtoBox_TextChanged);
            // 
            // precoBox
            // 
            this.precoBox.BackColor = System.Drawing.Color.Peru;
            this.precoBox.Location = new System.Drawing.Point(428, 144);
            this.precoBox.Name = "precoBox";
            this.precoBox.Size = new System.Drawing.Size(128, 20);
            this.precoBox.TabIndex = 1;
            this.precoBox.TextChanged += new System.EventHandler(this.precoBox_TextChanged);
            // 
            // produtoText
            // 
            this.produtoText.AutoSize = true;
            this.produtoText.BackColor = System.Drawing.Color.Peru;
            this.produtoText.Font = new System.Drawing.Font("Harlow Solid Italic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produtoText.ForeColor = System.Drawing.Color.SaddleBrown;
            this.produtoText.Location = new System.Drawing.Point(223, 116);
            this.produtoText.Name = "produtoText";
            this.produtoText.Size = new System.Drawing.Size(107, 17);
            this.produtoText.TabIndex = 2;
            this.produtoText.Text = "Nome do produto";
            this.produtoText.Click += new System.EventHandler(this.produtoText_Click);
            // 
            // precoText
            // 
            this.precoText.AutoSize = true;
            this.precoText.Font = new System.Drawing.Font("Harlow Solid Italic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precoText.ForeColor = System.Drawing.Color.SaddleBrown;
            this.precoText.Location = new System.Drawing.Point(467, 116);
            this.precoText.Name = "precoText";
            this.precoText.Size = new System.Drawing.Size(42, 17);
            this.precoText.TabIndex = 3;
            this.precoText.Text = "Preço";
            this.precoText.Click += new System.EventHandler(this.precoText_Click);
            // 
            // categoriaProducts
            // 
            this.categoriaProducts.BackColor = System.Drawing.Color.SaddleBrown;
            this.categoriaProducts.FormattingEnabled = true;
            this.categoriaProducts.Location = new System.Drawing.Point(405, 199);
            this.categoriaProducts.Name = "categoriaProducts";
            this.categoriaProducts.Size = new System.Drawing.Size(121, 21);
            this.categoriaProducts.TabIndex = 4;
            this.categoriaProducts.SelectedIndexChanged += new System.EventHandler(this.categoriaProducts_SelectedIndexChanged);
            // 
            // disponibilidade
            // 
            this.disponibilidade.AutoSize = true;
            this.disponibilidade.Font = new System.Drawing.Font("Harlow Solid Italic", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disponibilidade.ForeColor = System.Drawing.Color.SaddleBrown;
            this.disponibilidade.Location = new System.Drawing.Point(272, 203);
            this.disponibilidade.Name = "disponibilidade";
            this.disponibilidade.Size = new System.Drawing.Size(109, 20);
            this.disponibilidade.TabIndex = 5;
            this.disponibilidade.Text = "Disponibilidade";
            this.disponibilidade.UseVisualStyleBackColor = true;
            // 
            // dataDeEnvio
            // 
            this.dataDeEnvio.Location = new System.Drawing.Point(272, 298);
            this.dataDeEnvio.Name = "dataDeEnvio";
            this.dataDeEnvio.Size = new System.Drawing.Size(217, 20);
            this.dataDeEnvio.TabIndex = 6;
            this.dataDeEnvio.ValueChanged += new System.EventHandler(this.dataDeEnvio_ValueChanged);
            // 
            // botaoEnvio
            // 
            this.botaoEnvio.BackColor = System.Drawing.Color.PeachPuff;
            this.botaoEnvio.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoEnvio.ForeColor = System.Drawing.Color.SaddleBrown;
            this.botaoEnvio.Location = new System.Drawing.Point(236, 358);
            this.botaoEnvio.Name = "botaoEnvio";
            this.botaoEnvio.Size = new System.Drawing.Size(110, 29);
            this.botaoEnvio.TabIndex = 7;
            this.botaoEnvio.Text = "Registrar envio";
            this.botaoEnvio.UseVisualStyleBackColor = false;
            this.botaoEnvio.Click += new System.EventHandler(this.botaoEnvio_Click);
            // 
            // botaoClear
            // 
            this.botaoClear.BackColor = System.Drawing.Color.PeachPuff;
            this.botaoClear.Font = new System.Drawing.Font("Elephant", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoClear.ForeColor = System.Drawing.Color.SaddleBrown;
            this.botaoClear.Location = new System.Drawing.Point(416, 358);
            this.botaoClear.Name = "botaoClear";
            this.botaoClear.Size = new System.Drawing.Size(110, 29);
            this.botaoClear.TabIndex = 8;
            this.botaoClear.Text = "Limpar";
            this.botaoClear.UseVisualStyleBackColor = false;
            this.botaoClear.Click += new System.EventHandler(this.botaoClear_Click);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Elephant", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.Transparent;
            this.titulo.Location = new System.Drawing.Point(332, 61);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(106, 33);
            this.titulo.TabIndex = 9;
            this.titulo.Text = "Brechó";
            this.titulo.Click += new System.EventHandler(this.titulo_Click);
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.BackColor = System.Drawing.Color.Peru;
            this.Data.Font = new System.Drawing.Font("Harlow Solid Italic", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Data.Location = new System.Drawing.Point(334, 260);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(104, 22);
            this.Data.TabIndex = 10;
            this.Data.Text = "Data de envio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.botaoClear);
            this.Controls.Add(this.botaoEnvio);
            this.Controls.Add(this.dataDeEnvio);
            this.Controls.Add(this.disponibilidade);
            this.Controls.Add(this.categoriaProducts);
            this.Controls.Add(this.precoText);
            this.Controls.Add(this.produtoText);
            this.Controls.Add(this.precoBox);
            this.Controls.Add(this.produtoBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox produtoBox;
        private System.Windows.Forms.TextBox precoBox;
        private System.Windows.Forms.Label produtoText;
        private System.Windows.Forms.Label precoText;
        private System.Windows.Forms.ComboBox categoriaProducts;
        private System.Windows.Forms.CheckBox disponibilidade;
        private System.Windows.Forms.DateTimePicker dataDeEnvio;
        private System.Windows.Forms.Button botaoEnvio;
        private System.Windows.Forms.Button botaoClear;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label Data;
    }
}

