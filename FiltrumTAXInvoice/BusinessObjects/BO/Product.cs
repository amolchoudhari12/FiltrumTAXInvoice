using System;
using System.Collections.Generic;
using System.Text;

namespace FiltrumTaxInvoice.BusinessObjects.BO
{
    public class Product
    {

        private int productCode;
        private string productName;
        private string chaperHeading1;
        private string chaperHeading2;
        private string description;      

        

        public int ProductCode
        {
            get { return productCode; }
            set { productCode = value; }
        }


        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }


        public string ChapterHeading1
        {
            get { return chaperHeading1; }
            set { chaperHeading1 = value; }
        }

        public string ChaperHeading2
        {
            get { return chaperHeading2; }
            set { chaperHeading2 = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
	

	

    }
}
