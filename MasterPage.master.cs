using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void StronaGlowna_Click(object sender, EventArgs e)//TODO: Obsługa błędu w momencie klikniecia StronyG w momencie kiedy się na niej znajdujemy
    {
        Server.Transfer("StronaGlowna.aspx", true);
    }
    protected void Blog_Click(object sender, EventArgs e)
    {
        Server.Transfer("Blog.aspx", true);
    }
    protected void Zaloguj_Click(object sender, EventArgs e)
    {
        Server.Transfer("Logowanie.aspx", true);
    }
    protected void Zarejestruj_Click(object sender, EventArgs e)
    {
        Server.Transfer("Rejestracja.aspx", true);
    }
}
