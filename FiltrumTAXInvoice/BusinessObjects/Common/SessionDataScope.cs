using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using FiltrumTaxInvoice.BusinessObjects.BO;
using FiltrumTaxInvoice.BusinessObjects.Common;
using System.Data;
using System.Collections;

namespace BusinessObjects.Common
{
    public class SessionDataScope
    {
        public static List<Customer> customers = new List<Customer>();



        public static List<POItem> poItems = new List<POItem>();



      

        public static Invoice currentInvoice   = new Invoice();

        public Invoice CurrentInvoice
        {
            get { return currentInvoice; }
            set { currentInvoice = value; }
        }
	

        public List<POItem> POItems
        {
            get
            {
                return poItems;
            }

            set
            {
                poItems = value;
            }
        }

        public void Main()
        {
        }
    }
}
