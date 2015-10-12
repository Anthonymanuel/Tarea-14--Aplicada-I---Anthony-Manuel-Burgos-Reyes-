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

        string direccion,video;
        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Pelicula pelicula = new Pelicula();
            pelicula.PeliculaId = Convert.ToInt32(PeliculaIdTextBox.Text);
       
            
            if (pelicula.Eliminar())
            {
                MessageBox.Show("Error al eleminar la pelicula");
            }
            else
            {
                MessageBox.Show("Se ha eleminado la pelicula");
            }
            PeliculaIdTextBox.Clear();

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Pelicula pelicula = new Pelicula();
            pelicula.PeliculaId = Convert.ToInt32(PeliculaIdTextBox.Text); ;
            pelicula.Titulo = TituloTextBox.Text;
            pelicula.Descripcion = DescripcionTextBox.Text;
            pelicula.Ano = Convert.ToInt32(AnoTextBox.Text);
            pelicula.Calificacion = Convert.ToInt32(CalificacionTextBox.Text);
            pelicula.Imbd = Convert.ToInt32(IMDBTextBox.Text);
            pelicula.categoriaId = Convert.ToInt32(CategoriaIdComboBox.Text);
            
            if (pelicula.Editar())
            {
                MessageBox.Show("Error al guardar los cambios en la pelicula");
            }
            else
            {
                
                MessageBox.Show("Se han guardado los cambios en la pelicula");
            }
            TituloTextBox.Clear();
            DescripcionTextBox.Clear();
            AnoTextBox.Clear();
            CalificacionTextBox.Clear();
            IMDBTextBox.Clear();
            

        }
        
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Pelicula pelicula = new Pelicula();
            pelicula.Titulo = TituloTextBox.Text;
            pelicula.Descripcion = DescripcionTextBox.Text;
            pelicula.Ano = Convert.ToInt32(AnoTextBox.Text);
            pelicula.Calificacion = Convert.ToInt32(CalificacionTextBox.Text);
            pelicula.Imbd = Convert.ToInt32(IMDBTextBox.Text);
            pelicula.categoriaId = Convert.ToInt32(CategoriaIdComboBox.Text);
            pelicula.Direccion = direccion;
            pelicula.Video = video;
            pelicula.Insertar();
            if (pelicula.Insertar())
            {
                MessageBox.Show("Error al registrar la pelicula");
            }
            else
            {
                
                MessageBox.Show("Se ha registrado la pelicula");
            }

            TituloTextBox.Clear();
            DescripcionTextBox.Clear();
            AnoTextBox.Clear();
            CalificacionTextBox.Clear();
            IMDBTextBox.Clear();
           
        }

        private void SeleccionarButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            buscar.Filter = "Archivo de imagen|*.png;*.bmp*.gif;*.jpg;*.tif ";
            buscar.Title = "";
            buscar.FileName = "Seleccione una imagen";
            buscar.InitialDirectory = "C:\\Users\\.\\Desktop";
            if(buscar.ShowDialog()== DialogResult.OK)
            {
                direccion = buscar.FileName;
                FotoPictureBox.ImageLocation = direccion;
            }
        }

       

        private void SeleccionarVideoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            buscar.Filter = "Archivo de Video|*.mp4;*.avi ";
            buscar.Title = "";
            buscar.FileName = "Seleccione un Video";
            buscar.InitialDirectory = "C:\\Users\\.\\Desktop";
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                video = buscar.FileName;
                ReproductorAxWindowsMediaPlayer1.URL = video;
                
            }
            
        }

        
    }
}
