namespace ActividadTres
{
    partial class rich_txtBox
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
            this.btn_negrita = new System.Windows.Forms.Button();
            this.btn_subrayado = new System.Windows.Forms.Button();
            this.btn_cursiva = new System.Windows.Forms.Button();
            this.btn_centrado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_fuente = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_abrir = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_negrita
            // 
            this.btn_negrita.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_negrita.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_negrita.Location = new System.Drawing.Point(61, 14);
            this.btn_negrita.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_negrita.Name = "btn_negrita";
            this.btn_negrita.Size = new System.Drawing.Size(88, 27);
            this.btn_negrita.TabIndex = 0;
            this.btn_negrita.Text = "Negrita";
            this.btn_negrita.UseVisualStyleBackColor = true;
            this.btn_negrita.Click += new System.EventHandler(this.btn_negrita_Click);
            // 
            // btn_subrayado
            // 
            this.btn_subrayado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_subrayado.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subrayado.Location = new System.Drawing.Point(247, 14);
            this.btn_subrayado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_subrayado.Name = "btn_subrayado";
            this.btn_subrayado.Size = new System.Drawing.Size(88, 27);
            this.btn_subrayado.TabIndex = 1;
            this.btn_subrayado.Text = "Subrayado";
            this.btn_subrayado.UseVisualStyleBackColor = true;
            this.btn_subrayado.Click += new System.EventHandler(this.btn_subrayado_Click);
            // 
            // btn_cursiva
            // 
            this.btn_cursiva.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_cursiva.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cursiva.Location = new System.Drawing.Point(442, 14);
            this.btn_cursiva.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_cursiva.Name = "btn_cursiva";
            this.btn_cursiva.Size = new System.Drawing.Size(88, 27);
            this.btn_cursiva.TabIndex = 2;
            this.btn_cursiva.Text = "Cursiva";
            this.btn_cursiva.UseVisualStyleBackColor = true;
            this.btn_cursiva.Click += new System.EventHandler(this.btn_cursiva_Click);
            // 
            // btn_centrado
            // 
            this.btn_centrado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_centrado.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_centrado.Location = new System.Drawing.Point(624, 14);
            this.btn_centrado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_centrado.Name = "btn_centrado";
            this.btn_centrado.Size = new System.Drawing.Size(88, 27);
            this.btn_centrado.TabIndex = 3;
            this.btn_centrado.Text = "Centrado";
            this.btn_centrado.UseVisualStyleBackColor = true;
            this.btn_centrado.Click += new System.EventHandler(this.btn_centrado_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tamaño Fuente";
            // 
            // txtBox_fuente
            // 
            this.txtBox_fuente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBox_fuente.Location = new System.Drawing.Point(343, 68);
            this.txtBox_fuente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBox_fuente.MaxLength = 2;
            this.txtBox_fuente.Name = "txtBox_fuente";
            this.txtBox_fuente.Size = new System.Drawing.Size(116, 23);
            this.txtBox_fuente.TabIndex = 5;
            this.txtBox_fuente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_fuente_KeyPress);
            this.txtBox_fuente.Validated += new System.EventHandler(this.txtBox_fuente_Validated);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_guardar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(247, 445);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(88, 27);
            this.btn_guardar.TabIndex = 7;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_abrir
            // 
            this.btn_abrir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_abrir.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_abrir.Location = new System.Drawing.Point(442, 445);
            this.btn_abrir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_abrir.Name = "btn_abrir";
            this.btn_abrir.Size = new System.Drawing.Size(88, 27);
            this.btn_abrir.TabIndex = 8;
            this.btn_abrir.Text = "Abrir";
            this.btn_abrir.UseVisualStyleBackColor = true;
            this.btn_abrir.Click += new System.EventHandler(this.btn_abrir_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(28, 107);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(756, 332);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            this.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox1_LinkClicked);
            // 
            // rich_txtBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 479);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_abrir);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txtBox_fuente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_centrado);
            this.Controls.Add(this.btn_cursiva);
            this.Controls.Add(this.btn_subrayado);
            this.Controls.Add(this.btn_negrita);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(828, 518);
            this.Name = "rich_txtBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RichTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_negrita;
        private System.Windows.Forms.Button btn_subrayado;
        private System.Windows.Forms.Button btn_cursiva;
        private System.Windows.Forms.Button btn_centrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_fuente;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_abrir;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

