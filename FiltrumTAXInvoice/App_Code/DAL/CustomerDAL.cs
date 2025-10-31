using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using FiltrumTaxInvoice.BusinessObjects.BO;
using FiltrumTaxInvoice.BusinessObjects.Common;
using System.Data;
using System.Collections;

namespace FiltrumTaxInvoice.DAL
{
    public class CustomerDAL
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
        public CustomerDAL()
        {

            /// <summary>
            /// Open the Sql Connection
            /// </summary>
            string connectionString = ConfigurationSettings.AppSettings["connectionString1"].ToString();
            conn = new SqlConnection(connectionString);
            conn.Open();
        }


        /// <summary>
        /// Add the Customer into database
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public int AddCustomer(Customer customer)
        {
            SqlCommand cmd = new SqlCommand("", conn);
            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "AddCustomer";
                cmd.Connection = conn;

                SqlParameter param = new SqlParameter();

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@CustomerFirstName", customer.CustomerFirstName);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@CustomerLastName", customer.CustomerLastName);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@BillingAddress", customer.BillingAddress);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ShippingAddress", customer.ShippingAddress);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ECCNumber", customer.ECCNo);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@Country", customer.Country);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@State", customer.State);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@City", customer.City);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@PinNumber", customer.PinCode);
                cmd.Parameters.Add(param);
                
                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@PhoneNumber", customer.PhoneNumber);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@FaxNumber", customer.FaxNumber);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@Email", customer.Email);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@IsDomestic", customer.IsDomestic);
                param.SqlDbType = System.Data.SqlDbType.Bit;
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@Description", customer.Description);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@CessDuty", customer.CessDuty);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ECessDuty", customer.EcessDuty);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@SHCessDuty", customer.SHCessDuty);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ExciseDuty", customer.ExciseDuty);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@VATRate", customer.VATDuty);
                cmd.Parameters.Add(param);

                  param = this.AddNewParameter(System.Data.ParameterDirection.Output, "@ResultValue", 0);
                cmd.Parameters.Add(param);

                SqlParameter param1 = this.AddNewParameter(System.Data.ParameterDirection.Output, "@CustomerCode", 0);
                cmd.Parameters.Add(param1);
                
                param = this.AddNewParameter(System.Data.ParameterDirection.Output, "@DutyID", 0);
                cmd.Parameters.Add(param);
                

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
        /// Modify the customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public int ModifyCustomer(Customer customer, int customerCode )
        {
            SqlCommand cmd = new SqlCommand("", conn);
            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "ModifyCustomer";
                cmd.Connection = conn;

                SqlParameter param = new SqlParameter();

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@CustomerCode", customerCode);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@CustomerFirstName", customer.CustomerFirstName);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@CustomerLastName", customer.CustomerLastName);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@BillingAddress", customer.BillingAddress);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ShippingAddress", customer.ShippingAddress);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ECCNumber", customer.ECCNo);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@Country", customer.Country);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@State", customer.State);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@City", customer.City);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@PinNumber", customer.PinCode);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@PhoneNumber", customer.PhoneNumber);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@FaxNumber", customer.FaxNumber);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@Email", customer.Email);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@IsDomestic", customer.IsDomestic);
                param.SqlDbType = System.Data.SqlDbType.Bit;
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@Description", customer.Description);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@CessDuty", customer.CessDuty);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ECessDuty", customer.EcessDuty);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@SHCessDuty", customer.SHCessDuty);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ExciseDuty", customer.ExciseDuty);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@VATRate", customer.VATDuty);
                cmd.Parameters.Add(param);

                SqlParameter param1 = this.AddNewParameter(System.Data.ParameterDirection.Output, "@ResultValue", 0);
                cmd.Parameters.Add(param1);

               
                int resultValue = cmd.ExecuteNonQuery();

                return Convert.ToInt32(param1.Value) ;



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
        /// Get the Customers from tblCustomer table depending on CustomerCode
        /// </summary>
        /// <param name="customerCode"></param>
        /// <returns></returns>
        public DataTable  ViewCustomers()
        {
           
            try
            {
                SqlDataAdapter sqlAdapter = new SqlDataAdapter( "GetCustomers", conn);
                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds, "Customers");

                DataTable dt = ds.Tables[0];

                return dt;


            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// return Customer which is going to be modify
        /// </summary>
        /// <param name="customerCode"></param>
        /// <returns></returns>
        public Customer GetCustomerForEdit(int customerCode)
        {
            try
            {
                 SqlCommand cmd = new SqlCommand("", conn);
           
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "GetCustomerForEdit";
                cmd.Connection = conn;

                SqlParameter param = new SqlParameter();
                Customer newCustomer = new Customer();

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@CustomerCode", customerCode);
                cmd.Parameters.Add(param);

                SqlDataReader rdr = cmd.ExecuteReader();

                while(rdr.Read())
                {
                    newCustomer.CusomerCode = Convert.ToInt32(rdr["CustomerCode"]);
                    newCustomer.CustomerFirstName = rdr["CustomerFirstName"].ToString();
                    newCustomer.CustomerLastName = rdr["CustomerLastName"].ToString();


                    newCustomer.BillingAddress = rdr["BillingAddress"].ToString();
                    newCustomer.ShippingAddress = rdr["ShippingAddress"].ToString();
                    newCustomer.ECCNo = rdr["ECCNumber"].ToString();
                    newCustomer.Country = rdr["Country"].ToString();
                    newCustomer.State = rdr["State"].ToString();
                    newCustomer.City = rdr["City"].ToString();
                    newCustomer.PinCode = Convert.ToInt32(rdr["PinNumber"]);
                    newCustomer.PhoneNumber = (rdr["PhoneNumber"]).ToString();
                    newCustomer.FaxNumber = (rdr["FaxNumber"]).ToString();
                    newCustomer.Email =  rdr["Email"].ToString();
                    newCustomer.CessDuty = Convert.ToDecimal(rdr["CessDuty"]);
                    newCustomer.EcessDuty = Convert.ToDecimal(rdr["ECessDuty"]);
                    newCustomer.SHCessDuty = Convert.ToDecimal(rdr["SHCessDuty"]);
                    newCustomer.VATDuty = Convert.ToDecimal(rdr["VATRate"]);
                    newCustomer.ExciseDuty = Convert.ToDecimal(rdr["ExciseDuty"]);
                    newCustomer.IsDomestic = Convert.ToBoolean(rdr["IsDomestic"]);
                    newCustomer.Description = rdr["Description"].ToString();



                }

                return newCustomer ;


            }
            catch (Exception)
            {
                
                throw;
            }

        }

        public int GetLastInvoiceCount(string custType)
        {
             SqlCommand cmd = new SqlCommand("", conn);
             try
             {
                 cmd.CommandType = System.Data.CommandType.StoredProcedure;
                 cmd.CommandText = "GetLastInvoiceID";
                 cmd.Connection = conn;

           

                 SqlParameter param = new SqlParameter();

                 param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@CustomerType", custType);
                 cmd.Parameters.Add(param);

                 
                 param = this.AddNewParameter(System.Data.ParameterDirection.Output, "@ResultValue", 0);
                 cmd.Parameters.Add(param);

                


                 cmd.ExecuteNonQuery();

                 return Convert.ToInt32(param.Value);
             }
             catch (Exception)
             {

                 throw;
             }
        }

        public DataTable GetCustomerDetailsReport()
        {

            try
            {


                SqlDataAdapter sqlAdapter = new SqlDataAdapter("rptGetCustomersDetails", conn);
                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds, "Customers");

                DataTable dt = ds.Tables[0];

                return dt;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        #endregion




    }

}
