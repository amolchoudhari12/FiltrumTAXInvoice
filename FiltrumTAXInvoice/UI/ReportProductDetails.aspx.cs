using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using FiltrumTaxInvoice.BusinessObjects.BO;
using FiltrumTaxInvoice.BAL;
using FiltrumTaxInvoice.BusinessObjects.Common;

public partial class UI_ReportProductDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            BindProductInfor();
    }

    private void BindProductInfor()
    {
        try
        {
            ProductBAL prodBal = new ProductBAL();
            DataTable dtProductDetails = prodBal.GetProductDetails ();

            grdProductDetails.DataSource = dtProductDetails;
            grdProductDetails.DataBind();

        }
        catch (Exception)
        {
            
            throw;
        }
    }
    protected void btnClose_Click(object sender, EventArgs e)
    {
        Response.Redirect("Main.aspx");
    }
}
