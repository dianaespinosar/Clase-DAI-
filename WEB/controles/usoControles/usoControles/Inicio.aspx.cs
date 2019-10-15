using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace usoControles
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(ddColores.Items.Count == 0)
            {
                ddColores.Items.Add("Rojo");
                ddColores.Items.Add("Verde");
                ddColores.Items.Add("Rosa");
                ddColores.Items.Add("Amarillo");
                ddColores.Items.Add("Azul");

            }

            if(rbSabores.Items.Count == 0)
            {
                rbSabores.Items.Add("Vainilla");
                rbSabores.Items.Add("Nuez");
                rbSabores.Items.Add("Fresa");
                rbSabores.Items.Add("Limón");
                rbSabores.Items.Add("Chocolate");
            }

            if(cbCafe.Items.Count == 0)
            {
                cbCafe.Items.Add("Americano");
                cbCafe.Items.Add("Capucchino");
                cbCafe.Items.Add("Late");
                cbCafe.Items.Add("Mocha");

            }

        }

        protected void ddColores_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seleccion = 0;
            seleccion = ddColores.SelectedIndex;
            lbColores.Text = "Indice seleccionado: " + seleccion.ToString();
            Session["Controles"] = "Cambio al DropDownList";
            lbSession.Text = Session["Controles"].ToString();
        }

        protected void rbSabores_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbIndiceS.Text = "Indice Seleccionado: " + rbSabores.SelectedIndex.ToString();
            lbContenidoS.Text = "El contenido seleccionado: " + rbSabores.SelectedValue;
            Session["Controles"] = "Cambio al Radio Botton List";
            lbSession.Text = Session["Controles"].ToString();
        }


        protected void cbCafe_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;
            ListBox1.Items.Clear();
            ListBox2.Items.Clear();
            for (i = 0; i < cbCafe.Items.Count; i++)
            {
                if (cbCafe.Items[i].Selected == true)
                {
                    ListBox1.Items.Add(i.ToString());
                    ListBox2.Items.Add(cbCafe.Items[i].Value.ToString());
                }
            }

            Session["Controles"] = "Cambio al Check Box List";
            lbSession.Text = Session["Controles"].ToString();
        }
    }
}