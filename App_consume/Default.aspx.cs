using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using App_consume.Ws_Consume;

namespace App_consume
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                wsCliente objws = new wsCliente();

                string nit;
                nit = TxtNit.Text;


                if (nit == "")
                {
                    GVdatos.DataSource = objws.ListarClientes();
                    GVdatos.DataBind();
                }
                else
                {
                    GVdatos.DataSource = objws.ObtenerCliente(nit);
                    GVdatos.DataBind();
                }
            }
            catch (Exception ex)
            {
                TxtNit.Text = ex.Message;
            }
        }
    }
}