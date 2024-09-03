namespace ActividadCinco
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView_uno = new System.Windows.Forms.ListView();
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.lbl_directorioA = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtn_titulo = new System.Windows.Forms.RadioButton();
            this.rBtn_detalle = new System.Windows.Forms.RadioButton();
            this.rBtn_lista = new System.Windows.Forms.RadioButton();
            this.rBtn_iconS = new System.Windows.Forms.RadioButton();
            this.rBtn_iconL = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_uno
            // 
            this.listView_uno.HideSelection = false;
            this.listView_uno.LargeImageList = this.imageListLarge;
            this.listView_uno.Location = new System.Drawing.Point(12, 39);
            this.listView_uno.Name = "listView_uno";
            this.listView_uno.Size = new System.Drawing.Size(527, 295);
            this.listView_uno.SmallImageList = this.imageListSmall;
            this.listView_uno.TabIndex = 0;
            this.listView_uno.UseCompatibleStateImageBehavior = false;
            this.listView_uno.View = System.Windows.Forms.View.Details;
            this.listView_uno.ItemActivate += new System.EventHandler(this.listView_uno_ItemActivate);
            // 
            // imageListLarge
            // 
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLarge.Images.SetKeyName(0, "file_32.png");
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "file_16.png");
            // 
            // lbl_directorioA
            // 
            this.lbl_directorioA.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_directorioA.Location = new System.Drawing.Point(13, 13);
            this.lbl_directorioA.Name = "lbl_directorioA";
            this.lbl_directorioA.Size = new System.Drawing.Size(530, 23);
            this.lbl_directorioA.TabIndex = 1;
            this.lbl_directorioA.Text = "Directorio Actual";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(214, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtn_titulo);
            this.groupBox1.Controls.Add(this.rBtn_detalle);
            this.groupBox1.Controls.Add(this.rBtn_lista);
            this.groupBox1.Controls.Add(this.rBtn_iconS);
            this.groupBox1.Controls.Add(this.rBtn_iconL);
            this.groupBox1.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(583, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 295);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modo de vista";
            // 
            // rBtn_titulo
            // 
            this.rBtn_titulo.AutoSize = true;
            this.rBtn_titulo.Location = new System.Drawing.Point(39, 151);
            this.rBtn_titulo.Name = "rBtn_titulo";
            this.rBtn_titulo.Size = new System.Drawing.Size(57, 20);
            this.rBtn_titulo.TabIndex = 4;
            this.rBtn_titulo.Text = "Titulo";
            this.rBtn_titulo.UseVisualStyleBackColor = true;
            this.rBtn_titulo.CheckedChanged += new System.EventHandler(this.rBtn_titulo_CheckedChanged);
            // 
            // rBtn_detalle
            // 
            this.rBtn_detalle.AutoSize = true;
            this.rBtn_detalle.Checked = true;
            this.rBtn_detalle.Location = new System.Drawing.Point(39, 124);
            this.rBtn_detalle.Name = "rBtn_detalle";
            this.rBtn_detalle.Size = new System.Drawing.Size(63, 20);
            this.rBtn_detalle.TabIndex = 3;
            this.rBtn_detalle.TabStop = true;
            this.rBtn_detalle.Text = "Detalle";
            this.rBtn_detalle.UseVisualStyleBackColor = true;
            this.rBtn_detalle.CheckedChanged += new System.EventHandler(this.rBtn_detalle_CheckedChanged);
            // 
            // rBtn_lista
            // 
            this.rBtn_lista.AutoSize = true;
            this.rBtn_lista.Location = new System.Drawing.Point(39, 97);
            this.rBtn_lista.Name = "rBtn_lista";
            this.rBtn_lista.Size = new System.Drawing.Size(51, 20);
            this.rBtn_lista.TabIndex = 2;
            this.rBtn_lista.Text = "Lista";
            this.rBtn_lista.UseVisualStyleBackColor = true;
            this.rBtn_lista.CheckedChanged += new System.EventHandler(this.rBtn_lista_CheckedChanged);
            // 
            // rBtn_iconS
            // 
            this.rBtn_iconS.AutoSize = true;
            this.rBtn_iconS.Location = new System.Drawing.Point(39, 70);
            this.rBtn_iconS.Name = "rBtn_iconS";
            this.rBtn_iconS.Size = new System.Drawing.Size(81, 20);
            this.rBtn_iconS.TabIndex = 1;
            this.rBtn_iconS.Text = "Small Icon";
            this.rBtn_iconS.UseVisualStyleBackColor = true;
            this.rBtn_iconS.CheckedChanged += new System.EventHandler(this.rBtn_iconS_CheckedChanged);
            // 
            // rBtn_iconL
            // 
            this.rBtn_iconL.AutoSize = true;
            this.rBtn_iconL.Location = new System.Drawing.Point(39, 43);
            this.rBtn_iconL.Name = "rBtn_iconL";
            this.rBtn_iconL.Size = new System.Drawing.Size(81, 20);
            this.rBtn_iconL.TabIndex = 0;
            this.rBtn_iconL.Text = "Large Icon";
            this.rBtn_iconL.UseVisualStyleBackColor = true;
            this.rBtn_iconL.CheckedChanged += new System.EventHandler(this.rBtn_iconL_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 375);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_directorioA);
            this.Controls.Add(this.listView_uno);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_uno;
        private System.Windows.Forms.Label lbl_directorioA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBtn_titulo;
        private System.Windows.Forms.RadioButton rBtn_detalle;
        private System.Windows.Forms.RadioButton rBtn_lista;
        private System.Windows.Forms.RadioButton rBtn_iconS;
        private System.Windows.Forms.RadioButton rBtn_iconL;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.ImageList imageListLarge;
    }
}

