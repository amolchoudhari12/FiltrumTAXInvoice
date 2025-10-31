using System;
using System.Collections.Generic;
using System.Text;
using FiltrumTaxInvoice.BusinessObjects.BO;
using FiltrumTaxInvoice.BusinessObjects.Common;
using FiltrumTaxInvoice.DAL;
using System.Data;



namespace FiltrumTaxInvoice.BAL
{
    public class ProductBAL
    {
        #region Public Methods
        public ProductBAL()
        {

        }

        /// <summary>
        /// Adding Product in tblProduct table
        /// </summary>
        /// <param name="Product"></param>
        /// <returns></returns>
        public int AddProduct(Product Product)
        {
            ProductDAL prodDAL = new ProductDAL();

            try
            {

                return prodDAL.AddProduct(Product);
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
        /// Modifying the selcted Product
        /// </summary>
        /// <param name="Product"></param>
        /// <param name="ProductCode"></param>
        /// <returns></returns>
        public int ModifyProduct(Product Product)
        {
            ProductDAL prodDAL = new ProductDAL();

            try
            {

                return prodDAL.ModifyProduct(Product);
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
        /// Get Products depending on Product Code and View it
        /// </summary>
        /// <param name="ProductCode"></param>
        /// <returns></returns>
        public DataTable ViewProducts()
        {
            ProductDAL prodDAL = new ProductDAL();

            try
            {

                return prodDAL.ViewProducts();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {

            }
        }


        public Product GetProductForEdit(int ProductCode)
        {
            ProductDAL prodDAL = new ProductDAL();

            try
            {

                return prodDAL.GetProductForEdit(ProductCode);
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
        /// Get Products depending on Product Code and View it
        /// </summary>
        /// <param name="ProductCode"></param>
        /// <returns></returns>
        public DataTable GetProductDetails()
        {
            ProductDAL prodDAL = new ProductDAL();

            try
            {

                return prodDAL.GetProductDetails ();
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
