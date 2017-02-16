using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnIngresar_Click(object sender, EventArgs e)
    {
        /*var workbook = new XLWorkbook();      ESTE CODIGO YA FUNCIONA COMPLETAMENTE E INCLUSO MODIFICA EL ARCHIVO YA EXISTENTE
        var worksheet = workbook.Worksheets.Add("Lista de produccion");
        worksheet.Cell("A2").Value = "Prueba de creacion y uso de Closed XML.";
        if (worksheet.Cell("A2").Value.ToString() != "")
        {
            worksheet.Cell("A3").Value = "Consecutivo del ultimo valor añadido.";
        }
        workbook.SaveAs("c:\\Users\\Programacion\\Downloads\\Lista de produccion.xlsx");*/
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string check =  ClsUsers.CheckPassword(txtuser.Value.Trim(), txtpswd.Value.Trim());
        if (check != "")
        {
            string[] R = check.Split(',');
            if (R[3] == "T")
            {
                FormsAuthenticationTicket AuthTicket = new FormsAuthenticationTicket(1, R[0], DateTime.Now, DateTime.Now.AddMinutes(30), false, R[2], FormsAuthentication.FormsCookiePath);

                string encTicket = FormsAuthentication.Encrypt(AuthTicket);
                Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, encTicket));

                if (R[0] == "DC56D2B35A5FABAE81D515ACF246DB8470FDE96C") Response.Redirect("~/AdministrationForms/MainAdministration");//Realizar modificaciones hay que desencriptar esto 
                else if (R[0] == "9F101B354DAB3608212B291B73A78BED99C9E6F0") Response.Redirect("~/DesignForms"); //o encriptar el web config
            }
        }
        //ClsUsers.EncryptXML("Ye","123","Ingenieria");
    }
}