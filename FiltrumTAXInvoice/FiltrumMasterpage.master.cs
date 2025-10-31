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

public partial class FiltrumMasterpage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {

                if (Session["UserName"] != null && Session["UserName"].ToString() != string.Empty)
                {
                    DisableAllMainMenu();

                    string userName = Session["UserName"].ToString();
                    lblUserName.Text = userName;

                    User logedinUser = new User();
                    UserBAL balUser = new UserBAL();

                    logedinUser = balUser.GetUserForEdit(userName);
                    BindMainMenuForThisUser(logedinUser);
                }
            }



        }
        catch (Exception)
        {

            throw;
        }
    }

    private void BindMainMenuForThisUser(User logedinUser)
    {
        try
        {
           

            if (logedinUser.AllowCustomerManagement)
            {
                mainMenu.Items[0].Enabled = true;
            }

            if (logedinUser.AllowCustomerAdd)
            {
                mainMenu.Items[0].ChildItems[0].Enabled = true;
                mainMenu.Items[0].Enabled = true;               
            }

            if (logedinUser.AllowCustomerModify)
            {
                mainMenu.Items[0].ChildItems[1].Enabled = true;
                mainMenu.Items[0].Enabled = true;               
            }

            if (logedinUser.AllowCustomerView)
            {
                mainMenu.Items[0].ChildItems[2].Enabled = true;
                mainMenu.Items[0].Enabled = true;             
            }

              

            if (logedinUser.AllowProductManagement)
            {
                mainMenu.Items[1].Enabled = true;

            }
            if (logedinUser.AllowPoductAdd)
            {
                mainMenu.Items[1].ChildItems[0].Enabled = true;
                mainMenu.Items[1].Enabled = true;
            }
            if (logedinUser.AllowPoductModify)
            {
                mainMenu.Items[1].ChildItems[1].Enabled = true;
                mainMenu.Items[1].Enabled = true;
            }
            if (logedinUser.AllowProductView)
            {
                mainMenu.Items[1].ChildItems[2].Enabled = true;
                mainMenu.Items[1].Enabled = true;
            }
          
            if (logedinUser.AllowPOManagement)
            {
                mainMenu.Items[2].Enabled = true;

            }
            if (logedinUser.AllowPOAdd)
            {
                mainMenu.Items[2].ChildItems[0].Enabled = true;
                mainMenu.Items[2].Enabled = true;
            }
            if (logedinUser.AllowPOModify)
            {
                mainMenu.Items[2].ChildItems[1].Enabled = true;
                mainMenu.Items[2].Enabled = true;
            }
            if (logedinUser.AllowPOView)
            {
                mainMenu.Items[2].ChildItems[2].Enabled = true;
                mainMenu.Items[2].Enabled = true;
            }

           
            if (logedinUser.AllowInvoiceManagement)
            {
                mainMenu.Items[3].Enabled = true;


            }
            if (logedinUser.AllowInvoiceAdd)
            {
                mainMenu.Items[3].ChildItems[0].Enabled = true;
                mainMenu.Items[3].Enabled = true;
            }
            //if (logedinUser.AllowInvoiceView)
            //{
            //    mainMenu.Items[3].ChildItems[1].Enabled = true;
            //    mainMenu.Items[3].Enabled = true;


            //}
           

            if (logedinUser.AllowRptCustomerDetails)
            {
                mainMenu.Items[4].Enabled = true;
                mainMenu.Items[4].ChildItems[0].Enabled = true;
            }

            if (logedinUser.AllowRptProductDetails )
            {
                mainMenu.Items[4].Enabled = true;
                mainMenu.Items[4].ChildItems[1].Enabled = true;
            }


            if (logedinUser.AllowRptPOs)
            {
                mainMenu.Items[4].Enabled = true;
                mainMenu.Items[4].ChildItems[2].Enabled = true;
            }

            //if (logedinUser.AllowRptInvoiceDetails )
            //{
            //    mainMenu.Items[4].Enabled = true;
            //    mainMenu.Items[4].ChildItems[3].Enabled = true;
            //}



            if (logedinUser.AllowUserRoleManagement)
            {
                mainMenu.Items[5].Enabled = true;

                
                foreach (MenuItem item in mainMenu.Items[5].ChildItems)
                {
                    item.Enabled = true;
                }
            }



            mainMenu.Items[6].Enabled = true;
        }
        catch (Exception)
        {

            throw;
        }
    }

    private void DisableAllMainMenu()
    {

        for (int i = 0; i < mainMenu.Items.Count; i++)
        {
            mainMenu.Items[i].Enabled = false;

            if (mainMenu.Items[i].ChildItems.Count > 0)
            {
                for (int j = 0; j < mainMenu.Items[i].ChildItems.Count; j++)
                {
                    mainMenu.Items[i].ChildItems[j].Enabled = false;
                }
            }
        }

       
    }



}
