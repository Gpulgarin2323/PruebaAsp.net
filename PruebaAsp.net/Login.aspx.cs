using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using CapaEntidades;
using System.Data;
using PruebaAsp.net.WCFUsuarios;

namespace PruebaAsp.net
{
    public partial class Login : System.Web.UI.Page
    {

        UsuarioWs OentUsuario = new UsuarioWs();

        PruebaAsp.net.WCFUsuarios.UsuarioClient WCFUsuarios = new PruebaAsp.net.WCFUsuarios.UsuarioClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (lblerrorpass.Visible == true)
            {
                lblerrorpass.Visible = false;
            }

        }

        protected void btningresar_Click(object sender, EventArgs e)
        {



            if (txtusername.Text.Trim() == "" | txtpassword.Text.Trim() == "")
            {
                lblerrorpass.Visible = true;
                lblerrorpass.Text = "Escriba un usuario y contraseña";
            }
            else
            {
                OentUsuario.NickUsuarios = txtusername.Text;
                OentUsuario.PassUsuarios = txtpassword.Text;
                string[] oent = { OentUsuario.NickUsuarios, OentUsuario.PassUsuarios };
                
                bool result = WCFUsuarios.GetVerificarUsuario(oent);
                if (result == true)
                {
                    Session["UsuarioInicio"] = txtusername.Text;
                    Response.Redirect("Index.aspx");
                }
                else
                {

                    lblerrorpass.Visible = true;
                    lblerrorpass.Text = "Usuario y/o Contraseña Incorrecta";
                }


            }

        }
        
    }
}