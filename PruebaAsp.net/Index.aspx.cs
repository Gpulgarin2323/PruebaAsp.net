using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebaAsp.net
{
    public partial class Index : System.Web.UI.Page
    {

        DatosWs OentDatos = new DatosWs();

       
        PruebaAsp.net.WCFCrud.CrudClient WCFCrud = new PruebaAsp.net.WCFCrud.CrudClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            //lblusuario.Text = Session["UsuarioInicio"].ToString();           
            CargarLibros();
        }

        protected void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {

          


            DataSet ds = new DataSet();
            if (Txtbuscar.Text.Trim() == "")
            {
                lblmensaje.Text = " Escriba una referencia para buscar";
            }
            else
            {
                OentDatos.Idlibro = Convert.ToInt32(Txtbuscar.Text);

            }

            ds = WCFCrud.GetConsultarLibroids(OentDatos.Idlibro);


            if (ds.Tables[0].Rows.Count == 0)
            {
                lblmensaje.Text = "El libro no existe";


            }
            else
            {
                TxtNombrelibro.Text = ds.Tables[0].Rows[0]["Nombre del libro"].ToString();
                TxtGenero.Text = ds.Tables[0].Rows[0]["Género"].ToString();
                TxtPrecio.Text = ds.Tables[0].Rows[0]["Precio"].ToString();

            }
        }
             catch (Exception)
            {

                throw;
            }

        }

        protected void CargarLibros()
        {
            DataSet ds = new DataSet();
            ds = WCFCrud.GetConsultarLibros();
            DGridlibros.DataSource = ds;
            DGridlibros.DataBind();
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                if (TxtNombrelibro.Text.Trim() =="")
                {
                    lblmensaje.Text = "Debe escribir un Nombre para el libro";
                }
                else
                {
                    if (TxtGenero.Text.Trim() =="")
                    {
                        lblmensaje.Text = "Debe escribir un Genero para el libro";
                    }
                    else
                    {
                        if (TxtPrecio.Text.Trim() =="")
                        {
                            lblmensaje.Text = "Debe escribir un Precio para el libro";
                        }
                        else

                        {
                            OentDatos.NombreLibro = TxtNombrelibro.Text;
                            OentDatos.Genero = TxtGenero.Text;
                            OentDatos.Precio = TxtPrecio.Text;

                            string[] oent = { OentDatos.NombreLibro, OentDatos.Genero, OentDatos.Precio };
                           bool result= WCFCrud.GetInsertarLibro(oent);

  
                            if (result)
                            {
                                lblmensaje.Text = "Libro Agregado con exito";
                                
                            }

                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        protected void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtNombrelibro.Text.Trim() == "")
                {
                    lblmensaje.Text = "Debe escribir un Nombre para el libro";
                }
                else
                {
                    if (TxtGenero.Text.Trim() == "")
                    {
                        lblmensaje.Text = "Debe escribir un Genero para el libro";
                    }
                    else
                    {
                        if (TxtPrecio.Text.Trim() == "")
                        {
                            lblmensaje.Text = "Debe escribir un Precio para el libro";
                        }
                        else

                        {
                            OentDatos.Idlibro = Convert.ToInt32(Txtbuscar.Text);
                            OentDatos.NombreLibro = TxtNombrelibro.Text;
                            OentDatos.Genero = TxtGenero.Text;
                            OentDatos.Precio = TxtPrecio.Text;

                            string[] oent = { OentDatos.Idlibro.ToString(), OentDatos.NombreLibro, OentDatos.Genero, OentDatos.Precio };
                            bool result = WCFCrud.GetActualizarLibro(oent);


                            if (result)
                            {

                                Response.Redirect("index.aspx");

                            }
                            else
                            {
                                lblmensaje.Text= "Libro no Actualizado con exito";
                                                             
                            }

                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}