using System;
using System.Collections.Generic;
using System.Text;

namespace FiltrumTaxInvoice.BusinessObjects.BO
{
    public  class Duties
    {

        private decimal cessDuty;

        public decimal CessRate
        {
            get { return cessDuty; }
            set { cessDuty = value; }
        }

        private decimal eCessRate;

        public decimal ECessRate
        {
            get { return eCessRate; }
            set { eCessRate = value; }
        }

        private decimal exciseRate;

        public decimal ExciseRate
        {
            get { return exciseRate; }
            set { exciseRate = value; }
        }

        private decimal shCessRate;

        public decimal SHCessRate
        {
            get { return shCessRate; }
            set { shCessRate = value; }
        }

        private decimal vatRate;

        public decimal VATRate
        {
            get { return vatRate; }
            set { vatRate = value; }
        }
	
	
	
	
	
    }
}
