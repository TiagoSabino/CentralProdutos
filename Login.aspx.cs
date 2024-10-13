using CentralProdutos.BaseDados.Entidades;
using CentralProdutos.BaseDados.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CentralProdutos
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioNegocio objUsuarioNegocio = new UsuarioNegocio();

                string login = txtUsuario.Text.ToString();
                string senha = txtSenha.Text.ToString();

                USUARIO objUsuario = objUsuarioNegocio.listarUsuario(login, senha);

                if (objUsuario != null)
                {
                    Response.Redirect("~/PosLogin.aspx");
                }
                else
                {
                    lbmsg.Visible = true;
                    lbmsg.Text = "Usuario ou Senha incorretos!";
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}