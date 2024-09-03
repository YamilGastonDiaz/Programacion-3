namespace ActividadDos
{
    partial class FormDos
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
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.cBox_programador = new System.Windows.Forms.CheckBox();
            this.gBox_sexo = new System.Windows.Forms.GroupBox();
            this.rBt_mujer = new System.Windows.Forms.RadioButton();
            this.rBt_hombre = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_salida = new System.Windows.Forms.TextBox();
            this.gBox_sexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(94, 10);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(373, 20);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.Validating += new System.ComponentModel.CancelEventHandler(this.txt_nombre_Validating);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(487, 8);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // cBox_programador
            // 
            this.cBox_programador.AutoSize = true;
            this.cBox_programador.Checked = true;
            this.cBox_programador.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBox_programador.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_programador.Location = new System.Drawing.Point(25, 55);
            this.cBox_programador.Name = "cBox_programador";
            this.cBox_programador.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cBox_programador.Size = new System.Drawing.Size(104, 22);
            this.cBox_programador.TabIndex = 4;
            this.cBox_programador.Text = "Programador";
            this.cBox_programador.UseVisualStyleBackColor = true;
            // 
            // gBox_sexo
            // 
            this.gBox_sexo.Controls.Add(this.rBt_mujer);
            this.gBox_sexo.Controls.Add(this.rBt_hombre);
            this.gBox_sexo.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox_sexo.ForeColor = System.Drawing.Color.Black;
            this.gBox_sexo.Location = new System.Drawing.Point(25, 93);
            this.gBox_sexo.Name = "gBox_sexo";
            this.gBox_sexo.Size = new System.Drawing.Size(442, 69);
            this.gBox_sexo.TabIndex = 5;
            this.gBox_sexo.TabStop = false;
            this.gBox_sexo.Text = "Sexo";
            // 
            // rBt_mujer
            // 
            this.rBt_mujer.AutoSize = true;
            this.rBt_mujer.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBt_mujer.Location = new System.Drawing.Point(269, 37);
            this.rBt_mujer.Name = "rBt_mujer";
            this.rBt_mujer.Size = new System.Drawing.Size(59, 21);
            this.rBt_mujer.TabIndex = 1;
            this.rBt_mujer.TabStop = true;
            this.rBt_mujer.Text = "Mujer";
            this.rBt_mujer.UseVisualStyleBackColor = true;
            // 
            // rBt_hombre
            // 
            this.rBt_hombre.AutoSize = true;
            this.rBt_hombre.Checked = true;
            this.rBt_hombre.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBt_hombre.Location = new System.Drawing.Point(69, 33);
            this.rBt_hombre.Name = "rBt_hombre";
            this.rBt_hombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rBt_hombre.Size = new System.Drawing.Size(67, 21);
            this.rBt_hombre.TabIndex = 0;
            this.rBt_hombre.TabStop = true;
            this.rBt_hombre.Text = "Hombre";
            this.rBt_hombre.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Salida";
            // 
            // txtBox_salida
            // 
            this.txtBox_salida.Location = new System.Drawing.Point(25, 190);
            this.txtBox_salida.Multiline = true;
            this.txtBox_salida.Name = "txtBox_salida";
            this.txtBox_salida.Size = new System.Drawing.Size(442, 148);
            this.txtBox_salida.TabIndex = 7;
            // 
            // FormDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 350);
            this.Controls.Add(this.txtBox_salida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gBox_sexo);
            this.Controls.Add(this.cBox_programador);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(596, 389);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(596, 389);
            this.Name = "FormDos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RadioButton y CheckBox";
            this.Load += new System.EventHandler(this.FormDos_Load);
            this.gBox_sexo.ResumeLayout(false);
            this.gBox_sexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.CheckBox cBox_programador;
        private System.Windows.Forms.GroupBox gBox_sexo;
        private System.Windows.Forms.RadioButton rBt_mujer;
        private System.Windows.Forms.RadioButton rBt_hombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_salida;
    }
}

