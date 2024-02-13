using Microsoft.Ajax.Utilities;
using System;
using System.Web;
using System.Web.UI;

namespace ecommerce
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TITOLO.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (!nome.Text.IsNullOrWhiteSpace() && !cognome.Text.IsNullOrWhiteSpace())
            {
                HttpCookie cookie = new HttpCookie("MYCOOKIE");
                cookie.Values["VALORENOME"] = nome.Text;
                cookie.Values["VALORECOGNOME"] = cognome.Text;
                cookie.Expires = DateTime.Now.AddDays(10);
                Response.Cookies.Add(cookie);
                Response.Redirect("PaginaProdotti.aspx");
            }
            else
            {
                TITOLO.Visible = true;
                return;
            }

        }
    }
}