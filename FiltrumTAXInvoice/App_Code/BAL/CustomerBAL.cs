using System;
using System.Collections.Generic;
using System.Text;
using FiltrumTaxInvoice.BusinessObjects.BO;
using FiltrumTaxInvoice.BusinessObjects.Common;
using FiltrumTaxInvoice.DAL;
using System.Data;



namespace FiltrumTaxInvoice.BAL
{
    public class CustomerBAL
    {
        #region Public Methods
        public CustomerBAL()
        {

        }

        /// <summary>
        /// Adding Customer in tblCustomer table
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public int AddCustomer(Customer customer)
        {
            CustomerDAL custDAL = new CustomerDAL();

            try
            {

                return custDAL.AddCustomer(customer);
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
        /// Modifying the selcted Customer
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="customerCode"></param>
        /// <returns></returns>
        public int ModifyCustomer(Customer customer, int customerCode)
        {
            CustomerDAL custDAL = new CustomerDAL();

            try
            {

                return custDAL.ModifyCustomer(customer, customerCode);
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
        /// Get Customers depending on Customer Code and View it
        /// </summary>
        /// <param name="customerCode"></param>
        /// <returns></returns>
        public DataTable ViewCustomers()
        {
            CustomerDAL custDAL = new CustomerDAL();

            try
            {

                return custDAL.ViewCustomers();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {

            }
        }


        public Customer GetCustomerForEdit(int customerCode)
        {
            CustomerDAL custDAL = new CustomerDAL();

            try
            {

                return custDAL.GetCustomerForEdit(customerCode);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {

            }
        }

        public int GetLastInvoiceCount(string custType)
        {
            CustomerDAL custDAL = new CustomerDAL();

            try
            {

                return custDAL.GetLastInvoiceCount(custType);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {

            }
        }

        public DataTable GetCustomerDetailsReport()
        {
            CustomerDAL custDAL = new CustomerDAL();

            try
            {

                return custDAL.GetCustomerDetailsReport();
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
