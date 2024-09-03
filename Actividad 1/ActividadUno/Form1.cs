using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadUno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_apellido.Text == "")
            {
                txt_apellido.BackColor = Color.Red;
            }
            if (txt_nombre.Text == "")
            {
                txt_nombre.BackColor = Color.Red;
            }
            if(txt_edad.Text == "")
            {
                txt_edad.BackColor = Color.Red;
            }
            if (txt_direccion.Text == ""){
                txt_direccion.BackColor = Color.Red;
            } 

            if(txt_apellido.Text != "" && txt_nombre.Text != "" && txt_edad.Text != "" && txt_direccion.Text != "")
            {
                string nombreCompleto = txt_apellido.Text + " " + txt_nombre.Text;
                string edad = txt_edad.Text;
                string direccion = txt_direccion.Text;

                txt_resultado.Text = "APELLIDO Y NOMBRE: " + nombreCompleto + Environment.NewLine + "EDAD: " + edad + Environment.NewLine + "DIRECCION: " + direccion;
            }             
        }

        private void txt_edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 97 || e.KeyChar > 122) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 97 || e.KeyChar > 122) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void txt_direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 97 || e.KeyChar > 122) && (e.KeyChar < 48 || e.KeyChar > 57)) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
