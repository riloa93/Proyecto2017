using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DesignForms_DesignMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void lnkHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/DesignForms/MainDesign.aspx");
    }

    protected void lnkAsign_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/DesignForms/AsignDesign.aspx");
    }

    protected void lnkorder_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/DesignForms/MainDesign.aspx");
    }

    protected void lnkClose_Click(object sender, EventArgs e)
    {
        HttpCookie myCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
        if (myCookie != null)
        {
            myCookie.Expires = DateTime.Now;
            Response.Cookies.Set(myCookie);
            Response.Redirect("~/default.aspx");
        }
    }
}
