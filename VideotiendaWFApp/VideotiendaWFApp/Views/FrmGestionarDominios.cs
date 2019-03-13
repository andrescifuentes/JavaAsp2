using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideotiendaWFApp.Models;

namespace VideotiendaWFApp.Views
{
    public partial class FrmGestionarDominios : Form
    {
        dominios oDominio = null;
        private String tipoDominio;
        private String idDominio;



        //CONSTRUCTOR RESCIBE DOS PARAMETREO
        public FrmGestionarDominios(String tipoDominio ,String idDominio)
        {
            // dibuja el formulario
            InitializeComponent();
            // tiene los datros de la llave primaria
            this.tipoDominio = tipoDominio;
            this.idDominio = idDominio;
            //SI ES MODO EDICION BLOQUEAMOS LOS TEXTBOX DE LA LLAVE PRIMARIA 

            // SI HAT DATOS EDIDICION LLAMOMOS CARGADATOS
            if (!string.IsNullOrEmpty (this.idDominio) && !string.IsNullOrEmpty(this.tipoDominio))
                
                {
                cargarDatos();
                this.txtTipo.ReadOnly = true;
                this.txtId.ReadOnly = true;
            }
            else
            {
                
                this.txtTipo.ReadOnly = false;
                this.txtId.ReadOnly = false;
            }
        
        }

        private void FrmGestionarDominios_Load(object sender, EventArgs e)
        {
            //cuando se abre el formulario el cursor se coloque en el primer txbox
            this.txtTipo.Select();
        }

        private void cargarDatos()
        {
            using(VIDEOTIENDAEntities db = new VIDEOTIENDAEntities())
            {
                //odominos es el obejto  db base de datos find es buscar en la base de datos 
                oDominio = db.dominios.Find(tipoDominio,idDominio);
                txtTipo.Text = oDominio.tipo_dominio;
                txtId.Text = oDominio.id_dominio;
                txtValor.Text = oDominio.vlr_dominio;
            }

        }

        private void btnCancelar_Click(object sender,    EventArgs e)
        {
            this.Close();
            //para que cierre la ventana
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //colocamos la condicion 
            if(String.IsNullOrEmpty(this.txtTipo.Text) || string.IsNullOrEmpty (this.txtId.Text) || string.IsNullOrEmpty(this.txtValor.Text))
            {
                MessageBox.Show(" los campos marcados con (*) son obligatorios");
            }
            else
            {
                //establcer conexion con la bd a traves d ef
                using (VIDEOTIENDAEntities db  = new VIDEOTIENDAEntities())
                {  //capta los datos en  los espacios  y los envia a la bd

                    if (this.tipoDominio == null && this.idDominio == null)
                    
                     oDominio = new dominios();
                    
                    oDominio.tipo_dominio = this.txtTipo.Text;
                    oDominio.id_dominio = this.txtId.Text;
                    oDominio.vlr_dominio = this.txtValor.Text;
                    // en modo insercion adicionamos un nuevo registro
                    if (this.tipoDominio == null && this.idDominio == null)
                        db.dominios.Add (oDominio);

                    else
                        // en modo edicion , cambiamos el estado del objeto a modificacion
                        db.Entry(oDominio).State = System.Data.Entity.EntityState.Modified;

                        db.SaveChanges(); // guaradar y cancelar

                    this.Close();

                }



            }
        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
