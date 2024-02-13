using System;
using System.Web;
using System.Web.UI.WebControls;

namespace ecommerce
{
    public partial class PaginaProdotti : System.Web.UI.Page
    {

        // List<string> ListaItem = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {
            noProdottiInLista.Visible = false;
            // se al caricamento della pagina non è presente il cookie che contiene nome cognome utente redirecta al default 
            if (Request.Cookies["MYCOOKIE"] != null)
            {
                Label1.Text = "Benvenuto nella pagina prodotti" + " " + Request.Cookies["MYCOOKIE"]["VALORENOME"] + " " + Request.Cookies["MYCOOKIE"]["VALORECOGNOME"];
                // lascia accedere alla pagina 

                // creo un cookie 
                HttpCookie nuovoCookie = new HttpCookie("nuovoCookie");
                nuovoCookie.Values["nuovoCookie"] = string.Empty;
                Response.Cookies.Add(nuovoCookie);
            }
            else
            {
                Response.Redirect("default.aspx");
            }
        }

        protected void AddtoWishlist(object sender, EventArgs e)
        {
            // ottieni il pulsante che ha scatenato l'evento e prendi il commandArgument
            string parametro = ((Button)sender).CommandArgument;

            if (Request.Cookies["nuovoCookie"] != null)
            {

                string valoreGiapresente = Request.Cookies["nuovoCookie"].Value;
                valoreGiapresente += parametro + "//";

                // Crea un nuovo cookie per aggiornare il valore
                HttpCookie altroCookie = new HttpCookie("nuovoCookie");

                // Assegna il valore aggiornato al nuovo cookie
                altroCookie.Value = valoreGiapresente;

                // Imposta la scadenza del cookie
                altroCookie.Expires = DateTime.Now.AddDays(10);

                // Aggiungi il cookie alla risposta
                Response.Cookies.Add(altroCookie);


            }
        }

        protected void VaiWishList(object sender, EventArgs e)
        {

            Response.Redirect("PaginaPreferiti.aspx");

        }
    }
}