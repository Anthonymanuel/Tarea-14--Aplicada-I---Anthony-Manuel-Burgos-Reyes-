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
    public partial class RegistroForm : Form
    {
        public RegistroForm()
        {
            InitializeComponent();
        }

        private void RegistrarButton_Click(object sender, EventArgs e)
        {
            Pelicula pelicula = new Pelicula();
            pelicula.Titulo = TituloTextBox.Text;
            pelicula.Descripcion = DescripcionTextBox.Text;
            pelicula.Ano = Convert.ToInt32(AnoTextBox.Text);
            pelicula.Calificacion = Convert.ToInt32(CalificacionTextBox.Text);
            pelicula.Imbd = Convert.ToInt32(IMDBTextBox.Text);
            pelicula.categoriaId = Convert.ToInt32(CategoriaIdTexBox.Text);
            pelicula.Insertar();
            TituloTextBox.Clear();
            DescripcionTextBox.Clear();
            AnoTextBox.Clear();
            CalificacionTextBox.Clear();
            IMDBTextBox.Clear();
            CategoriaIdTexBox.Clear();
            MessageBox.Show("Se ha registrado la pelicula");


        }
    }
}
