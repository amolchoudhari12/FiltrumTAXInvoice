using System;
using System.Collections.Generic;
using System.Text;

namespace FiltrumTaxInvoice.BusinessObjects.BO
{
    public class POItem : Product
    {
        private int poItemID;
        private string customerPartNumber;
        private string fftlPartNumber;
        private double priceRate;
        private string unitOfMesurement;
        private double numberOfQuantity;
        private string descriptionOfPackages;
        private double itemTotalAmt;

      
        public double ItemTotalAmount
        {
            get { return itemTotalAmt; }
            set { itemTotalAmt = value; }
        }
	
        public string DescriptionOfPackages
        {
            get { return descriptionOfPackages; }
            set { descriptionOfPackages = value; }
        }
	

        public double NumberOfQuantity
        {
            get { return numberOfQuantity; }
            set { numberOfQuantity = value; }
        }
	
        //private string productName;
        //private int productCode;
        //private string description;

        

        //public int ProductCode
        //{
        //    get { return productCode; }
        //    set { productCode = value; }
        //}


        public int POItemID
        {
            get { return poItemID; }
            set { poItemID = value; }
        }

        public string CustomerPartNumber
        {
            get { return customerPartNumber; }
            set { customerPartNumber = value; }
        }



        public string FFTLPartNumber
        {
            get { return fftlPartNumber; }
            set { fftlPartNumber = value; }
        }



        public double PriceRate
        {
            get { return priceRate; }
            set { priceRate = value; }
        }

        public string UnitOfMesurement
        {
            get { return unitOfMesurement; }
            set { unitOfMesurement = value; }
        }



        //public string ProductName
        //{
        //    get { return productName; }
        //    set { productName = value; }
        //}

        //public string Description
        //{
        //    get { return description; }
        //    set { description = value; }
        //}
	


    }
}
