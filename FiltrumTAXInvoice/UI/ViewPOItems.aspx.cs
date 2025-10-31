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
using FiltrumTaxInvoice.BAL;
using FiltrumTaxInvoice.BusinessObjects.Common;

public partial class UI_ViewPOItems : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if( !IsPostBack)
            {
                BindPOItemsGrid();
            }
            

        }
        catch (Exception)
        {
            
            throw;
        }

    }

    private void BindPOItemsGrid()
    {
        try
        {
           int selectedPOID = Convert.ToInt32( Session["SELECTED_PO_ID"]) ;
           int selectedCustomerCode = Convert.ToInt32( Session["SELECTED_PO_CUSTOMER_CODE"]) ;
            


           POItemBAL poItemBal = new POItemBAL();

           DataTable dt = poItemBal.ViewPOItemsOfPO (selectedPOID);
           grdViewPOItems.DataSource = dt;
           grdViewPOItems.DataBind();
           txtCustomerCode.Text = selectedCustomerCode.ToString();

            if( Session["SELECTED_PO_CODE"] != null)
           txtPOCode.Text = Session["SELECTED_PO_CODE"].ToString();
          

           if (selectedPOID == 0 && selectedCustomerCode==0)
           {
               txtCustomerCode.Text = string.Empty;
               txtPOCode.Text = string.Empty;

           }

           Session["SELECTED_PO_ID"] = 0;
           Session["SELECTED_PO_CUSTOMER_CODE"] = 0;

        }
        catch (Exception)
        {
            
            throw;
        }
    }
    protected void grdViewPOItems_Sorting(object sender, GridViewSortEventArgs e)
    {

    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Main.aspx");
    }
    protected void grdViewPOItems_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {

    }
    protected void grdViewPOItems_RowCommand(object sender, GridViewCommandEventArgs e)
    {
         string operation = e.CommandName;

            int selectedIndex = Convert.ToInt32(e.CommandArgument);

            int selectedPOItemID = Convert.ToInt32(grdViewPOItems.Rows[selectedIndex].Cells[0].Text);


            switch (operation)
            {
                case "Delete":

                    POItemBAL poItemBal = new POItemBAL();

                    poItemBal.DeletePOItem(selectedPOItemID);

                    break;
            }




            Session["SELECTED_PO_ID"] = Convert.ToInt32(grdViewPOItems.Rows[selectedIndex].Cells[1].Text);
            Session["SELECTED_PO_CUSTOMER_CODE"] = txtCustomerCode.Text ;
            Session["SELECTED_PO_CODE"] = txtPOCode.Text;
            BindPOItemsGrid();
            //Response.Redirect("~/UI/ViewPOItems.aspx");

    }
    protected void grdViewPOItems_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

    }
}
