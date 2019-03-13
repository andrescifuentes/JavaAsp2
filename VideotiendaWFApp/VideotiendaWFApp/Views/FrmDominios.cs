using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideotiendaWFApp.Models; // CARGAMOS NUESTRA APP CON SUS MODEL


namespace VideotiendaWFApp.Views
{
    public partial class FrmDominios : Form
    {
        public FrmDominios()
        {
            InitializeComponent();
        }

        private void FrmDominios_Load (object sender, EventArgs e)
        {
            refrescarTabla(); // cargara lpos datos cuanfdo inicia
        }

#region Helper

        public void refrescarTabla()
        {
            using (VIDEOTIENDAEntities db = new VIDEOTIENDAEntities())
            {
                var lstDominios = from d in db.dominios
                                  select d;
                grDatos.DataSource = lstDominios.ToList();   //lstDominios la definimos para referenciar o traer la bd
            }
        }

        private dominios getselectedItem()
        {
            // inicializa objeto para almacenar dominios seleccionado en la tabla 
            dominios d = new dominios();
            try
            {  // va la a fila dominios y toma el indice   rows =filas   cells = celda
                d.tipo_dominio = grDatos.Rows[grDatos.CurrentRow.Index].Cells[0].Value.ToString();

                d.id_dominio = grDatos.Rows[grDatos.CurrentRow.Index].Cells[1].Value.ToString();
               // retornar objeto con datos  del dominio seleccionado en la tabla 
                return d;
            }
            catch
            {
                return null;
            }
        }

        #endregion
        // funciones del boton buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {// primer paso conetar base de datso video tienda

            using (VIDEOTIENDAEntities db =new VIDEOTIENDAEntities())
            {
                //segundo consultar los dominios
                var lstDominios = from d in db.dominios select d;

                // var definimos lstDominos

                // aplicar fltros ingresados por el usuario

                if (!String.IsNullOrEmpty(this.txtTipo.Text)) // VALIDA SI ESTA VACIO O NULL
                {
                    lstDominios = lstDominios.Where(d => d.tipo_dominio.Contains(this.txtTipo.Text));
                }

                // aplicar busqueda en iddominio
                if (!String.IsNullOrEmpty(this.txtId.Text)) // VALIDA SI ESTA VACIO O NULL
                {
                    lstDominios = lstDominios.Where(d => d.id_dominio.Contains(this.txtId.Text));
                }

                //apliocar busqueda en valor

                if (!String.IsNullOrEmpty(this.txtValor.Text)) // VALIDA SI ESTA VACIO O NULL
                {
                    lstDominios = lstDominios.Where(d => d.vlr_dominio.Contains(this.txtValor.Text));
                }


                grDatos.DataSource = lstDominios.ToList();
                // grADatos es para que cargue la tabla en gried view


            }
        }
        // BORRAR LO QUE SE HACE EN LOS TXTB
        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            //SE DIRIJE A LOS TXBOX Y LOS LIMPIA 
            this.txtTipo.Text = "";
            this.txtId.Text = "";
            this.txtValor.Text = "";

            refrescarTabla();

        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Views.FrmGestionarDominios frmGestionarDominios = new Views.FrmGestionarDominios(null, null);

            frmGestionarDominios.ShowDialog();

            refrescarTabla();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // obetener  dominio que se seleccion en la tabla para editar
            dominios d = getselectedItem();      // el obejto es d
            // se pregunta si hubo seleccion
            if  (d != null)
            {
                // inicializar formulario edicion de dominios 
                Views.FrmGestionarDominios frmGestionarDominios  
                      = new Views.FrmGestionarDominios(d.tipo_dominio, d.id_dominio); // llama al formulario
                // abrir formulario  de edicion dominios 
                frmGestionarDominios.ShowDialog();
                // refrescar tabla cuando regres del formulario de edicion 
                refrescarTabla();
            }

        }

        private void btnElimiar_Click(object sender, EventArgs e)
        {
            //obtener el dominio que se va eliminar 
            dominios d = this.getselectedItem();
            // hubo seleccion?
            if(d != null)
            {   // PARA QUE SALGA UN CUADRO DE DIALOGO 
                if (MessageBox.Show("Esta seguro que desea eliminar este regidtro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)

                {
                    //establecer conexion en la bd a traves de ef
                    using (VIDEOTIENDAEntities db = new VIDEOTIENDAEntities())
                    {

                        // buscar el domino en la bd
                        dominios dEliminar = db.dominios.Find(d.tipo_dominio, d.id_dominio);
                        // eliminar dominio de la tabla 
                        db.dominios.Remove(dEliminar);
                        //confirmar cambios en la bd
                        db.SaveChanges();


                    }
                    // actualizar tabla
                    this.refrescarTabla();
                }

            }
        }
    }
}
