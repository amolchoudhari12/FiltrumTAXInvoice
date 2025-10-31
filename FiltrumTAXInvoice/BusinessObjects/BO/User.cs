using System;
using System.Collections.Generic;
using System.Text;

namespace FiltrumTaxInvoice.BusinessObjects.BO
{
    public class User
    {
        private int userID;
        private string userName;
        private string password;
        private string userType;
        private bool allowRptCustomers;
        private bool allowInvoiceMgt;
        private Boolean allowPOMgt;
        private bool allowProductMgt;
        private Boolean allowCustomerManagement;
        private bool allowRptProducts;
        private bool allowRptInvoices;
        private bool allowRptPOs;


        private bool invoiceView;

        public bool AllowInvoiceView
        {
            get { return invoiceView; }
            set { invoiceView = value; }
        }
	

        private bool invoiceAdd;

        public bool AllowInvoiceAdd
        {
            get { return invoiceAdd; }
            set { invoiceAdd = value; }
        }
	



        private bool poView;

        public bool AllowPOView
        {
            get { return poView; }
            set { poView = value; }
        }
	


        private bool poModify;

        public bool AllowPOModify
        {
            get { return poModify; }
            set { poModify = value; }
        }
	

        private bool  poAdd;

        public bool  AllowPOAdd
        {
            get { return poAdd; }
            set { poAdd = value; }
        }
	


       
        private bool productView    ;

        public bool AllowProductView
        {
            get { return productView; }
            set { productView = value; }
        }
	


        private bool productModify;

        public bool AllowPoductModify
        {
            get { return productModify; }
            set { productModify = value; }
        }
	

        private bool productAdd;

        public bool AllowPoductAdd
        {
            get { return productAdd; }
            set { productAdd = value; }
        }
	


        private bool customerView;

        public bool AllowCustomerView
        {
            get { return customerView; }
            set { customerView = value; }
        }
	
        private bool customerModify;

        public bool AllowCustomerModify
        {
            get { return customerModify; }
            set { customerModify = value; }
        }
	

        private bool customerAdd;

        public bool AllowCustomerAdd
        {
            get { return customerAdd; }
            set { customerAdd = value; }
        }
	

        private string department;

        public string Department
        {
            get { return department; }
            set { department = value; }
        }
	

        private bool allUserRoleMgt;

        public bool AllowUserRoleManagement
        {
            get { return allUserRoleMgt; }
            set { allUserRoleMgt = value; }
        }
	

        private string  description;

        public string  Description
        {
            get { return description; }
            set { description = value; }
        }
	


        public bool AllowRptInvoiceDetails
        {
            get { return allowRptInvoices; }
            set { allowRptInvoices = value; }
        }
	

       

        public bool AllowRptPOs
        {
            get { return allowRptPOs; }
            set { allowRptPOs = value; }
        }

       

        public bool AllowRptProductDetails
        {
            get { return allowRptProducts; }
            set { allowRptProducts = value; }
        }
	

               public bool AllowRptCustomerDetails
        {
            get { return allowRptCustomers; }
            set { allowRptCustomers = value; }
        }
	      

        public bool AllowInvoiceManagement
        {
            get { return allowInvoiceMgt; }
            set { allowInvoiceMgt = value; }
        }
	

        public Boolean AllowPOManagement
        {
            get { return allowPOMgt; }
            set { allowPOMgt = value; }
        }
	

      
        public bool AllowProductManagement
        {
            get { return allowProductMgt; }
            set { allowProductMgt = value; }
        }
	

       

        public Boolean AllowCustomerManagement
        {
            get { return allowCustomerManagement; }
            set { allowCustomerManagement = value; }
        }
	

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string UserType
        {
            get { return userType; }
            set { userType = value; }
        }
    }
}
