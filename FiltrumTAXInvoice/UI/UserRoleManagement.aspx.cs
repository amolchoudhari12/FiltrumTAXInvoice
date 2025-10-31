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

public partial class UI_UserRoleManagement : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        try
        {

            if (!IsPostBack)
            {
                BindComboUser();
                User user = (User)Session[Constants.USER_FOR_EDIT];

                string[] str = Request.QueryString.GetValues("userOperation");

                if (str != null && str[0].ToString() == "edit")
                {
                    lblUserOperation.Text = Constants.USER_MODIFY;
                    BindUserDetailsForEdit(user);
                    btnSave.Text = "Modify";

                }
                else
                {
                    lblUserOperation.Text = Constants.USER_ADD;
                    ResetUserInputControls();
                }
            }
            Page.MaintainScrollPositionOnPostBack = true;

        }
        catch (Exception)
        {

            throw;
        }

    }

    private void BindComboUser()
    {
        try
        {
            User newUser = new User();
            UserBAL userBal = new UserBAL();

            DataTable dt = userBal.ViewUsers();

            comboUserName.DataSource = dt;
            comboUserName.DataValueField = "UserName";
            comboUserName.DataTextField = "UserName";
            comboUserName.DataBind();
        }
        catch (Exception)
        {

            throw;
        }
    }

    private void ResetUserInputControls()
    {
        try
        {

            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
            comboDepartment.SelectedValue = string.Empty;
            comboUserName.SelectedValue = string.Empty;
            ResetAllCheckBoxes();
            btnSave.Text = "Save";



        }
        catch (Exception)
        {

            throw;
        }
    }

    private void BindUserDetailsForEdit(User user)
    {
        try
        {
            txtUserName.Text = user.UserName;
            txtPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
            comboDepartment.SelectedItem.Text  = user.Department;
            comboUserName.SelectedItem.Text = user.UserName;
            chkCustometMgt.Checked = Convert.ToBoolean(user.AllowCustomerManagement);

            chkCustomerOptions.Items[0].Selected = Convert.ToBoolean(user.AllowCustomerAdd);
            chkCustomerOptions.Items[1].Selected = Convert.ToBoolean(user.AllowCustomerModify);
            chkCustomerOptions.Items[2].Selected = Convert.ToBoolean(user.AllowCustomerView);

            chkProductMgt.Checked = Convert.ToBoolean(user.AllowProductManagement);

            chkProductOptions.Items[0].Selected = Convert.ToBoolean(user.AllowPoductAdd);
            chkProductOptions.Items[1].Selected = Convert.ToBoolean(user.AllowPoductModify);
            chkProductOptions.Items[2].Selected = Convert.ToBoolean(user.AllowProductView);


            chkPOMgt.Checked = Convert.ToBoolean(user.AllowPOManagement);

            chkPOOptions.Items[0].Selected = Convert.ToBoolean(user.AllowPOAdd);
            chkPOOptions.Items[1].Selected = Convert.ToBoolean(user.AllowPOModify);
            chkPOOptions.Items[2].Selected = Convert.ToBoolean(user.AllowPOView);

            chkInvoice.Checked = Convert.ToBoolean(user.AllowInvoiceManagement);

            chkInvoiceOptions.Items[0].Selected = Convert.ToBoolean(user.AllowInvoiceAdd);
            chkInvoiceOptions.Items[1].Selected = Convert.ToBoolean(user.AllowInvoiceView );

            chkUserRoleMgt.Checked = Convert.ToBoolean(user.AllowUserRoleManagement);
            chkCustomerReport.Checked = Convert.ToBoolean(user.AllowRptCustomerDetails);
            chkProductReport.Checked = Convert.ToBoolean(user.AllowRptProductDetails);
            ckhPODetailsReport.Checked = Convert.ToBoolean(user.AllowRptPOs);
            chkInvoiceDetails.Checked = Convert.ToBoolean(user.AllowRptInvoiceDetails);

            btnSave.Text = "Save";


        }
        catch (Exception)
        {

            throw;
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        try
        {

            string operationType = btnSave.Text.ToString();

            switch (operationType)
            {

                case "Save":
                    AddThisUser();
                    break;

                case "Modify":

                    ModifyThisUser();
                    break;


            }

        }
        catch (Exception)
        {

            throw;
        }
    }

    private void ModifyThisUser()
    {
        try
        {
            User newUser = new User();
            UserBAL balUser = new UserBAL();

            newUser.UserName = txtUserName.Text;
            newUser.Password = txtPassword.Text;
            newUser.UserType = string.Empty;
            newUser.Department = comboDepartment.SelectedItem.Text ;
            newUser.Description = "Description";
            newUser.AllowCustomerManagement = Convert.ToBoolean(chkCustometMgt.Checked);


            newUser.AllowCustomerAdd = Convert.ToBoolean(chkCustomerOptions.Items[0].Selected);
            newUser.AllowCustomerModify = Convert.ToBoolean(chkCustomerOptions.Items[1].Selected);
            newUser.AllowCustomerView = Convert.ToBoolean(chkCustomerOptions.Items[2].Selected);

            newUser.AllowProductManagement = Convert.ToBoolean(chkProductMgt.Checked);

            newUser.AllowPoductAdd = Convert.ToBoolean(chkProductOptions.Items[0].Selected);
            newUser.AllowPoductModify = Convert.ToBoolean(chkProductOptions.Items[1].Selected);
            newUser.AllowProductView = Convert.ToBoolean(chkProductOptions.Items[2].Selected);

            newUser.AllowPOManagement = Convert.ToBoolean(chkPOMgt.Checked);

            newUser.AllowPOAdd = Convert.ToBoolean(chkPOOptions.Items[0].Selected);
            newUser.AllowPOModify  = Convert.ToBoolean(chkPOOptions.Items[1].Selected);
            newUser.AllowPOView = Convert.ToBoolean(chkPOOptions.Items[2].Selected);


            newUser.AllowInvoiceManagement = Convert.ToBoolean(chkInvoice.Checked);

            newUser.AllowInvoiceAdd = Convert.ToBoolean(chkInvoiceOptions.Items[0].Selected);
            newUser.AllowInvoiceView = Convert.ToBoolean(chkInvoiceOptions.Items[1].Selected);

            newUser.AllowUserRoleManagement = Convert.ToBoolean(chkUserRoleMgt.Checked);
            newUser.AllowRptCustomerDetails = Convert.ToBoolean(chkCustomerReport.Checked);
            newUser.AllowRptProductDetails = Convert.ToBoolean(chkProductReport.Checked);
            newUser.AllowRptPOs = Convert.ToBoolean(ckhPODetailsReport.Checked);
            newUser.AllowRptInvoiceDetails = Convert.ToBoolean(chkInvoiceDetails.Checked);




            int returnValue = balUser.ModifyUser(newUser);

            if (returnValue > 0)
            {

                Label1.Text = "User Modofied Successfully!!!";
                Label1.Visible = true;
            }
            else
            {
                Label1.Text = "User already exists!";
                Label1.Visible = true;
            }

        }
        catch (Exception)
        {

            throw;
        }
    }

    private void AddThisUser()
    {
        try
        {

            User newUser = new User();
            UserBAL balUser = new UserBAL();

            newUser.UserName = txtUserName.Text;
            newUser.Password = txtPassword.Text;
            newUser.UserType = "";
            newUser.Department = comboDepartment.SelectedItem.Text;
            newUser.Description = "Description";
            newUser.AllowCustomerManagement = Convert.ToBoolean(chkCustometMgt.Checked);

            newUser.AllowCustomerAdd = Convert.ToBoolean(chkCustomerOptions.Items[0].Selected);
            newUser.AllowCustomerModify = Convert.ToBoolean(chkCustomerOptions.Items[1].Selected);
            newUser.AllowCustomerView = Convert.ToBoolean(chkCustomerOptions.Items[2].Selected);

            newUser.AllowProductManagement = Convert.ToBoolean(chkProductMgt.Checked);

            newUser.AllowPoductAdd = Convert.ToBoolean(chkProductOptions.Items[0].Selected);
            newUser.AllowPoductModify = Convert.ToBoolean(chkProductOptions.Items[1].Selected);
            newUser.AllowProductView = Convert.ToBoolean(chkProductOptions.Items[2].Selected);

            newUser.AllowPOManagement = Convert.ToBoolean(chkPOMgt.Checked);

            newUser.AllowPOAdd = Convert.ToBoolean(chkPOOptions.Items[0].Selected);
            newUser.AllowPoductModify = Convert.ToBoolean(chkPOOptions.Items[1].Selected);
            newUser.AllowPOView = Convert.ToBoolean(chkPOOptions.Items[2].Selected);


            newUser.AllowInvoiceManagement = Convert.ToBoolean(chkInvoice.Checked);

            newUser.AllowInvoiceAdd = Convert.ToBoolean(chkInvoiceOptions.Items[0].Selected);
            newUser.AllowInvoiceView = Convert.ToBoolean(chkInvoiceOptions.Items[1].Selected);


            newUser.AllowUserRoleManagement = Convert.ToBoolean(chkUserRoleMgt.Checked);
            newUser.AllowRptCustomerDetails = Convert.ToBoolean(chkCustomerReport.Checked);
            newUser.AllowRptProductDetails = Convert.ToBoolean(chkProductReport.Checked);
            newUser.AllowRptPOs = Convert.ToBoolean(ckhPODetailsReport.Checked);
            newUser.AllowRptInvoiceDetails = Convert.ToBoolean(chkInvoiceDetails.Checked);




            int returnValue = balUser.AddUser(newUser);

            if (returnValue > 0)
            {

                Label1.Text = "User Added Successfully!!!";
                Label1.Visible = true;
            }
            else
            {
                Label1.Text = "User already exists!";
                Label1.Visible = true;
            }
        }
        catch (Exception)
        {

            throw;
        }
    }


    protected void comboUserName_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            User userForEdit = new User();
            UserBAL balUser = new UserBAL();

            if (Convert.ToString(comboUserName.SelectedValue) != Convert.ToString(0))
            {
                userForEdit = balUser.GetUserForEdit(comboUserName.SelectedValue.ToString());

                BindUserDetailsForEdit(userForEdit);
                btnSave.Text = "Modify";
            }



        }
        catch (Exception)
        {

            throw;
        }
    }
    protected void chkCustometMgt_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (chkCustometMgt.Checked == true)
            {
                foreach (ListItem item in chkCustomerOptions.Items)
                {
                    item.Selected = true;
                }

            }
            else
            {
                foreach (ListItem item in chkCustomerOptions.Items)
                {
                    item.Selected = false;
                }

            }

        }
        catch (Exception)
        {

            throw;
        }

    }
    protected void chkProductMgt_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (chkProductMgt.Checked == true)
            {
                foreach (ListItem item in chkProductOptions.Items)
                {
                    item.Selected = true;
                }

            }
            else
            {
                foreach (ListItem item in chkProductOptions.Items)
                {
                    item.Selected = false;
                }

            }

        }
        catch (Exception)
        {

            throw;
        }
    }
    protected void chkPOMgt_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (chkPOMgt.Checked == true)
            {
                foreach (ListItem item in chkPOOptions.Items)
                {
                    item.Selected = true;
                }

            }
            else
            {
                foreach (ListItem item in chkPOOptions.Items)
                {
                    item.Selected = false;
                }

            }

        }
        catch (Exception)
        {

            throw;
        }
    }
    protected void chkInvoice_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            if (chkInvoice.Checked == true)
            {
                foreach (ListItem item in chkInvoiceOptions.Items)
                {
                    item.Selected = true;
                }

            }
            else
            {
                foreach (ListItem item in chkInvoiceOptions.Items)
                {
                    item.Selected = false;
                }

            }

        }
        catch (Exception)
        {

            throw;
        }

    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        try
        {
            ResetAllCheckBoxes();

        }
        catch (Exception)
        {

            throw;
        }
    }

    private void ResetAllCheckBoxes()
    {
        chkCustometMgt.Checked = false;
        chkPOMgt.Checked = false;
        chkProductMgt.Checked = false;
        chkInvoice.Checked = false;
        chkUserRoleMgt.Checked = false;

        chkCustomerReport.Checked = false;
        chkProductReport.Checked = false;
        chkInvoiceDetails.Checked = false;
        ckhPODetailsReport.Checked = false;

        foreach (ListItem item in chkProductOptions.Items)
        {
            item.Selected = false;
        }

        foreach (ListItem item in chkPOOptions.Items)
        {
            item.Selected = false;
        }
        foreach (ListItem item in chkCustomerOptions.Items)
        {
            item.Selected = false;
        }

        foreach (ListItem item in chkInvoiceOptions.Items)
        {
            item.Selected = false;
        }


    }
    protected void btnClose_Click(object sender, EventArgs e)
    {
        Response.Redirect("Main.aspx");
    }
}
