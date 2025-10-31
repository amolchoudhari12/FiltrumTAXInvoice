using System;
using System.Collections.Generic;
using System.Text;
using FiltrumTaxInvoice.BusinessObjects.BO;
using FiltrumTaxInvoice.BusinessObjects.Common;
using FiltrumTaxInvoice.DAL;
using System.Data;



namespace FiltrumTaxInvoice.BAL
{
    public class PurchaseOrderBAL
    {
        #region Public Methods
        public PurchaseOrderBAL()
        {

        }

        /// <summary>
        /// Adding PurchaseOrder in tblPurchaseOrder table
        /// </summary>
        /// <param name="PurchaseOrder"></param>
        /// <returns></returns>
        public int AddPurchaseOrder(PurchaseOrder PurchaseOrder, int customerCode)
        {
            PurchaseOrderDAL poDAL = new PurchaseOrderDAL();

            try
            {

                return poDAL.AddPurchaseOrder(PurchaseOrder, customerCode);
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
        /// Modifying the selcted PurchaseOrder
        /// </summary>
        /// <param name="PurchaseOrder"></param>
        /// <param name="PurchaseOrderCode"></param>
        /// <returns></returns>
        public int ModifyPurchaseOrder(PurchaseOrder PurchaseOrder, int PurchaseOrderID)
        {
            PurchaseOrderDAL poDAL = new PurchaseOrderDAL();

            try
            {

                return poDAL.ModifyPurchaseOrder(PurchaseOrder, PurchaseOrderID);
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
        /// Get PurchaseOrders depending on PurchaseOrder Code and View it
        /// </summary>
        /// <param name="PurchaseOrderCode"></param>
        /// <returns></returns>
        public DataTable ViewPurchaseOrders()
        {
            PurchaseOrderDAL poDAL = new PurchaseOrderDAL();

            try
            {

                return poDAL.ViewPurchaseOrders();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {

            }
        }


        public PurchaseOrder GetPurchaseOrderForEdit(int PurchaseOrderID)
        {
            PurchaseOrderDAL poDAL = new PurchaseOrderDAL();

            try
            {

                return poDAL.GetPurchaseOrderForEdit(PurchaseOrderID);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {

            }
        }

         public DataTable GetPurchaseOrdersOfthisCustomer(int CustomerCode)
         {
             PurchaseOrderDAL poDAL = new PurchaseOrderDAL();

             try
             {

                 return poDAL.GetPurchaseOrdersOfthisCustomer(CustomerCode);
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


    }
}
