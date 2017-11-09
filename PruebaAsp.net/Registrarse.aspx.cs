using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidades;
using System.Data;
using PruebaAsp.net.WCFUsuarios;


namespace PruebaAsp.net
{
    public partial class Registrarse : System.Web.UI.Page
    {
        UsuarioWs Oentusuarios = new UsuarioWs();
        PruebaAsp.net.WCFUsuarios.UsuarioClient WCFUsuarios = new PruebaAsp.net.WCFUsuarios.UsuarioClient();


        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void BtnRegistrar_Click(object sender, EventArgs e)
        {

          
       


            if (Txtnombreusuario.Text.Trim() == "")
            {
                lblerror.Text = "Escriba un usuario";
                Txtnombreusuario.Focus();
            }
            else
            {
                if (TxtContrasena.Text.Trim() =="")
                {
                    lblerror.Text = "Escriba un usuario";
                    TxtContrasena.Focus();
                }
                else
                {
                    if (TxtNombre.Text.Trim() == "")
                    {
                        lblerror.Text = "Escriba un usuario";
                        TxtNombre.Focus();
                    }
                    else
                    {
                        if (TxtEmail.Text.Trim() == "")
                        {
                            lblerror.Text = "Escriba un usuario";
                            TxtNombre.Focus();
                        }
                        else
                        {
                            Oentusuarios.NickUsuarios = Txtnombreusuario.Text;
                            Oentusuarios.PassUsuarios = TxtContrasena.Text;
                            Oentusuarios.NombreUsuarios = TxtNombre.Text;
                            Oentusuarios.EmailUsuarios = TxtEmail.Text;


                            string[] oent = { Oentusuarios.NickUsuarios, Oentusuarios.PassUsuarios, Oentusuarios.NombreUsuarios, Oentusuarios.EmailUsuarios };

                            bool result = WCFUsuarios.GetInsertarUsuario(oent); ;
                            if (result)
                            {
                                lblerror.Text = "usuario registrado con exito";
                                Response.Redirect("Login.aspx");
                            }                            
                        }
                    }
                }

            }

        }
    }
}