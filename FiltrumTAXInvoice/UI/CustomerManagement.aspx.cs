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
using FiltrumTaxInvoice.BusinessObjects.Common;
using FiltrumTaxInvoice.BusinessObjects.BO;
using FiltrumTaxInvoice.BAL;

public partial class UI_CustomerManagement : System.Web.UI.Page
{


    protected void Page_Load(object sender, EventArgs e)
    {

        try
        {
            if (!IsPostBack)
            {
                Customer customer = (Customer)Session[Constants.CUSTOMER_FOR_EDIT];

                string[] str = Request.QueryString.GetValues("operation");

                if (str != null && str[0].ToString() == "edit")
                {
                    lblCustOperation.Text = Constants.CUSTOMER_MODIFY_LABEL;
                    BindCustomerDetailsForEdit(customer);

                }
                else
                {
                    lblCustOperation.Text = Constants.CUSTOMER_ADD_LABEL;
                    ResetCustomerInputControls();
                }
            }
            Label1.Visible = false;

        }
        catch (Exception ex)
        {

            throw ex;
        }

    }

    /// <summary>
    /// Reset all the input controls.
    /// </summary>
    private void ResetCustomerInputControls()
    {
        txtCustomerCode.Text = string.Empty;
        txtCustomerFirstName.Text = string.Empty;
        txtCutomerLastName.Text = string.Empty;
        txtBillingAddress.Text = string.Empty;
        txtShippingAddress.Text = string.Empty;
        comboCountry.SelectedValue = string.Empty;
        txtState.Text = string.Empty;
        txtCity.Text = string.Empty;
        txtCity.Text = string.Empty;
        txtPhoneNumber.Text = string.Empty;
        txtFAXNumber.Text = string.Empty;
        txtEccCode.Text = string.Empty;
        //rdoListType.SelectedValue == true)
        
       // rdoForeign.Checked = false;
        txtDescription.Text = string.Empty;
        txtCessDuty.Text = string.Empty;
        txtECessDuty.Text = string.Empty;
        txtSHDuty.Text = string.Empty;
        txtExciseDuty.Text = string.Empty;
        txtVATRate.Text = string.Empty;

        btnADD.Text = "Add";



    }

    private void BindCustomerDetailsForEdit(Customer customer)
    {
        try
        {

            txtCustomerCode.Text = customer.CusomerCode.ToString();
            txtCustomerFirstName.Text = customer.CustomerFirstName;
            txtCutomerLastName.Text = customer.CustomerLastName;
            txtBillingAddress.Text = customer.BillingAddress;
            txtShippingAddress.Text = customer.ShippingAddress;
            comboCountry.SelectedValue = customer.Country;
            txtState.Text = customer.State;
            txtCity.Text = customer.City;
            txtCity.Text = customer.PinCode.ToString();
            txtPhoneNumber.Text = customer.PhoneNumber.ToString();
            txtFAXNumber.Text = customer.FaxNumber.ToString();
            txtEccCode.Text = customer.ECCNo;
            if (Convert.ToBoolean(customer.IsDomestic) == true)
                rdoListType.SelectedIndex = 0;
            else
                rdoListType.SelectedIndex = 1;

            txtDescription.Text = customer.Description;

            txtCessDuty.Text = customer.CessDuty.ToString();
            txtECessDuty.Text = customer.EcessDuty.ToString();
            txtSHDuty.Text = customer.SHCessDuty.ToString();
            txtExciseDuty.Text = customer.ExciseDuty.ToString();
            txtVATRate.Text = customer.VATDuty.ToString();

            btnADD.Text = "Modify";




        }
        catch (Exception)
        {

            throw;
        }
    }


    protected void btnADD_Click(object sender, EventArgs e)
    {
        try
        {

            string operationType = btnADD.Text.ToString();

            switch (operationType)
            {

                case "Add":
                    AddThisCustomer();
                    break;

                case "Modify":

                    ModifyThisCustomer();
                    break;


            }



        }
        catch (Exception)
        {

            throw;
        }
    }

    private void ModifyThisCustomer()
    {

        try
        {

            Customer newCustomer = new Customer();
            CustomerBAL balCustomer = new CustomerBAL();

           // newCustomer.CusomerCode = Convert.ToInt32(txtCustomerCode.Text);
            newCustomer.CustomerFirstName = txtCustomerFirstName.Text;
            newCustomer.CustomerLastName = txtCutomerLastName.Text;
            newCustomer.BillingAddress = txtBillingAddress.Text;
            newCustomer.ShippingAddress = txtShippingAddress.Text;
            newCustomer.ECCNo = txtEccCode.Text;
            newCustomer.Country = comboCountry.SelectedItem.ToString();
            newCustomer.State = txtState.Text;
            newCustomer.City = txtCity.Text;
            if (txtPinCode.Text != "")
                newCustomer.PinCode = Convert.ToInt32(txtPinCode.Text);
            if (txtPhoneNumber.Text != "")
                newCustomer.PhoneNumber = txtPhoneNumber.Text;
            if (txtFAXNumber.Text != "")
                newCustomer.FaxNumber =txtFAXNumber.Text;
            newCustomer.Email = txtEmail.Text;
            if (txtCessDuty.Text != "")
                newCustomer.CessDuty = Convert.ToDecimal(txtCessDuty.Text);
            if (txtECessDuty.Text != "")
                newCustomer.EcessDuty = Convert.ToDecimal(txtECessDuty.Text);
            if (txtSHDuty.Text != "")
                newCustomer.SHCessDuty = Convert.ToDecimal(txtSHDuty.Text);
            if (txtVATRate.Text != "")
                newCustomer.VATDuty = Convert.ToDecimal(txtVATRate.Text);
            if (txtExciseDuty.Text != "")
                newCustomer.ExciseDuty = Convert.ToDecimal(txtExciseDuty.Text);
            if (rdoListType.SelectedIndex == 0)
                newCustomer.IsDomestic = true;
            else
                newCustomer.IsDomestic = false;

            newCustomer.Description = txtDescription.Text;


            int returnValue = balCustomer.ModifyCustomer(newCustomer, Convert.ToInt32( txtCustomerCode.Text ));

            if (returnValue > 0)
            {

                Label1.Text = "Customer is modified Successfully";
                Label1.Visible = true;
            }

        }
        catch (Exception)
        {

            throw;
        }


    }

    private void AddThisCustomer()
    {
        Customer newCustomer = new Customer();
        CustomerBAL balCustomer = new CustomerBAL();

      //  newCustomer.CusomerCode = Convert.ToInt32(txtCustomerCode.Text);
        newCustomer.CustomerFirstName = txtCustomerFirstName.Text;
        newCustomer.CustomerLastName = txtCutomerLastName.Text;
        newCustomer.BillingAddress = txtBillingAddress.Text;
        newCustomer.ShippingAddress = txtShippingAddress.Text;
        newCustomer.ECCNo = txtEccCode.Text;
        newCustomer.Country = comboCountry.SelectedItem.ToString();
        newCustomer.State = txtState.Text;
        newCustomer.City = txtCity.Text;
        if (txtPinCode.Text != "")
            newCustomer.PinCode = Convert.ToInt32(txtPinCode.Text);
        if (txtPhoneNumber.Text != "")
            newCustomer.PhoneNumber = txtPhoneNumber.Text;
        if (txtFAXNumber.Text != "")
            newCustomer.FaxNumber = txtFAXNumber.Text;
        newCustomer.Email = txtEmail.Text;
        if (txtCessDuty.Text != "")
            newCustomer.CessDuty = Convert.ToDecimal(txtCessDuty.Text);
        if (txtECessDuty.Text != "")
            newCustomer.EcessDuty = Convert.ToDecimal(txtECessDuty.Text);
        if (txtSHDuty.Text != "")
            newCustomer.SHCessDuty = Convert.ToDecimal(txtSHDuty.Text);
        if (txtVATRate.Text != "")
            newCustomer.VATDuty = Convert.ToDecimal(txtVATRate.Text);
        if (txtExciseDuty.Text != "")
            newCustomer.ExciseDuty = Convert.ToDecimal(txtExciseDuty.Text);
        if (rdoListType.SelectedIndex == 0)
            newCustomer.IsDomestic = true;
        else
            newCustomer.IsDomestic = false;

        newCustomer.Description = txtDescription.Text;
        int returnValue = balCustomer.AddCustomer(newCustomer);

        if (returnValue > 0)
        {

            Label1.Visible = true;
            txtCustomerCode.Text = returnValue.ToString();
            btnADD.Enabled = false;
        }

    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Main.aspx");
    }
}
