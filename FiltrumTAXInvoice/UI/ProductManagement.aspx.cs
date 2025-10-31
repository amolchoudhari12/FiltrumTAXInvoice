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

public partial class UI_ProductManagement : System.Web.UI.Page
{




    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {

            if (!IsPostBack)
            {
                Product Product = (Product)Session[Constants.PRODUCT_FOR_EDIT ];

                string[] str = Request.QueryString.GetValues("operation");

                if (str != null && str[0].ToString() == "edit")
                {
                    lblProductOperation.Text = Constants.PRODUCT_MODIFY_LABEL ;
                    BindProductDetailsForEdit(Product);

                }
                else
                {
                    lblProductOperation.Text = Constants.PRODUCT_ADD_LABEL ;
                    ResetProductInputControls();
                }
            }

        }
        catch (Exception)
        {
            
            throw;
        }
    }

    private void ResetProductInputControls()
    {
        try
        {
             txtProductCode.Text = string.Empty ;
            txtProductName.Text= string.Empty ; 
            txtChapterHead1 .Text= string.Empty ;
            txtChapterHead2 .Text= string.Empty ;
            txtDescription .Text= string.Empty ;

            btnAdd.Text = "Add";
            
        }
        catch (Exception)
        {
            
            throw;
        }
    }

    private void BindProductDetailsForEdit(Product product)
    {
        try
        {
            txtProductCode.Text = product.ProductCode.ToString();
            txtProductName.Text = product.ProductName;
            txtChapterHead1.Text = product.ChapterHeading1;
            txtChapterHead2.Text = product.ChaperHeading2;
            txtDescription.Text = product.Description;

            btnAdd.Text = "Modify";

        }
        catch (Exception)
        {
            
            throw;
        }
    }





    protected void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {


            string operationType = btnAdd .Text.ToString();

            switch (operationType)
            {

                case "Add":
                    AddThisProduct();
                    break;

                case "Modify":

                    ModifyThisProduct();
                    break;


            }


        }
        catch (Exception)
        {
            
            throw;
        }
    }

    private void ModifyThisProduct()
    {
        try
        {

            Product newProduct = new Product();
            ProductBAL balProduct = new ProductBAL();

            newProduct.ProductCode  = Convert.ToInt32(txtProductCode.Text);
            newProduct.ProductName  = txtProductName.Text;
            newProduct.ChapterHeading1  = txtChapterHead1 .Text;
            newProduct.ChaperHeading2  = txtChapterHead2 .Text;
            newProduct.Description  = txtDescription .Text;
            

            int returnValue = balProduct.ModifyProduct (newProduct);

            if (returnValue > 0)
            {
                Label1.Text = "Product Modified Successfully !!!";
                Label1.Visible = true;
              
            }
        }
        catch (Exception)
        {
            
            throw;
        }
    }

    private void AddThisProduct()
    {
        try
        {

            Product newProduct = new Product();
            ProductBAL balProduct = new ProductBAL();

            newProduct.ProductCode   = Convert.ToInt32(txtProductCode.Text);
            newProduct.ProductName  = txtProductName.Text;
            newProduct.ChapterHeading1  = txtChapterHead1 .Text;
            newProduct.ChaperHeading2  = txtChapterHead2 .Text;
            newProduct.Description  = txtDescription .Text;
            

            int returnValue = balProduct.AddProduct(newProduct);

            if (returnValue > 0)
            {

                Label1.Visible = true;
            }
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
