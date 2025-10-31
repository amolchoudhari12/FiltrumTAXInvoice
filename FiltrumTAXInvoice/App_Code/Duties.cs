using System;
using System.Collections.Generic;
using System.Text;

namespace FiltrumTaxInvoice
{
    public class Duties
    {

        private string cessDuty;

        public string CessRate
        {
            get { return cessDuty; }
            set { cessDuty = value; }
        }

        private string eCessRate;

        public string ECessRate
        {
            get { return eCessRate; }
            set { eCessRate = value; }
        }

        private string exciseRate;

        public string ExciseRate
        {
            get { return exciseRate; }
            set { exciseRate = value; }
        }

        private string shCessRate;

        public string SHCessRate
        {
            get { return shCessRate; }
            set { shCessRate = value; }
        }

        private string vatRate;

        public string VATRate
        {
            get { return vatRate; }
            set { vatRate = value; }
        }

        private double netTotal;

        public double NetTotal
        {
            get { return netTotal; }
            set { netTotal = value; }
        }
	





    }
}
