using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> departamento = new List<string>();
        List<string> municipio = new List<string>();


        private void Form1_Load(object sender, EventArgs e)
        {
            Vacio();
        }

        public void Vacio()
        {
            if (txtBox.Text == "")
            {
                btnAgregar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            else if (txtBox.Text != "")
            {
                btnAgregar.Enabled = true;
            }
        }

        private void rdDepartamento_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdMunicipio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (rdDepartamento.Checked == true)
            {
                Departamento();
            }
            else
            {
                Municipio();
            }
        }

        public void Departamento()
        {
            listBoxDepartamento.Items.Add(txtBox.Text);
            txtBox.Clear();
        }

        public void Municipio()
        {
            listBoxMunicipio.Items.Add(txtBox.Text);
            txtBox.Clear();
        }

        private void listBoxDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        public void Eliminar()
        {
            if (rdDepartamento.Checked)
            {
                var pos = listBoxDepartamento.SelectedIndex;
                listBoxDepartamento.Items.RemoveAt(pos);
            }
            else
            {
                var pos = listBoxMunicipio.SelectedIndex;
                listBoxMunicipio.Items.RemoveAt(pos);
            }
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            int pos = listBoxDepartamento.SelectedIndex;
            string text = listBoxDepartamento.Text;
            listBoxMunicipio.Items.Add(text);
            listBoxDepartamento.Items.RemoveAt(pos);

        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            int pos = listBoxMunicipio.SelectedIndex;
            string text = listBoxMunicipio.Text;
            listBoxDepartamento.Items.Add(text);
            listBoxMunicipio.Items.RemoveAt(pos);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listBoxDepartamento.Items.Clear();
            listBoxMunicipio.Items.Clear();
        }

        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >=123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Sólo se permiten letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void listBoxMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEliminar.Enabled = true;
        }
    }
}
