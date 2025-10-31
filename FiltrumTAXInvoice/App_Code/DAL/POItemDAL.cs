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
    public class POItemDAL
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
        public POItemDAL()
        {

            /// <summary>
            /// Open the Sql Connection
            /// </summary>
            string connectionString = ConfigurationSettings.AppSettings["connectionString1"].ToString();
            conn = new SqlConnection(connectionString);
            conn.Open();
        }


        /// <summary>
        /// Add the POItem into database
        /// </summary>
        /// <param name="POItem"></param>
        /// <returns></returns>
        public int AddPOItem(POItem poItem, string poCode)
        {
            SqlCommand cmd = new SqlCommand("", conn);
            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "AddPOItems";
                cmd.Connection = conn;

                SqlParameter param = new SqlParameter();

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@POItemName", poItem.ProductName);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@PurchaseOrderCode", poCode);
                cmd.Parameters.Add(param);


                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ProductCode", poItem.ProductCode);
                cmd.Parameters.Add(param);


                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@CustomerPartNo", poItem.CustomerPartNumber);
                cmd.Parameters.Add(param);


                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@FFTLPartPartNo", poItem.FFTLPartNumber);
                cmd.Parameters.Add(param);


                // param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@DescriptionOfPackages", null);
                //cmd.Parameters.Add(param);


                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@NumberOfQuntity", poItem.NumberOfQuantity);
                cmd.Parameters.Add(param);


                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@UnitOfMesurement", poItem.UnitOfMesurement);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@PriceRate", poItem.PriceRate);
                cmd.Parameters.Add(param);


                param = this.AddNewParameter(System.Data.ParameterDirection.Output, "@POItemID", 0);
                cmd.Parameters.Add(param);


                param = this.AddNewParameter(System.Data.ParameterDirection.Output, "@POtoPOItemID", 0);
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
        /// Modify the POItem
        /// </summary>
        /// <param name="POItem"></param>
        /// <returns></returns>
        public int ModifyPOItem(POItem poItem, int poCode)
        {
            SqlCommand cmd = new SqlCommand("", conn);
            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "ModifyPOItems";
                cmd.Connection = conn;

                SqlParameter param = new SqlParameter();

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@POItemName", poItem.ProductName);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@PurchaseOrderCode", poCode);
                cmd.Parameters.Add(param);


                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ProductCode", poItem.ProductCode);
                cmd.Parameters.Add(param);


                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@CustomerPartNo", poItem.CustomerPartNumber);
                cmd.Parameters.Add(param);


                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@FFTLPartPartNo", poItem.FFTLPartNumber);
                cmd.Parameters.Add(param);


                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@DescriptionOfPackages", null);
                cmd.Parameters.Add(param);


                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@NumberOfQuntity", poItem.NumberOfQuantity);
                cmd.Parameters.Add(param);


                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@UnitOfMesurement", poItem.UnitOfMesurement);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@PriceRate", poItem.PriceRate);
                cmd.Parameters.Add(param);


                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@POItemID", poItem.POItemID);
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
        /// Get the POItems from tblPOItem table depending on POItemCode
        /// </summary>
        /// <param name="POItemCode"></param>
        /// <returns></returns>
        public DataTable ViewPOItems()
        {

            try
            {
                SqlDataAdapter sqlAdapter = new SqlDataAdapter("GetPOItems", conn);

                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds, "POItems");

                DataTable dt = ds.Tables[0];

                return dt;


            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// return POItem which is going to be modify
        /// </summary>
        /// <param name="POItemCode"></param>
        /// <returns></returns>
        public POItem GetPOItemForEdit(int POItemCode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "GetPOItemForEdit";
                cmd.Connection = conn;

                SqlParameter param = new SqlParameter();
                POItem newPOItem = new POItem();

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@POItemID", POItemCode);
                cmd.Parameters.Add(param);

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    newPOItem.POItemID = Convert.ToInt32(rdr["POItemID"]);
                    newPOItem.ProductCode = Convert.ToInt32(rdr["ProductCode"]);
                    newPOItem.ProductName = rdr["POItemName"].ToString();
                    newPOItem.CustomerPartNumber = (rdr["CustomerPartNo"]).ToString();
                    newPOItem.FFTLPartNumber = (rdr["FFTLPartPartNo"]).ToString();
                    newPOItem.NumberOfQuantity = Convert.ToDouble(rdr["NumberOfQuntity"]);
                    newPOItem.UnitOfMesurement = rdr["UnitOfMesurement"].ToString();
                    newPOItem.PriceRate = Convert.ToDouble(rdr["PriceRate"]);

                }

                return newPOItem;


            }
            catch (Exception)
            {

                throw;
            }

        }

        #endregion





        public DataTable ViewPOItemsOfPO(int PurchaseOrderID)
        {
            SqlCommand cmd = new SqlCommand("", conn);
            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "GetPOItemsAsPerCustomerPO";
                cmd.Connection = conn;

                SqlParameter param = new SqlParameter();

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@PurchaseOrderID", PurchaseOrderID);
                cmd.Parameters.Add(param);

             
                SqlDataReader rdr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Columns.Add("POItemID");
                dt.Columns.Add("PurchaseOrderID");
                dt.Columns.Add("PurchaseOrderCode");
                dt.Columns.Add("CustomerCode");
                dt.Columns.Add(Constants.DT_SR_NO_COLUMN );
                dt.Columns.Add(Constants.DT_PRODUCTCODE_COLUMN);
                dt.Columns.Add(Constants.DT_PRODUCTNAME_COLUMN);
                dt.Columns.Add(Constants.DT_CUSTOMER_PART_NO_COLUMN);
                dt.Columns.Add(Constants.DT_FFTL_PART_NO_COLUMN);
                dt.Columns.Add(Constants.DT_UNIT_COLUMN);
                dt.Columns.Add(Constants.DT_PRICE_COLUMN);
                dt.Columns.Add("ChapterHeading1");
                dt.Columns.Add("ChapterHeading2");
                int count = 0;

                while (rdr.Read())
                {
                    DataRow dr = dt.NewRow();
                    count = count + 1;

                    dr[Constants.DT_SR_NO_COLUMN] = count.ToString();
                    dr["POItemID"] = Convert.ToInt32(rdr["POItemID"]);
                    dr["PurchaseOrderID"] = Convert.ToInt32(rdr["PurchaseOrderID"]);                    
                    dr["PurchaseOrderCode"] = rdr["PurchaseOrderCode"].ToString();
                    dr["CustomerCode"] = rdr["CustomerCode"].ToString();
                    dr[Constants.DT_PRODUCTCODE_COLUMN] = Convert.ToInt32(rdr["ProductCode"]);
                    dr[Constants.DT_PRODUCTNAME_COLUMN] = rdr["ProductName"].ToString();
                    dr[Constants.DT_CUSTOMER_PART_NO_COLUMN] = Convert.ToString(rdr["CustomerPartNo"]);
                    dr[Constants.DT_FFTL_PART_NO_COLUMN] = Convert.ToString(rdr["FFTLPartPartNo"]);
                    dr[Constants.DT_UNIT_COLUMN] = rdr["UnitOfMesurement"].ToString();
                    dr[Constants.DT_PRICE_COLUMN] = Convert.ToDouble(rdr["PriceRate"]);
                    dr["ChapterHeading1"] = Convert.ToString(rdr["ChapterHeading1"]);
                    dr["ChapterHeading2"] = Convert.ToString(rdr["ChapterHeading2"]);

                    dt.Rows.Add(dr);

                }



                return dt;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable GetPOItemsForPOCustomers(int purchaseOrderID)
        {
            try
            {

                //SqlCommand cmd = new SqlCommand("", conn);
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.CommandText = "GetPOItemsAsPerCustomerPO";
                //cmd.Connection = conn;

                //SqlParameter param = new SqlParameter();

                //param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@PurchaseOrderID", PurchaseOrderID);
                //cmd.Parameters.Add(param);


                // DataSet that will hold the returned results
                DataSet ds = new DataSet();

                // Call FillDataset static method of SqlHelper class that fills a existing Dataset
                // We pass in database connection string, command type, stored procedure name and categoryID SqlParameter
                // that has a value of "1"
                SqlHelper.FillDataset(conn, CommandType.StoredProcedure, "GetPOItemsAsPerCustomerPO", ds, new string[] { "POItems" }, new SqlParameter("@PurchaseOrderID", purchaseOrderID));
                return ds.Tables["POItem"];
				

            }
            catch (Exception)
            {

                throw;
            }


        }

        internal void DeletePOItem(int POItemID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "DeletePOItem";
                cmd.Connection = conn;

                SqlParameter param = new SqlParameter();


                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@POItemID", POItemID);
                cmd.Parameters.Add(param);


                        
                 cmd.ExecuteReader();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }

}
