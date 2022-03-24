using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaNegocio;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        //Onjetos y variables que seran usados en esta clase
        N_Categoria n_Categoria = new N_Categoria();
        E_Categoria e_Categoria;
        private string idcategoria;
        private bool btnEditarEstado = false;
        private bool btnInsertarEstado = false;
        public Form1()
        {
            InitializeComponent();
            //Me carga los datos que contiene la tabla CATEGORIA en el DataGridView
            tablaCategoria.DataSource = n_Categoria.mostrarDatosN().Tables[0]; 
        }
        //Metodo asociado al boton cerrar
        private void cerrarFormulario_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }
        //Meodo asociado a mostrar la busqueda
        public void mostrarBusqueda(string buscar)
        {
            tablaCategoria.DataSource = n_Categoria.listarCategoriaN(buscar);
        }

        //Metodo de acciones que refrescaran la tabla de cualquier accion que cambie la Tabla de Estado
        public void accionesTabla()
        {
            tablaCategoria.DataSource = n_Categoria.mostrarDatosN().Tables[0];
            tablaCategoria.Columns[0].Visible = false;
        }
        //Cargara los datos en el DATAGRIDVIEW cada ver que se ejecute el programa
        private void Form1_Load(object sender, EventArgs e)
        {
            accionesTabla();
           
        }
        //Busca en la tabla a medida que el texto cambie en el campo de texto txtBuscar
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarBusqueda(txtBuscar.Text);
        }
        //btn para agregar un nievo registro
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtNombre.Focus();
            btnInsertarEstado = true;
            
        }
        //btn para editar un registro
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tablaCategoria.SelectedRows.Count>0)
            {
                idcategoria = tablaCategoria.CurrentRow.Cells[0].Value.ToString();
                txtCodigo.Text = tablaCategoria.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = tablaCategoria.CurrentRow.Cells[2].Value.ToString();
                txtDescripcion.Text = tablaCategoria.CurrentRow.Cells[3].Value.ToString();
                btnEditarEstado = true;
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar");
            }
            
           

        }

        private void tablaCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
                
           
        }
        //Metodo asiciado al boton guardar que guarda datos actualizados o guarda nuevos datos dependiendo la opcion que selecciones
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (btnEditarEstado == true)
            {  

                    try
                    {
                        e_Categoria = new E_Categoria(Int32.Parse(idcategoria), txtNombre.Text, txtDescripcion.Text);
                        n_Categoria.editarCategoriaN(e_Categoria);
                        MessageBox.Show("Datos actualizados correctamente");
                        accionesTabla();
                        btnEditarEstado = false;
                    }catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo editar el registro " + ex);
                    }
            }
            else if (btnInsertarEstado==true)
            {
                e_Categoria = new E_Categoria(txtNombre.Text, txtDescripcion.Text);
                n_Categoria.insertarCategoriaN(e_Categoria);
                MessageBox.Show("Categoria agregada correctamente");
                accionesTabla();
                btnInsertarEstado = false;
              
            }

            
        }
        //Metodo asociado al boton eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tablaCategoria.SelectedRows.Count > 0) 
            {
                e_Categoria = new E_Categoria(Convert.ToInt32(tablaCategoria.CurrentRow.Cells[0].Value.ToString()));
                n_Categoria.eliminarCategoriaN(e_Categoria);
                MessageBox.Show("Se elimino correctamente");
                accionesTabla();
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea eliminar");
            }
        }
        //metodo asociaod al boton minimizar
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
