using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data.SqlClient;
using CapaDatos;
using System.Data;

namespace CapaLogicaNegocio
{
    public class N_Categoria
    {
        //Objeto de la clase D_Categoria
        D_Categoria d_Categoria = new D_Categoria();
        //Metodo que se utiliza para buscar categoria
        public List<E_Categoria> listarCategoriaN(string buscar)
        {
            return d_Categoria.ListarCategorias(buscar);

        }
        //Metodo para insertar categoria
        public void insertarCategoriaN(E_Categoria e_Categoria)
        {
            d_Categoria.insertarCategoria(e_Categoria);
        }
        //Metodo para editar categoria
        public void editarCategoriaN(E_Categoria e_Categoria)
        {
            d_Categoria.editarCategoria(e_Categoria);
        }
        //Metodo para eliminar categoria
        public void eliminarCategoriaN(E_Categoria e_Categoria)
        {
            d_Categoria.eliminarCategoria(e_Categoria);
        }
        //Metodo para mostrar todos los datos de la tabla
        public DataSet mostrarDatosN()
        {
            return d_Categoria.mostrarDatos();
        }

    }
}
