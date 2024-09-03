using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadTres
{
    public partial class rich_txtBox : Form
    {
        public rich_txtBox()
        {
            InitializeComponent();
        }

        private void btn_negrita_Click(object sender, EventArgs e)
        {
            Font viejaFuente;//Declaro una variable Class Font para la Fuente Vieja.
            Font nuevaFuente;//Declaro una variable Class Font para la Fuente Nueva.


            //Asigno a viejaFuente el tipo de fuente seleccionado.
            //Obtengo el tipo de Fuente atravez de la Propiedad SelectionFont
            //del Control RichTextBox.
            viejaFuente = richTextBox1.SelectionFont;

            if (viejaFuente.Bold)//Pregunto si ya es Negrita. 
            {
                //Si ya Tenia Negrita, establece nuevaFuente sin Negrita.
                nuevaFuente = new Font(viejaFuente, viejaFuente.Style & ~FontStyle.Bold);
            }
            else
            {
                //Si no Tenia Negrita, establece nuevaFuente con Negrita.
                nuevaFuente = new Font(viejaFuente, viejaFuente.Style | FontStyle.Bold);
            }

            //Establezco la nuevaFuente a la Selección.
            richTextBox1.SelectionFont = nuevaFuente;

            //Realizo un foco para posicionarme en el Control.
            richTextBox1.Focus();
        }

        private void btn_subrayado_Click(object sender, EventArgs e)
        {
            Font viejaFuente;//Declaro una variable Class Font para la Fuente Vieja.
            Font nuevaFuente;//Declaro una variable Class Font para la Fuente Nueva.


            //Asigno a viejaFuente el tipo de fuente seleccionado.
            //Obtengo el tipo de Fuente atravez de la Propiedad SelectionFont
            //del Control RichTextBox.
            viejaFuente = richTextBox1.SelectionFont;

            if (viejaFuente.Underline)//Pregunto si ya es Subrayado.
            {
                //Si ya Tenia Subrayado, establece nuevaFuente sin Subrayado.
                nuevaFuente = new Font(viejaFuente, viejaFuente.Style & ~FontStyle.Underline);
            }
            else
            {
                //Si no Tenia Subrayado, establece nuevaFuente con Subrayado.
                nuevaFuente = new Font(viejaFuente, viejaFuente.Style | FontStyle.Underline);
            }

            //Establezco la nuevaFuente a la Selección.
            richTextBox1.SelectionFont = nuevaFuente;

            //Realizo un foco para posicionarme en el Control.
            richTextBox1.Focus();
        }

        private void btn_cursiva_Click(object sender, EventArgs e)
        {
            Font viejaFuente;//Declaro una variable Class Font para la Fuente Vieja.
            Font nuevaFuente;//Declaro una variable Class Font para la Fuente Nueva.


            //Asigno a viejaFuente el tipo de fuente seleccionado.
            //Obtengo el tipo de Fuente atravez de la Propiedad SelectionFont
            //del Control RichTextBox.
            viejaFuente = richTextBox1.SelectionFont;

            if (viejaFuente.Italic)//Pregunto si ya es Cursiva.
            {
                //Si ya Tenia Cursiva, establece nuevaFuente sin Cursiva.
                nuevaFuente = new Font(viejaFuente, viejaFuente.Style & ~FontStyle.Italic);
            }
            else
            {
                //Si no Tenia Cursiva, establece nuevaFuente con Cursiva.
                nuevaFuente = new Font(viejaFuente, viejaFuente.Style | FontStyle.Italic);
            }

            //Establesco la nuevaFuente a la Selección.
            richTextBox1.SelectionFont = nuevaFuente;

            //Realizo un foco para posicionarme en el Control.
            richTextBox1.Focus();
        }

        private void btn_centrado_Click(object sender, EventArgs e)
        {

            //Atravez de la propiedad SelectionAlignment, obtiene la alineación
            //del texto que se selecciono.
            //Pregunto si es en centrado.

            if (richTextBox1.SelectionAlignment == HorizontalAlignment.Center)
            {
                //Si estaba Centrado lo alinea a la Izq.
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            }
            else
            {
                //Si no estaba centrado lo centra.
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            }

            richTextBox1.Focus();
        }

        //Método propio Aplicar Tamaño de Texto
        private void AplicarTamanioText(string textSize) 
        {
            //Declaro una Var. y le asigno el valor pasado, previa Conversion.
            float nuevoTamanio = Convert.ToSingle(textSize);

            //Declaro un Objeto FontFamily para el tipo de Fuente actual.
            FontFamily actualFontFamily;

            //Declaro un Objeto Font para la nueva Fuente.
            Font nuevaFuente;

            //De la selección actual del RichTextBox obtengo
            //el tipo de familia de la fuente.
            actualFontFamily = richTextBox1.SelectionFont.FontFamily;

            //New Font Instancia el objeto nuevaFuente según
            //tipo de Fuente y tamaño.
            nuevaFuente = new Font(actualFontFamily, nuevoTamanio);

            richTextBox1.SelectionFont = nuevaFuente;
        }

        private void txtBox_fuente_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Valido que si se presiono una tecla que no se un numero,
            //Backspace o enter, se controle el evento.
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 13)//Pregunto si es Enter.
            {
                if (txtBox_fuente.Text.Length > 0)
                {
                    //Llamo al método Aplicar Tamaño al Texto.
                    AplicarTamanioText(txtBox_fuente.Text);
                }

                //Si es Enter y no se ingresaron caracteres, controlo el evento.
                e.Handled = true;

                richTextBox1.Focus();
            }
        }

        private void txtBox_fuente_Validated(object sender, EventArgs e)
        {
            //El Evento Validated ocurre después de la validación(Evento Validating).
            //Llama al Método AplicarTamanioText y como parámetro pasa,
            //La propiedad Text del objeto sender(Objeto que disparo el evento)
            //Del cual se hace un Cast del tipo TextBox.
            AplicarTamanioText(((TextBox)sender).Text);

            richTextBox1.Focus();
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            //La clase Process brinda acceso a procesos locales y remotos.
            //El método Start inicia un proceso y asocia el recurso a un nuevo componentes.
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void btn_abrir_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.LoadFile("Test.rtf");
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("No se pudo cargar el archivo");
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.SaveFile("Test.rtf");
            }
            catch (System.Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }
    }
}
