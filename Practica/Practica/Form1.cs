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
    public partial class Form1 : Form
    {
        List<Estudiante> listaEstudiantes = new List<Estudiante>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if(txtnombre.Text != "" && txtapellido.Text != "" && txtdni.Text != "")
            {
                Estudiante est = new Estudiante(txtnombre.Text, txtapellido.Text, int.Parse(txtdni.Text));
                listaEstudiantes.Add(est);
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
            Estudiante est;
            est = (Estudiante)GrillaEstudiantes.Rows[e.RowIndex].DataBoundItem;
            txtnombre.Text = est.Nombre;
            txtapellido.Text = est.Apellido;
            txtdni.Text = est.DNI.ToString();

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
            }

        }
    }
}



