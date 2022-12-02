using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
//Dudas:
//No se como ponerle un limite a la pila.
namespace AlgoritmoRSI
{
    public partial class Reclutamiento : Form
    {
        Pila miPila = new Pila();
        public Reclutamiento()
        {
            InitializeComponent();
        }

        private void btnAgregarNodo_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtCalificacion.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Mensaje del sistema");
            }

            Nodos nuevoNodo = new Nodos();
            nuevoNodo.Nombre = txtNombre.Text;
            nuevoNodo.PromedioAnterior = txtCalificacion.Text;
            txtNombre.Clear();
            txtCalificacion.Clear();

            try
            {
                miPila.Apilar(nuevoNodo);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            var listaAlumno = miPila.VisualizarElementos();
            dgvPila.DataSource = listaAlumno;
        }
        //void MostrarPila()
        //{
          //  dgvPila.Rows.Clear();
            //if (miPila.Tope() != null && miPila.Tope() != null)
            //{
              //  MostrarNodoEnLista(miPila.Tope(), miPila.Tope());
            //}

        //}


        // void MostrarNodoEnLista(Nodos nodos, Nodos nodos2)
        //{

        //  dgvPila.Rows.Add(nodos.Nombre, nodos.PromedioAnterior);
        //if (nodos.Siguiente != null)
        //{
        //    MostrarNodoEnLista(nodos.Siguiente, nodos.Siguiente);
        //}



    //}

    private void btnSiguiente_Click(object sender, EventArgs e)
    {
        if (dgvPila.Rows.Count == 0)
        {
            MessageBox.Show("Error, no puedes continuar", "Mensaje del sistema");
        }
        else
        {
            this.Hide();
            Seleccion seleccion = new Seleccion();
            seleccion.Show();
        }

    }

    private void dgvPila_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}
}
