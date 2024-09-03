using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActividadCinco
{
    public partial class Form1 : Form
    {
        private System.Collections.Specialized.StringCollection carpetacol;
        public Form1()
        {
            InitializeComponent();

            carpetacol = new System.Collections.Specialized.StringCollection();
            CrearCabecerayLlenarListView();
            DibujarListView(@"C:\Users\QQmelo\Desktop\Guias de Laboratorio y Programacion");
            carpetacol.Add(@"C:\Users\QQmelo\Desktop\Guias de Laboratorio y Programacion");
        }

        private void CrearCabecerayLlenarListView()
        {
            ColumnHeader columH;//Declaro un objeto ColumnHeader.

            columH = new ColumnHeader();//Instancio el objeto ColumnHeader.
            columH.Text = "Nombre Archivo";
            listView_uno.Columns.Add(columH);// Inserto la Cabecera Nombre Archivo.

            columH = new ColumnHeader();
            columH.Text = "Ultima Modificacion";
            listView_uno.Columns.Add(columH);// Inserto la Cabecera Tamaño.

            columH = new ColumnHeader();
            columH.Text = "Tipo";
            listView_uno.Columns.Add(columH);

            columH = new ColumnHeader();
            columH.Text = "Tamaño";
            listView_uno.Columns.Add(columH);// Inserto la Cabecera Ultima Modificacion.
        }

        private void DibujarListView(string root)
        {
            try
            {
                ListViewItem lvi;
                ListViewItem.ListViewSubItem lvsi;
                if (string.IsNullOrEmpty(root))
                return;
                DirectoryInfo dir = new DirectoryInfo(root);
                DirectoryInfo[] dirs = dir.GetDirectories();
                FileInfo[] files = dir.GetFiles();
                listView_uno.Items.Clear();
                lbl_directorioA.Text = root;
                listView_uno.BeginUpdate();
                foreach (DirectoryInfo di in dirs)
                {
                    lvi = new ListViewItem();
                    lvi.Text = di.Name;
                    lvi.ImageIndex = 0;
                    lvi.Tag = di.FullName;
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = di.LastAccessTime.ToString();
                    lvi.SubItems.Add(lvsi);
                    listView_uno.Items.Add(lvi);
                }
                foreach (FileInfo fi in files)
                {
                    lvi = new ListViewItem();
                    lvi.Text = fi.Name;
                    lvi.ImageIndex = 1;
                    lvi.Tag = fi.FullName;
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fi.Length.ToString();
                    lvi.SubItems.Add(lvsi);
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fi.LastAccessTime.ToString();
                    lvi.SubItems.Add(lvsi);
                    listView_uno.Items.Add(lvi);
                }
                listView_uno.EndUpdate();
            }
            catch (System.Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }
        }

        private void listView_uno_ItemActivate(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView lw = (System.Windows.Forms.ListView) sender;
            string filename = lw.SelectedItems[0].Tag.ToString();
            if (lw.SelectedItems[0].ImageIndex != 0)
            {
                try
                {
                    System.Diagnostics.Process.Start(filename);
                }
                catch { return; }
            }
            else
            {
                DibujarListView(filename);
                carpetacol.Add(filename);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (carpetacol.Count > 1)
            {
                DibujarListView(carpetacol[carpetacol.Count - 2].ToString());
                carpetacol.RemoveAt(carpetacol.Count - 1);
            }
            else
            {
                DibujarListView(carpetacol[0].ToString());
            }
        }

        private void rBtn_iconL_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
            {
                this.listView_uno.View = View.LargeIcon;
            }
        }

        private void rBtn_iconS_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
            {
                this.listView_uno.View = View.SmallIcon;
            }
        }

        private void rBtn_lista_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
            {
                this.listView_uno.View = View.List;
            }
        }

        private void rBtn_detalle_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
            {
                this.listView_uno.View = View.Details;
            }
        }

        private void rBtn_titulo_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
            {
                this.listView_uno.View = View.Tile;
            }
        }
    }
}
