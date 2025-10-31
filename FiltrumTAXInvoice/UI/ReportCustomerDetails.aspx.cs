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

public partial class UI_ReportCustomerDetails : System.Web.UI.Page
{
    public static string customerName  = "";

    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {

            BindCustomerDetails();
            tblTaxRates.Visible = false;
            tblPOs.Visible = false;
            tblInvoices.Visible = false;
        }
    }

    private void BindCustomerDetails()
    {
        try
        {
            CustomerBAL custBal = new CustomerBAL();
            DataTable dtCustomers = custBal.GetCustomerDetailsReport();

            grdCustomerDetails.DataSource = dtCustomers;
            grdCustomerDetails.DataBind();

        }
        catch (Exception)
        {

            throw;
        }
    }
    protected void grdCustomerDetails_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            string commandName = e.CommandName;
            int rowIndex = Convert.ToInt32(e.CommandArgument);
            int customerCode = 0;

            customerCode = Convert.ToInt32(grdCustomerDetails.Rows[rowIndex].Cells[0].Text);
           customerName = grdCustomerDetails.Rows[rowIndex].Cells[1].Text;

            switch (commandName)
            {

                case "TaxRates":
                    BindTAXRateDetails(customerCode);
                    break;

                case "NoOfPOs":
                    BindPOsOfCustomer(customerCode);
                    break;

                case "NoOfInvoice":
                    BindInvoiceDetails(customerCode);
                    break;

            }

        }
        catch (Exception)
        {

            throw;
        }
    }

    private void BindInvoiceDetails(int customerCode)
    {
        try
        {
            if (customerCode > 0)
            {

                tblInvoices.Visible = true;

                InvoiceBAL balInvoice = new InvoiceBAL();

                DataTable dt = balInvoice.GetInvoicesOfCustomer(customerCode);

                lblCustomerName.Text = customerName;
                grdInvoices.DataSource = dt;
                grdInvoices.DataBind();
                SetFocus(btnClose2);
            }

        }
        catch (Exception)
        {

            throw;
        }
    }

    private void BindPOsOfCustomer(int customerCode)
    {
        try
        {
            if (customerCode > 0)
            {
                tblPOs.Visible = true;
                PurchaseOrder newPurchaseOrder = new PurchaseOrder();
                PurchaseOrderBAL balPurchaseOrder = new PurchaseOrderBAL();

                DataTable dt = balPurchaseOrder.GetPurchaseOrdersOfthisCustomer(customerCode);

                lblCustomerName1.Text = customerName;

                grdViewPOs.DataSource = dt;
                grdViewPOs.DataBind();
                SetFocus(btnClose1);
            }
        }
        catch (Exception)
        {

            throw;
        }
    }

    private void BindTAXRateDetails(int customerCode)
    {
        try
        {

            if (customerCode > 0)
            {
                tblTaxRates.Visible = true;

                Customer customer = new Customer();
                CustomerBAL custBal = new CustomerBAL();

                customer = custBal.GetCustomerForEdit(customerCode);

                if (customer.ExciseDuty > 0)
                    lblExciseDuty.Text = customer.ExciseDuty.ToString() + " %";
                else
                    lblExciseDuty.Text = string.Empty;
                if (customer.CessDuty > 0)
                    lblCessDuty.Text = customer.CessDuty.ToString() + " %";
                else
                    lblCessDuty.Text = string.Empty;
                if (customer.EcessDuty > 0)
                    lblEcessDuty.Text = customer.EcessDuty.ToString() + " %";
                else
                    lblEcessDuty.Text = string.Empty;
                if (customer.SHCessDuty > 0)
                    lblSHCessDuty.Text = customer.SHCessDuty.ToString() + " %";
                else
                    lblSHCessDuty.Text = string.Empty;
                if (customer.VATDuty > 0)
                    lblVATRate.Text = customer.VATDuty.ToString() + " %";
                else
                    lblVATRate.Text = string.Empty;
                SetFocus(btnClose);
            }


        }

        catch (Exception)
        {

            throw;
        }
    }
    protected void grdCustomerDetails_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void btnClose_Click(object sender, EventArgs e)
    {
        tblTaxRates.Visible = false;

    }
    protected void grdViewPOs_RowCommand(object sender, GridViewCommandEventArgs e)
    {

    }
    protected void btnClose1_Click(object sender, EventArgs e)
    {
        tblPOs.Visible = false;

    }
    protected void btnClose2_Click(object sender, EventArgs e)
    {
        tblInvoices.Visible = false;
    }
}
