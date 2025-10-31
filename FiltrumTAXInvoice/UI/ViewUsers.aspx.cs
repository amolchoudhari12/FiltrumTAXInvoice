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

public partial class UI_ViewUsers : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

        try
        {
            if (!IsPostBack)
            {

                BindUserDetails();
            }

        }
        catch (Exception)
        {
            
            throw;
        }

    }

    private void BindUserDetails()
    {
        try
        {
            User newUser = new User();
            UserBAL balUser = new UserBAL();

            DataTable dt = balUser.ViewUsers ();

            grdViewUsers.DataSource = dt;
            grdViewUsers.DataBind();


        }
        catch (Exception)
        {
            
            throw;
        }
    }


    protected void grdViewUsers_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {

            int rowIndex = Convert.ToInt32(e.CommandArgument);
            string userName= string.Empty;

            DataTable dt = (DataTable)grdViewUsers.DataSource;

            userName = grdViewUsers.Rows[rowIndex].Cells[0].Text;

            User newUser = new User();
            UserBAL balUser = new UserBAL();

            User UserForEdit = balUser.GetUserForEdit(userName);

            Session[Constants.USER_FOR_EDIT ] = UserForEdit;
            Session[Constants.USER_OPERATION_TYPE] = Constants.USER_MODIFY;

            Response.Redirect("UserRoleManagement.aspx?userOperation=edit");         


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
