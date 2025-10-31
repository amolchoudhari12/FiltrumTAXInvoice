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

public partial class UI_PurchaseOrderManagement : System.Web.UI.Page
{


    protected void Page_Load(object sender, EventArgs e)
    {

        try
        {
            if (!IsPostBack)
            {

               
                PurchaseOrder po = (PurchaseOrder)Session["PurchaseOrder"];

                string[] str = Request.QueryString.GetValues("operation");

                if (str != null && str[0].ToString() == "edit")
                {

                    BindPODetailsForEdit(po);

                }
                else
                {
                    ResetControls();
                }

            }

            Page.MaintainScrollPositionOnPostBack = true;
        }
        catch (Exception)
        {

            throw;
        }

    }

    private void BindPODetailsForEdit(PurchaseOrder po)
    {
        try
        {
            comboCustomerCode.SelectedValue = po.CustomerCode.ToString();
            BindCustomerDetails(po.CustomerCode);
            txtPOCode.Text = po.PurchaseOrderCode;
            txtPODate.Text = po.PODate.ToString();
            txtNumberOfRows.Enabled = true;
            btnCreateRows.Enabled = true;
            btnAddPO.Enabled = false;

        }
        catch (Exception)
        {
            
            throw;
        }
    }

    private void ResetControls()
    {
        try
        {
            txtNumberOfRows.Enabled = false;
            btnCreateRows.Enabled = false;

        }
        catch (Exception)
        {
            
            throw;
        }
    }

    private void BindCustomerCodeComboBox()
    {
        try
        {
            Customer newCustomer = new Customer();
            CustomerBAL custBAL = new CustomerBAL();
            ArrayList custList = new ArrayList();

            DataTable dt = custBAL.ViewCustomers();

            foreach (DataRow dr in dt.Rows)
            {
                custList.Add(dr["CustomerCode"]);

            }

            comboCustomerCode.DataSource = custList;
            comboCustomerCode.DataBind();


        }
        catch (Exception)
        {

            throw;
        }
    }
    protected void btnAddPO_Click(object sender, EventArgs e)
    {
        try
        {

            PurchaseOrder newPurchaseOrder = new PurchaseOrder();
            PurchaseOrderBAL balPurchaseOrder = new PurchaseOrderBAL();

            if (txtPOCode.Text != string.Empty)
            {
                rfvPOCode.Visible = false;

                newPurchaseOrder.PurchaseOrderCode = txtPOCode.Text;
                newPurchaseOrder.PODate = Calendar1.SelectedDate;


                int returnValue = balPurchaseOrder.AddPurchaseOrder(newPurchaseOrder, Convert.ToInt32(comboCustomerCode.SelectedValue));

                btnAddPO.Enabled = false;
                txtCustomerName.Enabled = false;
                txtPOCode.Enabled = false;
                txtBillTo.Enabled = false;
                txtShipTo.Enabled = false;
                Calendar1.Enabled = false;
                txtPODate.Enabled = false;
                comboCustomerCode.Enabled = false;

                txtNumberOfRows.Enabled = true;
                btnCreateRows.Enabled = true;

            }
            else
            {
                rfvPOCode.Visible = true;
            }



        }
        catch (Exception)
        {

            throw;
        }
    }
    protected void btnCreateRows_Click(object sender, EventArgs e)
    {
        try
        {

            int numberOrRows = Convert.ToInt32(txtNumberOfRows.Text);
            BindRowsToGrid(numberOrRows);

        }
        catch (Exception)
        {

            throw;
        }
    }

    private void BindRowsToGrid(int numberOrRows)
    {
        try
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(Constants.DT_PRODUCTCODE_COLUMN);
            dt.Columns.Add(Constants.DT_PRODUCTNAME_COLUMN);
            dt.Columns.Add(Constants.DT_CUSTOMER_PART_NO_COLUMN);
            dt.Columns.Add(Constants.DT_FFTL_PART_NO_COLUMN);
            dt.Columns.Add(Constants.DT_QUANTITY_COLUMN);
            dt.Columns.Add(Constants.DT_UNIT_COLUMN);
            dt.Columns.Add(Constants.DT_PRICE_COLUMN);


            for (int index = 0; index < numberOrRows; index++)
            {
                DataRow dr = dt.NewRow();
                dt.Rows.Add(dr);
            }

            grdViewPOItems.DataSource = dt;
            grdViewPOItems.DataBind();
            AddItemsInProductCombo();




        }
        catch (Exception)
        {

            throw;
        }
    }

    private void AddItemsInProductCombo()
    {
        try
        {
            Product newProduct = new Product();
            ProductBAL balProduct = new ProductBAL();

            DataTable dt = balProduct.ViewProducts();


            for (int index = 0; index < grdViewPOItems.Rows.Count; index++)
            {
                GridViewRow row = grdViewPOItems.Rows[index];
                DropDownList comboProductList = (DropDownList)row.FindControl("comboProductName");

                ListItem listDefault = new ListItem();
                listDefault.Text = string.Empty;
                listDefault.Value = "0";
                comboProductList.Items.Add(listDefault);

                foreach (DataRow dr in dt.Rows)
                {
                    ListItem lstItem = new ListItem();
                    lstItem.Text = dr["ProductName"].ToString();
                    lstItem.Value = dr["ProductCode"].ToString();
                    comboProductList.Items.Add(lstItem);
                }
                TextBox ProductCode = (TextBox)row.FindControl("txtProductCode");
                ProductCode.Text = (comboProductList.SelectedItem.Value);
            }


        }
        catch (Exception)
        {

            throw;
        }
    }



    protected void comboCustomerCode_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {

            int selectedCustomerCode = Convert.ToInt32(comboCustomerCode.SelectedValue);

            BindCustomerDetails(selectedCustomerCode);




        }
        catch (Exception)
        {

            throw;
        }

    }

    private void BindCustomerDetails(int selectedCustomerCode)
    {
        try
        {
            Customer newCustomer = new Customer();
            CustomerBAL custBAL = new CustomerBAL();

            if (Convert.ToInt32(selectedCustomerCode) != 0)
            {
                newCustomer = custBAL.GetCustomerForEdit(Convert.ToInt32(selectedCustomerCode));

                txtCustomerName.Text = newCustomer.CustomerFirstName + newCustomer.CustomerLastName;
                txtBillTo.Text = newCustomer.BillingAddress;
                txtShipTo.Text = newCustomer.ShippingAddress;
            }
            else
            {
                txtCustomerName.Text = string.Empty;
                txtBillTo.Text = string.Empty;
                txtShipTo.Text = string.Empty;
            }

        }
        catch (Exception)
        {
            
            throw;
        }
    }

    protected void comboProductName_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {


            //DropDownList comboProductList = (DropDownList)grdViewPOItems.FindControl("comboProductName");
            //string selectedProductCode = comboProductList.SelectedValue;

            //Product newProduct = new Product();
            //ProductBAL prodBAL = new ProductBAL();

            for (int index = 0; index < grdViewPOItems.Rows.Count; index++)
            {
                GridViewRow row = grdViewPOItems.Rows[index];
                DropDownList comboProductList = (DropDownList)row.FindControl("comboProductName");


                TextBox ProductCode = (TextBox)row.FindControl("txtProductCode");
                ProductCode.Text = (comboProductList.SelectedItem.Value);
            }



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

            POItemBAL poitemBAL = new POItemBAL();

            DataTable dt = MapThisGridIntoDataTable();

            foreach (DataRow dr in dt.Rows)
            {
                POItem newPOItem = new POItem();

                newPOItem.ProductCode = Convert.ToInt32(dr[Constants.DT_PRODUCT_CODE_COLUMN]);

                if (newPOItem.ProductCode > 0)
                {
                    if (dr[Constants.DT_CUSTOMER_PART_NO_COLUMN].ToString() != string.Empty)
                        newPOItem.CustomerPartNumber = dr[Constants.DT_CUSTOMER_PART_NO_COLUMN].ToString();
                    else
                        continue;
                    if (dr[Constants.DT_FFTL_PART_NO_COLUMN].ToString() != string.Empty)
                        newPOItem.FFTLPartNumber  =dr[Constants.DT_FFTL_PART_NO_COLUMN].ToString();
                    else
                        continue;
                    if (dr[Constants.DT_POITEM_NAME_COLUMN].ToString() != string.Empty)
                        newPOItem.ProductName = Convert.ToString(dr[Constants.DT_POITEM_NAME_COLUMN]);
                    else
                        continue;
                    if (dr[Constants.DT_UNIT_COLUMN].ToString() != string.Empty)
                        newPOItem.UnitOfMesurement = dr[Constants.DT_UNIT_COLUMN].ToString();
                    else
                        continue;
                    if (dr[Constants.DT_PRICE_COLUMN].ToString() != string.Empty)
                        newPOItem.PriceRate = Convert.ToDouble(dr[Constants.DT_PRICE_COLUMN]);
                    else
                        continue;


                    int reuturnValue = poitemBAL.AddPOItem(newPOItem, txtPOCode.Text);
                }

            }
            btnSave.Enabled  = false;
            Label2.Visible = true;



        }
        catch (Exception)
        {

            throw;
        }
    }

    private DataTable MapThisGridIntoDataTable()
    {
        try
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(Constants.DT_POITEM_ID_COLUMN);
            dt.Columns.Add(Constants.DT_PRODUCT_CODE_COLUMN);
            dt.Columns.Add(Constants.DT_CUSTOMER_PART_NO_COLUMN);
            dt.Columns.Add(Constants.DT_FFTL_PART_NO_COLUMN);
            dt.Columns.Add(Constants.DT_POITEM_NAME_COLUMN);
            dt.Columns.Add(Constants.DT_UNIT_COLUMN);
            dt.Columns.Add(Constants.DT_PRICE_COLUMN);
            dt.Columns.Add(Constants.DT_NUMER_OF_QUANTITY_COLUMN);



            for (int index = 0; index < grdViewPOItems.Rows.Count; index++)
            {
                GridViewRow row = grdViewPOItems.Rows[index];
                DataRow dr = dt.NewRow();


                //dr[Constants.DT_POITEM_ID_COLUMN] = ((DropDownList)row.FindControl("comboProductName")).SelectedValue;
                dr[Constants.DT_PRODUCT_CODE_COLUMN] = ((TextBox)row.FindControl("txtProductCode")).Text;
                dr[Constants.DT_CUSTOMER_PART_NO_COLUMN] = ((TextBox)row.FindControl("txtCustomerPartNo")).Text;
                dr[Constants.DT_FFTL_PART_NO_COLUMN] = ((TextBox)row.FindControl("txtFFTLPartNo")).Text;
                dr[Constants.DT_POITEM_NAME_COLUMN] = ((DropDownList)row.FindControl("comboProductName")).SelectedValue;
                dr[Constants.DT_UNIT_COLUMN] = ((DropDownList)row.FindControl("comboUnit")).SelectedValue;
                dr[Constants.DT_PRICE_COLUMN] = ((TextBox)row.FindControl("txtPriceRate")).Text;

                dt.Rows.Add(dr);

            }

            return dt;


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
    protected void Calender1_Load(object sender, EventArgs e)
    {

    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        try
        {
            if (Calendar1.SelectedDate != null)
            {
                txtPODate.Text = Calendar1.SelectedDate.Date.ToString().Substring(0, 9);
                Calendar1.Visible = false;
            }
        }
        catch (Exception)
        {
            
            throw;
        }
    }
    protected void btnOpenCalender_Click(object sender, EventArgs e)
    {
        try
        {
            Calendar1.Visible = true;

        }
        catch (Exception)
        {
            
            throw;
        }
    }
}
