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
            InitializeComponent();
            this.tipoDominio = tipoDominio;
            this.idDominio = idDominio;
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
                using (VIDEOTIENDAEntities db  = new VIDEOTIENDAEntities())
                {  //capta los datos en  los espacios  y los envia a la bd
                    oDominio = new dominios();
                    oDominio.tipo_dominio = this.txtTipo.Text;
                    oDominio.id_dominio = this.txtId.Text;
                    oDominio.vlr_dominio = this.txtValor.Text;
                    db.dominios.Add(oDominio);
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
