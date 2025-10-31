using System;
using System.Collections.Generic;
using System.Text;

namespace FiltrumTaxInvoice.BusinessObjects.BO
{
    public class PurchaseOrder
    {
        private string purchaseOrderCode;
        private int poNum;
        private DateTime poDate;
        private List<POItem> poItems;
        private string poDescription;

        private int customerCode;

        public int CustomerCode
        {
            get { return customerCode; }
            set { customerCode = value; }
        }
	

        public string PurchaseOrderCode
        {
            get { return purchaseOrderCode; }
            set { purchaseOrderCode = value; }
        }

        public int PONum
        {

            get { return poNum; }
            set { poNum = value; }
        }

        public DateTime PODate
        {

            get { return poDate; }
            set { poDate = value; }
        }

        public List<POItem> POItems
        {
            get { return poItems; }
            set { poItems = value; }
        }

        public string Description
        {
            get { return poDescription; }
            set { poDescription = value; }
        }

        public POItem hasPOItems
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
