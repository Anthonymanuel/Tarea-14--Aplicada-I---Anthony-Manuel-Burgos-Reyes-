using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.IO;
using System.Drawing;

namespace BLL
{    /// <summary>
    /// Clase pelicula
    /// </summary>
    public class Pelicula : ClaseMaestra
    {
        

        public int PeliculaId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int Ano { get; set; }
        public int Calificacion { get; set; }
        public int Imbd  { get; set; }
        public int categoriaId { get; set; }
        public string Direccion { get; set; }
        public string Video { get; set; }

        public Pelicula()
        {
            this.Titulo = "";
            this.Descripcion = "";
            this.Ano = 0;
            this.Calificacion = 0;
            this.Imbd = 0;
            this.categoriaId = 0;
            this.Direccion = "";
            this.Video = "";

        }
        ConexionBaseD conexion = new ConexionBaseD();
        /// <summary>
        /// Insertar elementos en una base de datos
        /// </summary>
        /// <returns>verdadero o falso si se ejecuto corectamente o no</returns>
        public override bool Insertar()
        {
            bool retorno = false;
            conexion.Ejecutar(String.Format("insert into Pelicula(Titulo,Descripcion,Ano,Calificacion,IMBD, CategoriaId,Foto,Video) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", this.Titulo, this.Descripcion, this.Ano, this.Calificacion, this.Imbd, this.categoriaId,this.Direccion,this.Video));
            return retorno;
        }
        /// <summary>
        /// Para Actulizar  los elementos de una tabla de una base de datos
        /// </summary>
        /// <returns>retorna true si actuliza y false sino se actualizo</returns>
        public override bool Editar()
        { 
            bool retorno = false;
            conexion.Ejecutar(String.Format("update Pelicula set Titulo = '{0}',Descripcion='{1}',Ano ='{2}',Calificacion='{3}',IMBD='{4}',CategoriaId='{5}',Foto='{6}',Video='{7}' where PeliculaId='{6}'", this.Titulo, this.Descripcion, this.Ano, this.Calificacion, this.Imbd, this.categoriaId, this.Direccion,this.Video,this.PeliculaId));
            return retorno;
        }
        /// <summary>
        /// Para Eleminar elemento de una tabla de una base de datos
        /// </summary>
        /// <returns>retorna el metodo Obtenerconexion y este a su vez un datatable</returns>

        public override bool Eliminar()
        {
            bool retorno = false;
            conexion.getDatos(String.Format("delete  from Pelicula where PeliculaId={0}", this.PeliculaId));
            return retorno;
        }
        /// <summary>
        /// Para Buscar elemento de una tabla de una base de datos
        /// </summary>
        /// <returns>retorna el metodo Obtenerconexion y este a su vez un datatable</returns>
        public override bool Buscar(int IdBuscado)
        {
            DataTable dt = new DataTable();

            dt = conexion.getDatos(String.Format("select  PeliculaId,Titulo,Descripcion,Ano,Calificacion,IMBD, CategoriaId,Foto,Video from Pelicula where PeliculaId={0}", IdBuscado));
            if (dt.Rows.Count > 0)
            {
                this.PeliculaId = (int)dt.Rows[0]["PeliculaId"];
                this.Titulo = dt.Rows[0]["Titulo"].ToString();
                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
                this.Ano = (int)dt.Rows[0]["Ano"];
                this.Calificacion = (int)dt.Rows[0]["Calificacion"];
                this.Imbd = (int)dt.Rows[0]["IMBD"];
                this.categoriaId = (int)dt.Rows[0]["CategoriaId"];
                this.Direccion = dt.Rows[0]["Foto"].ToString();
                this.Video= dt.Rows[0]["Video"].ToString();
            }

            return dt.Rows.Count  >0;
        }

       
        public override DataTable Listado(string Campos, string Condicion)
        {
            return conexion.getDatos("Select" + Campos + " from Pelicula where " + Condicion);
        }
    }
}
