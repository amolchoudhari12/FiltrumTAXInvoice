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

public partial class UI_ViewProducts : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {    
                string[] str = Request.QueryString.GetValues("prodOperation");

                if (str != null && str[0].ToString() == "edit")
                {
                    lblViewProducts.Text = Constants.PRODUCT_MODIFICATION_LIST;
                    grdViewProduct.Columns[5].Visible = true;
                   
                }                
                else if (str != null && str[0].ToString() == "view")
                {
                    grdViewProduct.Columns[5].Visible = false;
                }                          
          
            BindProductDetails();
        }

    }

    private void BindProductDetails()
    {
        try
        {

            Product newProduct = new Product();
            ProductBAL balProduct = new ProductBAL();

            DataTable dt = balProduct.ViewProducts();

            grdViewProduct.DataSource = dt;
            grdViewProduct.DataBind();

        }
        catch (Exception)
        {
            
            throw;
        }
    }
   
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Main.aspx");
    }


    protected void grdViewProduct_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            int rowIndex = Convert.ToInt32(e.CommandArgument);
            int productCode = 0;

            DataTable dt = (DataTable)grdViewProduct.DataSource;

            productCode = Convert.ToInt32(grdViewProduct.Rows[rowIndex].Cells[0].Text);

            Product newProduct = new Product();
            ProductBAL balProduct = new ProductBAL();

            Product ProductForEdit = balProduct.GetProductForEdit(productCode);

            Session[Constants.PRODUCT_FOR_EDIT] = ProductForEdit;
            Session[Constants.PRODUCT_OPERATION_TYPE ] = Constants.PRODUCT_MODIFY ;

            Response.Redirect("ProductManagement.aspx?operation=edit");    

        }
        catch (Exception)
        {
            
            throw;
        }
    }
}
