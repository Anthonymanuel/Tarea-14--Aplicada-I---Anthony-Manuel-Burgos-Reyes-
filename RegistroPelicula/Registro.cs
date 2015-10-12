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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroForm registro = new RegistroForm();
            registro.MdiParent = this;
            registro.Show();
            
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaForm consulta = new ConsultaForm();
            consulta.MdiParent = this;
            consulta.Show();
        }
        
    }
}
