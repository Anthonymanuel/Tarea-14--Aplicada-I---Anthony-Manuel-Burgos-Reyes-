using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroPelicula
{
    public partial class Actualizar : Form
    {
        public Actualizar()
        {
            InitializeComponent();
        }

        private void ActualizarButton_Click(object sender, EventArgs e)
        {
            Pelicula pelicula = new Pelicula();
            pelicula.PeliculaId = Convert.ToInt32(PeliculaIdTextBox.Text);
            pelicula.Titulo = TituloTextBox.Text;
            pelicula.Descripcion = DescripcionTextBox.Text;
            pelicula.Ano = Convert.ToInt32(AnoTextBox.Text);
            pelicula.Calificacion = Convert.ToInt32(CalificacionTextBox.Text);
            pelicula.Imbd = Convert.ToInt32(IMDBTextBox.Text);
            pelicula.categoriaId = Convert.ToInt32(CategoriaIdTexBox.Text);
            pelicula.Actualizar();
            PeliculaIdTextBox.Clear();
            TituloTextBox.Clear();
            DescripcionTextBox.Clear();
            AnoTextBox.Clear();
            CalificacionTextBox.Clear();
            IMDBTextBox.Clear();
            CategoriaIdTexBox.Clear();
            MessageBox.Show("Se ha Actualizado la pelicula");
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            TituloTextBox.Clear();
            DescripcionTextBox.Clear();
            AnoTextBox.Clear();
            CalificacionTextBox.Clear();
            IMDBTextBox.Clear();
            CategoriaIdTexBox.Clear();
            MessageBox.Show("Se ha cancelado  la pelicula ");
        }
    }
}
