using System;
using System.Collections.Generic;
using System.Text;
using FiltrumTaxInvoice.BusinessObjects.BO;
using FiltrumTaxInvoice.BusinessObjects.Common;
using FiltrumTaxInvoice.DAL;
using System.Data;



namespace FiltrumTaxInvoice.BAL
{
    public class InvoiceBAL
    {
        #region Public Methods
        public InvoiceBAL()
        {

        }

        /// <summary>
        /// Adding Invoice in tblInvoice table
        /// </summary>
        /// <param name="Invoice"></param>
        /// <returns></returns>
        public int AddInvoice(Invoice Invoice)
        {
            InvoiceDAL invoiceDAL = new InvoiceDAL();

            try
            {

                return invoiceDAL.AddInvoice(Invoice);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {

            }
        }

        /// <summary>
        /// INVOICE POITEMS
        /// </summary>
        /// <param name="Invoice"></param>
        /// <returns></returns>
        public int AddInvoicePOItems(POItem poItem, int invoiceID)
        {
            InvoiceDAL invoiceDAL = new InvoiceDAL();

            try
            {

                return invoiceDAL.AddInvoicePOItems(poItem, invoiceID);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {

            }
        }


        /// <summary>
        /// INVOICE History
        /// </summary>
        /// <param name="Invoice"></param>
        /// <returns></returns>
        public int AddInvoiceHistory(Invoice Invoice)
        {
            InvoiceDAL invoiceDAL = new InvoiceDAL();

            try
            {

                return invoiceDAL.AddInvoiceHistory(Invoice);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {

            }
        }

        /// <summary>
        /// Modifying the selcted Invoice
        /// </summary>
        /// <param name="Invoice"></param>
        /// <param name="InvoiceCode"></param>
        /// <returns></returns>
        public int ModifyInvoice(Invoice Invoice, int InvoiceCode)
        {
            InvoiceDAL custDAL = new InvoiceDAL();

            try
            {

                return custDAL.ModifyInvoice(Invoice, InvoiceCode);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {

            }
        }


        /// <summary>
        /// Get Invoices depending on Invoice Code and View it
        /// </summary>
        /// <param name="InvoiceCode"></param>
        /// <returns></returns>
        public DataTable ViewInvoices()
        {
            InvoiceDAL custDAL = new InvoiceDAL();

            try
            {

                return custDAL.ViewInvoices();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {

            }
        }


        public Invoice GetInvoiceForEdit(int InvoiceCode)
        {
            InvoiceDAL custDAL = new InvoiceDAL();

            try
            {

                return custDAL.GetInvoiceForEdit(InvoiceCode);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {

            }
        }

        #endregion



        public int AddInvoicePOItems(Invoice currentInvoice)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public DataTable GetInvoicesOfCustomer(int CustomerCode)
        {
            InvoiceDAL custDAL = new InvoiceDAL();

            try
            {

                return custDAL.GetInvoicesOfCustomer(CustomerCode);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {

            }
        }
    }
}
