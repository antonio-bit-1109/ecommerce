using System;
using System.Web;

namespace ecommerce
{
    public partial class PaginaPreferiti : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (Request.Cookies["nuovoCookie"] != null)
            {

                string stringheNelCookie = Request.Cookies["nuovoCookie"].Value;
                LabelMOstraPreferiti.Text = stringheNelCookie;
            }


        }

        protected void BUttonLogOut_Click(object sender, EventArgs e)
        {
            // qui dentro devo sovrascrivere il cookie con lo stesso nome e dargli un expired a -1 
            HttpCookie cookie = new HttpCookie("MYCOOKIE"); //sovrascriviamo il cookie precedente
            cookie.Expires = DateTime.Now.AddDays(-1); //il cookie è scaduto ieri! 
            Response.Cookies.Add(cookie); //inviamo cookie ahimè scaduto

            HttpCookie nuovoCookie = new HttpCookie("nuovoCookie"); //sovrascriviamo il cookie precedente
            nuovoCookie.Expires = DateTime.Now.AddDays(-1); //il cookie è scaduto ieri! 
            Response.Cookies.Add(cookie); //inviamo cookie ahimè scaduto

            Response.Redirect("Default");
        }
    }
}