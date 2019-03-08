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
            dominios d = new dominios();
            try
            {  // va la a fila dominios y toma el indice   rows =filas   cells = celda
                d.tipo_dominio = grDatos.Rows[grDatos.CurrentRow.Index].Cells[0].Value.ToString();

                d.id_dominio = grDatos.Rows[grDatos.CurrentRow.Index].Cells[1].Value.ToString();

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
            dominios d = getselectedItem();      // el obejto es d

            if  (d != null)
            {
                Views.FrmGestionarDominios frmGestionarDominios
                      = new Views.FrmGestionarDominios(d.tipo_dominio, d.id_dominio);
                frmGestionarDominios.ShowDialog();

                refrescarTabla();
            }

        }
    }
}
