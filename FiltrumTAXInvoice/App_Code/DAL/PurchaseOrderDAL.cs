using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using FiltrumTaxInvoice.BusinessObjects.BO;
using FiltrumTaxInvoice.BusinessObjects.Common;
using System.Data;
using System.Collections;
using Microsoft.ApplicationBlocks.Data;

namespace FiltrumTaxInvoice.DAL
{
    public class PurchaseOrderDAL
    {
        /// <summary>
        /// GlobalVariables
        /// </summary>
        SqlConnection conn = null;

        #region Private Methods
        private SqlParameter AddNewParameter(System.Data.ParameterDirection type, string paramName, object paramValue)
        {
            SqlParameter newParam = new SqlParameter();
            newParam.Direction = type;
            newParam.ParameterName = paramName;
            newParam.Value = paramValue;
            return newParam;
        }
        #endregion

        #region Public Methods

        /// <summary>
        /// Constructor
        /// </summary>
        public PurchaseOrderDAL()
        {

            /// <summary>
            /// Open the Sql Connection
            /// </summary>
            string connectionString = ConfigurationSettings.AppSettings["connectionString1"].ToString();
            conn = new SqlConnection(connectionString);
            conn.Open();
        }


        /// <summary>
        /// Add the PurchaseOrder into database
        /// </summary>
        /// <param name="PurchaseOrder"></param>
        /// <returns></returns>
        public int AddPurchaseOrder(PurchaseOrder PurchaseOrder, int customerCode)
        {
            SqlCommand cmd = new SqlCommand("", conn);
            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "AddPurchaseOrder";
                cmd.Connection = conn;

                SqlParameter param = new SqlParameter();

                	
                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@PurchaseOrderCode", PurchaseOrder.PurchaseOrderCode );
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@CustomerCode", customerCode);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@Date", PurchaseOrder.PODate);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@Description", string.Empty );
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Output , "@PurchaseOrderID", 0);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Output, "@CustTOPoID", 0);
                cmd.Parameters.Add(param);

                
            

                int resultValue = cmd.ExecuteNonQuery();
                //  int retValue = Convert.ToInt32("@ResultValue");

                return resultValue;



            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                cmd.Dispose();
                conn.Dispose();
            }
        }


        /// <summary>
        /// Modify the PurchaseOrder
        /// </summary>
        /// <param name="PurchaseOrder"></param>
        /// <returns></returns>
        public int ModifyPurchaseOrder(PurchaseOrder PurchaseOrder, int PurchaseOrderID)
        {
            SqlCommand cmd = new SqlCommand("", conn);
            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "ModifyPurchaseOrder";
                cmd.Connection = conn;

                SqlParameter param = new SqlParameter();

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@PurchaseOrderCode", PurchaseOrder.PurchaseOrderCode);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@Date", PurchaseOrder.PODate);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@Description", PurchaseOrder.Description);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@PurchaseOrderID", PurchaseOrder.PONum );
                cmd.Parameters.Add(param);


                int resultValue = cmd.ExecuteNonQuery();

                return resultValue;



            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                cmd.Dispose();
                conn.Dispose();
            }
        }

        /// <summary>
        /// Get the PurchaseOrders from tblPurchaseOrder table depending on PurchaseOrderCode
        /// </summary>
        /// <param name="PurchaseOrderCode"></param>
        /// <returns></returns>
        public DataTable ViewPurchaseOrders()
        {

            try
            {
                SqlDataAdapter sqlAdapter = new SqlDataAdapter("GetPurchaseOrders", conn);
                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds, "PurchaseOrders");

                DataTable dt = ds.Tables[0];

                return dt;


            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// return PurchaseOrder which is going to be modify
        /// </summary>
        /// <param name="PurchaseOrderCode"></param>
        /// <returns></returns>
        public PurchaseOrder GetPurchaseOrderForEdit(int PurchaseOrderID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "GetPurchaseOrderForEdit";
                cmd.Connection = conn;

                SqlParameter param = new SqlParameter();
                PurchaseOrder newPurchaseOrder = new PurchaseOrder();

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@PurchaseOrderID", PurchaseOrderID);
                cmd.Parameters.Add(param);

                
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    newPurchaseOrder.CustomerCode = Convert.ToInt32(rdr["CustomerCode"]);
                    newPurchaseOrder.PONum  = Convert.ToInt32(rdr["PurchaseOrderID"]);
                    newPurchaseOrder.PurchaseOrderCode  = rdr["PurchaseOrderCode"].ToString();
                    newPurchaseOrder.PODate  = Convert.ToDateTime(rdr["Date"]);
                    newPurchaseOrder.Description  = rdr["Description"].ToString();                
                    
                }

                return newPurchaseOrder;


            }
            catch (Exception)
            {

                throw;
            }

        }

        public DataTable GetPurchaseOrdersOfthisCustomer(int CustomerCode)
        {
            try
            {


                // DataSet that will hold the returned results
                DataSet ds;

                // Call ExecuteDataset static method of SqlHelper class that returns a Dataset
                // We pass in database connection string, command type, stored procedure name and categoryID SqlParameter
                // that has a value of "1"
                ds = SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, "GetPurchaseOrdersOfthisCustomer", new SqlParameter("@CustomerCode", CustomerCode));

                // Get XML representation of the dataset and display results in text box
                return ds.Tables[0];
            }
            catch (Exception)
            {

                throw;
            }

        }

        #endregion




    }

}
