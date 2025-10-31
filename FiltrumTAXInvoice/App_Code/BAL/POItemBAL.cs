using System;
using System.Collections.Generic;
using System.Text;
using FiltrumTaxInvoice.BusinessObjects.BO;
using FiltrumTaxInvoice.BusinessObjects.Common;
using FiltrumTaxInvoice.DAL;
using System.Data;



namespace FiltrumTaxInvoice.BAL
{
    public class POItemBAL
    {
        #region Public Methods
        public POItemBAL()
        {

        }

        /// <summary>
        /// Adding POItem in tblPOItem table
        /// </summary>
        /// <param name="POItem"></param>
        /// <returns></returns>
        public int AddPOItem(POItem POItem, string poCode)
        {
            POItemDAL poitemDAL = new POItemDAL();

            try
            {

                return poitemDAL.AddPOItem(POItem, poCode);
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
        /// Modifying the selcted POItem
        /// </summary>
        /// <param name="POItem"></param>
        /// <param name="POItemCode"></param>
        /// <returns></returns>
        public int ModifyPOItem(POItem POItem, int poCode)
        {
            POItemDAL poitemDAL = new POItemDAL();

            try
            {

                return poitemDAL.ModifyPOItem(POItem, poCode);
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
        /// Get POItems depending on POItem Code and View it
        /// </summary>
        /// <param name="POItemCode"></param>
        /// <returns></returns>
        public DataTable ViewPOItems()
        {
            POItemDAL poitemDAL = new POItemDAL();

            try
            {

                return poitemDAL.ViewPOItems();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {

            }
        }


        public POItem GetPOItemForEdit(int POItemCode)
        {
            POItemDAL poitemDAL = new POItemDAL();

            try
            {

                return poitemDAL.GetPOItemForEdit(POItemCode);
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
        /// Get POItems depending on POItem Code and View it
        /// </summary>
        /// <param name="POItemCode"></param>
        /// <returns></returns>
        public DataTable ViewPOItemsOfPO(int PurchaseOrderID)
        {
            POItemDAL poitemDAL = new POItemDAL();

            try
            {

                return poitemDAL.ViewPOItemsOfPO (PurchaseOrderID);
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
        /// Get POItems depending on POItem Code and View it
        /// </summary>
        /// <param name="POItemCode"></param>
        /// <returns></returns>
        public DataTable GetPOItemsForPOCustomers(int PurchaseOrderID)
        {
            POItemDAL poitemDAL = new POItemDAL();

            try
            {

                return poitemDAL.GetPOItemsForPOCustomers (PurchaseOrderID);
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



        public void DeletePOItem(int poItemID)
        {
            POItemDAL poitemDAL = new POItemDAL();

            try
            {

                 poitemDAL.DeletePOItem(poItemID);
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
