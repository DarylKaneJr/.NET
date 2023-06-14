using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class FrmEstudiante : Form
    {
        List<Estudiante> listaEstudiantes = new List<Estudiante>();
        public FrmEstudiante()
        {
            InitializeComponent();
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            if(txtnombre.Text != "" && txtapellido.Text != "" && txtdni.Text != "")
            {
                Estudiante est = new Estudiante();
                est.Nombre = txtnombre.Text;
                est.Apellido = txtapellido.Text;
                est.DNI = int.Parse(txtdni.Text);
                est.Email = txtemail.Text;
                listaEstudiantes.Add(est);
                if (txtedad.Text != "" ) 
                    est.Edad = int.Parse(txtedad.Text);
                else
                    est.Edad = 0;
                if (txtcelular.Text != "")
                    est.Celular = int.Parse(txtcelular.Text);
                else
                    est.Edad = 0;
                Listar();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Complete los campos requeridos por favor");
            }
        }
        public void Limpiar()
        {
            txtnombre.Clear();
            txtapellido.Clear();
            txtdni.Clear();
        }
        public void Listar()
        {
            GrillaEstudiantes.DataSource = null;
            GrillaEstudiantes.DataSource = listaEstudiantes;
        }
        private void GrillaEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < GrillaEstudiantes.Rows.Count)
            {
                Estudiante est;
                est = (Estudiante)GrillaEstudiantes.Rows[e.RowIndex].DataBoundItem;
                txtnombre.Text = est.Nombre;
                txtapellido.Text = est.Apellido;
                txtdni.Text = est.DNI.ToString();
            }            
        }
        private void btnborrar_Click(object sender, EventArgs e)
        {
            int index = 0;
            if (txtdni.Text != "" && listaEstudiantes.Count > 0)
            {
                foreach (var item in listaEstudiantes)
                {
                    if (int.Parse(txtdni.Text) == item.DNI)
                    {
                        index = listaEstudiantes.IndexOf(item);
                    }
                }

                listaEstudiantes.RemoveAt(index);
                Listar();
                Limpiar();
            }
        }

        private void txtdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtdni_TextChanged(object sender, EventArgs e)
        {
            if (txtdni.Text.Length > 8)
            {
                txtdni.Text = txtdni.Text.Substring(0, 8);
            }
        }
    }
}



