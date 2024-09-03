using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadDos
{
    public partial class FormDos : Form
    {
        public FormDos()
        {
            InitializeComponent();
        }

       private void ValidarOk()
        {
            //Habilita el Botón, siempre y cuando txtNombre tenga datos.
            btn_ok.Enabled = (txt_nombre.BackColor != Color.Red);
        }

        private void txt_nombre_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox) sender;

            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;

                ValidarOk();
            }
        }

        private void FormDos_Load(object sender, EventArgs e)
        {
            //Deshabilito el Botón Ok.
            btn_ok.Enabled = false;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            //No valido datos ya que si el Botón esta Habilitado
            //es porque paso el Evento Validating del Nombre.

            string salida; //Declaro una variable para armar la salida.

            salida = "Nombre: " + txt_nombre.Text + "\r\n";
            salida += "Ocupacion: " + (string)(cBox_programador.Checked ? "Programador" : "No es Programador") + "\r\n";
            salida += "Sexo: " + (string)(rBt_hombre.Checked ? "Hombre" : "Mujer") + "\r\n";

            //Vuelco la salida al TextBox Salida.
            txtBox_salida.Text = salida;
        }
    }
}
