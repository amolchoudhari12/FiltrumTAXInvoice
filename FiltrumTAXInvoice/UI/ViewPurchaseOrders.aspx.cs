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


public partial class UI_ViewPurchaseOrders : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
               
                BindPurchaseOrderGrid();
                tblModifyPO.Visible = false;
            }

        }
        catch (Exception)
        {
            
            throw;
        }

    }

    private void BindPurchaseOrderGrid()
    {
        try
        {

            PurchaseOrder newPurchaseOrder = new PurchaseOrder();
            PurchaseOrderBAL balPurchaseOrder = new PurchaseOrderBAL();

            DataTable dt = balPurchaseOrder.ViewPurchaseOrders();
            Session["dt"] = dt;

            grdViewPOs.DataSource = dt;
            grdViewPOs.DataBind();

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
  
    protected void grdViewPOs_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            string operation = e.CommandName;

            int selectedIndex = Convert.ToInt32(e.CommandArgument);

            int selectedPOID = Convert.ToInt32(grdViewPOs.Rows[selectedIndex].Cells[1].Text);

            int selectedCustomerCode = Convert.ToInt32(grdViewPOs.Rows[selectedIndex].Cells[0].Text);

            Session["SELECTED_PO_ID" ] = selectedPOID;
            Session["SELECTED_PO_CUSTOMER_CODE" ] = selectedCustomerCode;
            Session["SELECTED_PO_CODE"] = Convert.ToString (grdViewPOs.Rows[selectedIndex].Cells[2].Text);


            switch (operation)
            {
                case "Edit":
                    tblModifyPO.Visible = true;
                    BindThisPOToForm(selectedPOID);

                    break;
              

                case "Select":


                    Response.Redirect("~/UI/ViewPOItems.aspx");
                   

                    break;

               
                 

            }

        }
        catch (Exception)
        {

            throw;
        }

    }

    private void BindThisPOToForm(int selectedPOID)
    {
        try
        {
            PurchaseOrder po = new PurchaseOrder();
            PurchaseOrderBAL poBAL = new PurchaseOrderBAL();

            po = poBAL.GetPurchaseOrderForEdit(selectedPOID);

            Session["PurchaseOrder"] = po;
            Response.Redirect("~/UI/PurchaseOrderManagement.aspx?operation=edit");
        }
        catch (Exception)
        {
            
            throw;
        }
    }

    
    protected void grdViewPOs_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void btnModify_Click(object sender, EventArgs e)
    {
        try
        {
            
            PurchaseOrder newPurchaseOrder = new PurchaseOrder();
            PurchaseOrderBAL balPurchaseOrder = new PurchaseOrderBAL();

            newPurchaseOrder.PurchaseOrderCode = txtPOCode .Text;
            newPurchaseOrder.PODate = Convert.ToDateTime(txtPODate.Text);
            newPurchaseOrder.Description = "";
            newPurchaseOrder.PONum = Convert.ToInt32(txtPOID.Text);


            int returnValue = balPurchaseOrder.ModifyPurchaseOrder (newPurchaseOrder, Convert.ToInt32(comboCustomerCode.SelectedValue));

           
        }
        catch (Exception)
        {
            
            throw;
        }
    }
    protected void grdViewPOs_RowEditing(object sender, GridViewEditEventArgs e)
    {

    }
    protected void grdViewPOs_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        grdViewPOs.PageIndex = e.NewPageIndex;
        grdViewPOs.DataSource = Session["dt"];
        grdViewPOs.DataBind();

    }
}
