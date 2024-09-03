using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadCuatro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Con el método Add agregamos un ultimo Ítem a la
            //Colección de Ítems. Como parámetro la cadena de caracteres.
            checkLB_uno.Items.Add("Diez");
        }

        private void btn_mover_Click(object sender, EventArgs e)
        {
            //Pregunta si la cantidad (Count) de elementos chequeados
            //en la colección de ítems chequeados(CheckedItems) es mayor a cero.
            if (checkLB_uno.CheckedItems.Count > 0)
            {
                //Si es mayor a cero. Limpia los Ítem en el ListBox.
                listB_seleccinado.Items.Clear();

                //La sentencia foreach recorre la colección de Ítems Seleccionados
                //Y los asigna de a uno a la variable ítem del tipo String.
                foreach (string item in checkLB_uno.CheckedItems)
                {
                    listB_seleccinado.Items.Add(item.ToString());
                }

                //Recorro todos los Ítems del CheckedListBox.
                for (int i = 0; i < checkLB_uno.Items.Count; i++)
                {
                    //Con el Método SetItemChecked, establezco en falso la
                    //casilla de verificación (No esta seleccionado).
                    //Como parámetros i-El índice y el valor de estado en este caso false.
                    checkLB_uno.SetItemChecked(i, false);
                }
            }
        }
    }
}
