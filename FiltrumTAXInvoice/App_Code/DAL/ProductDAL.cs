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
    public class ProductDAL
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
        public ProductDAL()
        {

            /// <summary>
            /// Open the Sql Connection
            /// </summary>
            string connectionString = ConfigurationSettings.AppSettings["connectionString1"].ToString();
            conn = new SqlConnection(connectionString);
            conn.Open();
        }


        /// <summary>
        /// Add the Product into database
        /// </summary>
        /// <param name="Product"></param>
        /// <returns></returns>
        public int AddProduct(Product Product)
        {
            SqlCommand cmd = new SqlCommand("", conn);
            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "AddProduct";
                cmd.Connection = conn;

                SqlParameter param = new SqlParameter();

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ProductCode", Product.ProductCode);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ProductName", Product.ProductName);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ChapterHeading1", Product.ChapterHeading1);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ChapterHeading2", Product.ChaperHeading2);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@Description", Product.Description);
                cmd.Parameters.Add(param);



                param = this.AddNewParameter(System.Data.ParameterDirection.Output, "@ResultValue", 0);
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
        /// Modify the Product
        /// </summary>
        /// <param name="Product"></param>
        /// <returns></returns>
        public int ModifyProduct(Product Product)
        {
            SqlCommand cmd = new SqlCommand("", conn);
            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "ModifyProduct";
                cmd.Connection = conn;

                SqlParameter param = new SqlParameter();

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ProductCode", Product.ProductCode);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ProductName", Product.ProductName);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ChapterHeading1", Product.ChapterHeading1);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ChapterHeading2", Product.ChaperHeading2);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@Description", Product.Description);
                cmd.Parameters.Add(param);



                SqlParameter param1 = this.AddNewParameter(System.Data.ParameterDirection.Output, "@ResultValue", 0);
                cmd.Parameters.Add(param1);

               
                int resultValue = cmd.ExecuteNonQuery();
                //  int retValue = Convert.ToInt32("@ResultValue");

                return Convert.ToInt32(param1.Value);



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
        /// Get the Products from tblProduct table depending on ProductCode
        /// </summary>
        /// <param name="ProductCode"></param>
        /// <returns></returns>
        public DataTable ViewProducts()
        {

            try
            {
                SqlDataAdapter sqlAdapter = new SqlDataAdapter("GetProducts", conn);
                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds, "Products");

                DataTable dt = ds.Tables[0];

                return dt;


            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// return Product which is going to be modify
        /// </summary>
        /// <param name="ProductCode"></param>
        /// <returns></returns>
        public Product GetProductForEdit(int ProductCode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "GetProductForEdit";
                cmd.Connection = conn;

                SqlParameter param = new SqlParameter();
                Product newProduct = new Product();

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ProductCode", ProductCode);
                cmd.Parameters.Add(param);

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    newProduct.ProductCode = Convert.ToInt32(rdr["ProductCode"]);
                    newProduct.ProductName = rdr["ProductName"].ToString();
                    newProduct.ChapterHeading1 = rdr["ChapterHeading1"].ToString();
                    newProduct.ChaperHeading2 = rdr["ChapterHeading2"].ToString();
                    newProduct.Description  = rdr["Description"].ToString();

                }

                return newProduct;


            }
            catch (Exception)
            {

                throw;
            }

        }


        public DataTable GetProductDetails()
        {

            try
            {
                // DataSet that will hold the returned results
                DataSet ds;

                // Call ExecuteDataset static method of SqlHelper class that returns a Dataset
                // We pass in database connection string, command type, stored procedure name and categoryID SqlParameter
                // that has a value of "1"
                ds = SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, "rptGetProductDetails");

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
