using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Categoria
    {
        //Atributos
        private int idCategoria;
        private string codigoCategoria;
        private string nombre;
        private string descripcion;
        //Metodos get y set
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string CodigoCategoria { get => codigoCategoria; set => codigoCategoria = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        //Constructor Vacio
        public E_Categoria()
        {
        }
        //Constructor con todos los atributos
        public E_Categoria(int idCategoria, string codigoCategoria, string nombre, string descripcion)
        {
            this.idCategoria = idCategoria;
            this.codigoCategoria = codigoCategoria;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
        //Constructor con tres argumentos
        public E_Categoria(int idCategoria, string nombre, string descripcion)
        {
            this.idCategoria = idCategoria;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
        //Constructor con dos argumentos
        public E_Categoria(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
        //Constructor con un argumento
        public E_Categoria(int idCategoria)
        {
            this.idCategoria = idCategoria;
        }

        //Metodos get y set Creados de otra manera para practicar
        public int getId()
        {
            return this.idCategoria;

        }

        public void setCodigoCategoria(string codigoCategoria)
        {
            this.codigoCategoria = codigoCategoria;

        }
        public string getCodigoCategoria()
        {
            return this.codigoCategoria;

        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;

        }
        public string getNombre()
        {
            return this.nombre;
        }

        public void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;

        }

        public string getDescripcion()
        {
            return this.descripcion;
        }

    }
}
