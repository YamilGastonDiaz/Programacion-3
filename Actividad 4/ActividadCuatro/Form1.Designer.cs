namespace ActividadCuatro
{
    partial class Form1
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
            this.checkLB_uno = new System.Windows.Forms.CheckedListBox();
            this.btn_mover = new System.Windows.Forms.Button();
            this.listB_seleccinado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // checkLB_uno
            // 
            this.checkLB_uno.CheckOnClick = true;
            this.checkLB_uno.FormattingEnabled = true;
            this.checkLB_uno.Items.AddRange(new object[] {
            "Uno",
            "Dos",
            "Tres",
            "Cuatro",
            "Cinco",
            "Seis",
            "Siete",
            "Ocho",
            "Nueve"});
            this.checkLB_uno.Location = new System.Drawing.Point(26, 21);
            this.checkLB_uno.Name = "checkLB_uno";
            this.checkLB_uno.Size = new System.Drawing.Size(239, 319);
            this.checkLB_uno.TabIndex = 0;
            // 
            // btn_mover
            // 
            this.btn_mover.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mover.Location = new System.Drawing.Point(287, 162);
            this.btn_mover.Name = "btn_mover";
            this.btn_mover.Size = new System.Drawing.Size(75, 23);
            this.btn_mover.TabIndex = 1;
            this.btn_mover.Text = "Mover";
            this.btn_mover.UseVisualStyleBackColor = true;
            this.btn_mover.Click += new System.EventHandler(this.btn_mover_Click);
            // 
            // listB_seleccinado
            // 
            this.listB_seleccinado.FormattingEnabled = true;
            this.listB_seleccinado.Location = new System.Drawing.Point(390, 21);
            this.listB_seleccinado.Name = "listB_seleccinado";
            this.listB_seleccinado.Size = new System.Drawing.Size(234, 316);
            this.listB_seleccinado.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 369);
            this.Controls.Add(this.listB_seleccinado);
            this.Controls.Add(this.btn_mover);
            this.Controls.Add(this.checkLB_uno);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(670, 408);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(670, 408);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListBox y CheckedListBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkLB_uno;
        private System.Windows.Forms.Button btn_mover;
        private System.Windows.Forms.ListBox listB_seleccinado;
    }
}

