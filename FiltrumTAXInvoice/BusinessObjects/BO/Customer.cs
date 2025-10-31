using System;
using System.Collections.Generic;
using System.Text;

namespace FiltrumTaxInvoice.BusinessObjects.BO
{
    public class Customer
    {
        private int customerCode;
        private string customerFirstName;
        private string billingAddress;
        private string shippingAddress;
        private Boolean isDomestic;
        private string eccNo;
        private decimal exciseDuty;
        private decimal cessDuty;
        private decimal e_cessDuty;
        private decimal shCessDuty;
        private decimal vatDuty;
        private List<PurchaseOrder> purchaseOrders;
        private string description;
        private string customerLastName;
        private string country;
        private string  state;
        private string city;
        private int pinCode;
        private string phoneNumber;
        private string faxNumber;
        private string email;


        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public string FaxNumber
        {
            get { return faxNumber; }
            set { faxNumber = value; }
        }


        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
	



        public int PinCode
        {
            get { return pinCode; }
            set { pinCode = value; }
        }
	

        public string City
        {
            get { return city; }
            set { city = value; }
        }
	

        public string  State
        {
            get { return state; }
            set { state = value; }
        }
	

        public string Country
        {
            get { return country; }
            set { country = value; }
        }
	

        public string CustomerLastName
        {
            get { return customerLastName; }
            set { customerLastName = value; }
        }
	


        public List<PurchaseOrder> PurchaseOrders
        {
            get { return purchaseOrders; }
            set { purchaseOrders = value; }
        }


        public int CusomerCode
        {
            get { return customerCode; }
            set { customerCode = value; }
        }

        public string CustomerFirstName
        {
            get { return customerFirstName; }
            set { customerFirstName = value; }
        }

        public string BillingAddress
        {
            get { return billingAddress; }
            set { billingAddress = value; }
        }



        public string ShippingAddress
        {
            get { return shippingAddress; }
            set { shippingAddress = value; }
        }



        public string ECCNo
        {
            get { return eccNo; }
            set { eccNo = value; }
        }



        public Boolean IsDomestic
        {
            get { return isDomestic; }
            set { isDomestic = value; }
        }



        public decimal ExciseDuty
        {
            get { return exciseDuty; }
            set { exciseDuty = value; }
        }


        public decimal CessDuty
        {
            get { return cessDuty; }
            set { cessDuty = value; }
        }


        public decimal EcessDuty
        {
            get { return e_cessDuty; }
            set { e_cessDuty = value; }
        }


        public decimal SHCessDuty
        {
            get { return shCessDuty; }
            set { shCessDuty = value; }
        }


        public decimal VATDuty
        {
            get { return vatDuty; }
            set { vatDuty = value; }
        }

       
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public PurchaseOrder hasPOs
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Invoice hasInvoices
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

       
	
    }
    
}
