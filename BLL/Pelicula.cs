using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{    /// <summary>
    /// Clase pelicula
    /// </summary>
    public class Pelicula
    {
        

        public int PeliculaId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public int Ano { get; set; }
        public int Calificacion { get; set; }
        public int Imbd  { get; set; }
        public int categoriaId { get; set; }
        
        public Pelicula()
        {
            this.Titulo = "";
            this.Descripcion = "";
            this.Ano = 0;
            this.Calificacion = 0;
            this.Imbd = 0;
            this.categoriaId = 0;
        }
        /// <summary>
        /// Insertar elementos en una base de datos
        /// </summary>
        /// <returns>verdadero o falso si se ejecuto corectamente o no</returns>
        public bool Insertar()
        {
            bool retorno = false;

            ConexionBaseD conexion = new ConexionBaseD();
            conexion.Ejecutar(String.Format("insert into Pelicula(Titulo,Descripcion,Ano,Calificacion,IMBD, CategoriaId) values('{0}','{1}','{2}','{3}','{4}','{5}')",this.Titulo,this.Descripcion,this.Ano,this.Calificacion,this.Imbd,this.categoriaId));
            return retorno;
        }
        /// <summary>
        /// Para Buscar elemento de una tabla de una base de datos
        /// </summary>
        /// <returns>retorna el metodo Obtenerconexion y este a su vez un datatable</returns>
        public DataTable Buscar()
        {
           
            ConexionBaseD conexion = new ConexionBaseD();

            return conexion.ObtenerDatos(String.Format("select  PeliculaId,Titulo,Descripcion,Ano,Calificacion,IMBD, CategoriaId from Pelicula where PeliculaId={0}", this.PeliculaId));
        }
        /// <summary>
        /// Para Eleminar elemento de una tabla de una base de datos
        /// </summary>
        /// <returns>retorna el metodo Obtenerconexion y este a su vez un datatable</returns>
        public DataTable Eliminar()
        {
            ConexionBaseD conexion = new ConexionBaseD();

            return conexion.ObtenerDatos(String.Format("delete  from Pelicula where PeliculaId={0}", this.PeliculaId));
        }
        /// <summary>
        /// Para Mostrar todos los elementos de una tabla de una base de datos
        /// </summary>
        /// <returns>retorna el metodo Obtenerconexiony este a su vez un datatable </returns>
        public DataTable Mostrar()
        {
            ConexionBaseD conexion = new ConexionBaseD();
            return conexion.ObtenerDatos("select *  from Pelicula ");
        }
        /// <summary>
        /// Para Actulizar  los elementos de una tabla de una base de datos
        /// </summary>
        /// <returns>retorna true si actuliza y false sino se actualizo</returns>
        public bool Actualizar()
        {
            ConexionBaseD conexion = new ConexionBaseD();
            bool act = false;
            conexion.Ejecutar(String.Format("update Pelicula set Titulo = '{0}',Descripcion='{1}',Ano ='{2}',Calificacion='{3}',IMBD='{4}',CategoriaId='{5}' where PeliculaId='{6}'", this.Titulo, this.Descripcion, this.Ano, this.Calificacion, this.Imbd, this.categoriaId,this.PeliculaId));
            return act;
        }
    }
}
