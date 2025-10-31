using System;
using System.Collections.Generic;
using System.Text;

namespace FiltrumTaxInvoice.BusinessObjects.BO
{
    public class Invoice
    {


        public Invoice()
        {
        }

        public Invoice(List<POItem> poItems)
        {
            this.POItems = poItems;
        }
        private int invoiceCode;
        private int customerCode;
        private string poCode;
        private string eccCustomerNum;
        private string shippingAddress;
        private string customerName;
        private string billingAddress;
        private List<POItem> poItems;
        private string vehicleNumber;
        private double netValue;
        private double exsiceDuty;
        private double cessDuty;
        private double e_cessDuty;
        private double shCessDuty;
        private double vatDuty;
        private string str_exsiceDuty;
        private string str_cessDuty;
        private string str_e_cessDuty;
        private string str_shCessDuty;
        private string str_vatDuty; 
        private string grsAmntWords;
        private string exciseAmtWords;
        private string invoiceDate;
        private string invoiceTime;
        private string removalTime;
        private string removalDate;
        private string poDate;
        private string modeOfTransport;
        private string productName;
        private string chapterHeading1;
        private string chapterHeading2;
        private string rateOfDuty;
        private double grossAmount;
        private string userName;
        private string machineName;
        private double netTotal;

        public double NetTotal
        {
            get { return netTotal; }
            set { netTotal = value; }
        }
	

      

	

	

        private string serialNum;

        public string SerialNumber
        {
            get { return serialNum; }
            set { serialNum = value; }
        }
	

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
               

        public string MashineName
        {
            get { return machineName; }
            set { machineName = value; }
        }
	
	


        public int InvoiceCode
        {
            get { return invoiceCode; }
            set { invoiceCode = value; }
        }



        public int CustomerCode
        {
            get { return customerCode; }
            set { customerCode = value; }
        }


        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
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



        public double GrossAmount
        {
            get { return grossAmount; }
            set { grossAmount = value; }
        }
	

        public string RateOfDuty
        {
            get { return rateOfDuty; }
            set { rateOfDuty = value; }
        }
	

        public string ChapterHeading1
        {
            get { return chapterHeading1; }
            set { chapterHeading1 = value; }
        }

        

        public string ChapterHeading2
        {
            get { return chapterHeading2; }
            set { chapterHeading2 = value; }
        }
	
	

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
	

        public string TranseportMode
        {
            get { return modeOfTransport; }
            set { modeOfTransport = value; }
        }
	

        public string POCode
        {
            get { return poCode; }
            set { poCode = value; }
        }



        public string PODate
        {
            get { return poDate; }
            set { poDate = value; }
        }



        public string RemovalDate
        {
            get { return removalDate; }
            set { removalDate = value; }
        }



        public string InvoiceTime
        {
            get { return invoiceTime; }
            set { invoiceTime = value; }
        }
	

        


        public string ECCNum
        {
            get { return eccCustomerNum; }
            set { eccCustomerNum = value; }
        }

       

        public string VehicleNumber
        {
            get { return vehicleNumber; }
            set { vehicleNumber = value; }
        }

       
        public List<POItem> POItems
        {
            get { return poItems; }
            set { poItems = value; }
        }

       

        public double NetValue
        {
            get { return netValue; }
            set { netValue = value; }
        }

        public double ExsiceDuty
        {
            get { return exsiceDuty; }
            set { exsiceDuty = value; }
        }
        

        public string STR_ExsiceDuty
        {
            get { return str_exsiceDuty; }
            set { str_exsiceDuty = value; }
        }

        public string STR_CessDuty
        {
            get { return str_cessDuty; }
            set { str_cessDuty = value; }
        }

        public string STR_e_cessDuty
        {
            get { return str_e_cessDuty; }
            set { str_e_cessDuty = value; }
        }



        public string STR_shCessDuty
        {
            get { return str_shCessDuty; }
            set { str_shCessDuty = value; }
        }



        public string STR_vatDuty
        {
            get { return str_vatDuty; }
            set { str_vatDuty = value; }
        }

       public double CessDuty
        {
            get { return cessDuty; }
            set { cessDuty = value; }
        }

        public double EcessDuty
        {
            get { return e_cessDuty; }
            set { e_cessDuty = value; }
        }

       

        public double SHCessDuty
        {
            get { return shCessDuty; }
            set { shCessDuty = value; }
        }

       

        public double VATDuty
        {
            get { return vatDuty; }
            set { vatDuty = value; }
        }

       

        public string ExciseAmountInWords
        {
            get { return exciseAmtWords; }
            set { exciseAmtWords = value; }
        }

        


        public string GrossAmountInWords
        {
            get { return grsAmntWords; }
            set { grsAmntWords = value; }
        }



        public string RemovalTime
        {
            get { return removalTime; }
            set { removalTime = value; }
        }

        public string InvoiceDate
        {
            get { return invoiceDate; }
            set { invoiceDate = value; }
        }
	
    }
}
