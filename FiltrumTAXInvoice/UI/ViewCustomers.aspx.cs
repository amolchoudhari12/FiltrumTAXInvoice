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

public partial class UI_ViewCustomers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack )
        {


            string[] str = Request.QueryString.GetValues("op");

            if (str != null && str[0].ToString() == "edit")
            {
                grdViewCustomers.Columns[13].Visible = true;
            }
            else if (str != null && str[0].ToString() == "view")
            {
                grdViewCustomers.Columns[13].Visible = false;
            }


            BindCustomerDetails();
        }

    }

    private void BindCustomerDetails()
    {
        try
        {
            Customer newCustomer = new Customer();
            CustomerBAL balCustomer = new CustomerBAL();

            DataTable dt = balCustomer.ViewCustomers();

            grdViewCustomers.DataSource = dt;
            grdViewCustomers.DataBind();



        }
        catch (Exception)
        {
            
            throw;
        }
    }


    protected void grdViewCustomers_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            

        }
        catch (Exception)
        {
            
            throw;
        }
    }
    protected void grdViewCustomers_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            int rowIndex = Convert.ToInt32(e.CommandArgument);
            int customerCode = 0;

            DataTable dt = (DataTable)grdViewCustomers.DataSource;

            customerCode = Convert.ToInt32(grdViewCustomers.Rows[rowIndex].Cells[0].Text);
       
            Customer newCustomer = new Customer();
            CustomerBAL balCustomer = new CustomerBAL();

            Customer customerForEdit = balCustomer.GetCustomerForEdit(customerCode);

            Session[Constants.CUSTOMER_FOR_EDIT] = customerForEdit;
            Session[Constants.CUSTOMER_OPERATION_TYPE] = Constants.CUSTOMER_MODIFY;

            Response.Redirect("CustomerManagement.aspx?operation=edit");         



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
}
