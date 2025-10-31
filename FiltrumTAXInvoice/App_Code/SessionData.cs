using System;
using System.Collections.Generic;
using System.Text;
using FiltrumTaxInvoice.BusinessObjects.BO;
using FiltrumTaxInvoice;


namespace FiltrumTAXInvoice
{
    public class SessionData
    {


        public static List<Invoice> invoices = new List<Invoice>();
        public static List<POItem> poItems = new List<POItem>();
        public static List<Duties> duties = new List<Duties>();

        public static List<POItem> poItems1 = new List<POItem>();
        public static List<POItem> poItems2 = new List<POItem>();
        public static List<POItem> poItems3 = new List<POItem>();
        public static List<POItem> poItems4 = new List<POItem>();


        public static List<POItem> poItems5 = new List<POItem>();
        public static List<POItem> poItems6 = new List<POItem>();
        public static List<POItem> poItems7 = new List<POItem>();
        public static List<POItem> poItems8 = new List<POItem>();


        public List<Invoice> Invoices
        {
            get { return invoices; }
            set { invoices = value; }
        }


        public List<Duties> Duties
        {
            get { return duties; }
            set { duties = value; }
        }




        public List<POItem> POItems
        {
            get { return poItems; }
            set { poItems = value; }
        }

        public List<POItem> POItems1
        {
            get { return poItems1; }
            set { poItems1 = value; }
        }

        public List<POItem> POItems2
        {
            get { return poItems2; }
            set { poItems2 = value; }
        }

        public List<POItem> POItems3
        {
            get { return poItems3; }
            set { poItems3 = value; }
        }


        public List<POItem> POItems4
        {
            get { return poItems4; }
            set { poItems4 = value; }
        }

        public List<POItem> POItems5
        {
            get { return poItems5; }
            set { poItems5 = value; }
        }

        public List<POItem> POItems6
        {
            get { return poItems6; }
            set { poItems6 = value; }
        }

        public List<POItem> POItems7
        {
            get { return poItems7; }
            set { poItems7 = value; }
        }


        public List<POItem> POItems8
        {
            get { return poItems8; }
            set { poItems8 = value; }
        }


        public List<Invoice> GetInvoices()
        {

            return invoices;
        }

        public List<POItem> GetPOItems()
        {

            return poItems;

        }

        public List<POItem> GetPOItems1()
        {

            return poItems1;

        }
        public List<POItem> GetPOItems2()
        {

            return poItems2;

        }


        public List<POItem> GetPOItems3()
        {

            return poItems3;

        }



        public List<POItem> GetPOItems4()
        {

            return poItems4;

        }

        public List<POItem> GetPOItems5()
        {

            return poItems5;

        }
        public List<POItem> GetPOItems6()
        {

            return poItems6;

        }


        public List<POItem> GetPOItems7()
        {

            return poItems7;

        }



        public List<POItem> GetPOItems8()
        {

            return poItems8;

        }

        public List<Duties> GetDuties()
        {

            return duties;

        }




    }


}

