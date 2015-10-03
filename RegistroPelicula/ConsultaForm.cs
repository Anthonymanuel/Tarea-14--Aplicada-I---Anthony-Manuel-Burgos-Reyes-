using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace RegistroPelicula
{
    public partial class ConsultaForm : Form
    {
        public ConsultaForm()
        {
            InitializeComponent();
        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            Pelicula pelicula = new Pelicula();
            pelicula.PeliculaId = Convert.ToInt32(PeliculaIdTextBox.Text);
            MostrarDataGridView.DataSource = pelicula.Buscar();
            PeliculaIdTextBox.Clear();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Pelicula pelicula = new Pelicula();
            pelicula.PeliculaId = Convert.ToInt32(PeliculaIdTextBox.Text);
            pelicula.Eliminar();
            PeliculaIdTextBox.Clear();
            MessageBox.Show("Se ha elminado la pelicula");
           
        }

        private void ListarButton_Click(object sender, EventArgs e)
        {
            Pelicula pelicula = new Pelicula();
            MostrarDataGridView.DataSource = pelicula.Mostrar();

        }
    }
}
