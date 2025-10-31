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
    public class UserDAL
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
        public UserDAL()
        {

            /// <summary>
            /// Open the Sql Connection
            /// </summary>
            string connectionString = ConfigurationSettings.AppSettings["connectionString1"].ToString();
            conn = new SqlConnection(connectionString);
            conn.Open();
        }


        /// <summary>
        /// Add the User into database
        /// </summary>
        /// <param name="User"></param>
        /// <returns></returns>
        public int AddUser(User user)
        {
            SqlCommand cmd = new SqlCommand("", conn);
            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "AddUser";
                cmd.Connection = conn;

                SqlParameter param = new SqlParameter();


                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@UserName", user.UserName);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@Password", user.Password);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@UserType", user.UserType);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@Department", user.Department);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@Description", user.Description);
                cmd.Parameters.Add(param);




                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@CustomerManagement", user.AllowCustomerManagement);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@CustomerAdd", user.AllowCustomerAdd);
                cmd.Parameters.Add(param);


                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@CustomerModify", user.AllowCustomerModify);
                cmd.Parameters.Add(param);


                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@CustomerView", user.AllowCustomerView);
                cmd.Parameters.Add(param);


                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ProductManagement", user.AllowProductManagement);
                cmd.Parameters.Add(param);


                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ProductView", user.AllowProductView);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ProductAdd", user.AllowPoductAdd);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ProductModify", user.AllowPoductModify);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@POManagement", user.AllowPOManagement);
                cmd.Parameters.Add(param);


                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@POAdd", user.AllowPOAdd);
                cmd.Parameters.Add(param);


                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@POModify", user.AllowPOModify);
                cmd.Parameters.Add(param);


                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@POView", user.AllowPOView);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@InvoiceManagement", user.AllowInvoiceManagement);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@InvoiceAdd", user.AllowInvoiceAdd);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@InvoiceView", user.AllowInvoiceView);
                cmd.Parameters.Add(param);


                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@UserRoleManagement", user.AllowUserRoleManagement);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@CustomerDetails", user.AllowRptCustomerDetails);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ProductDetails", user.AllowRptProductDetails);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@PODetails", user.AllowRptPOs);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@InvoiceDetails", user.AllowRptInvoiceDetails);
                cmd.Parameters.Add(param);

                SqlParameter param1 = this.AddNewParameter(System.Data.ParameterDirection.Output, "@ResultValue", 0);
                cmd.Parameters.Add(param1);

                int resultValue = cmd.ExecuteNonQuery();


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
        /// Modify the User
        /// </summary>
        /// <param name="User"></param>
        /// <returns></returns>
        public int ModifyUser(User user)
        {
            SqlCommand cmd = new SqlCommand("", conn);
            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "ModifyUser";
                cmd.Connection = conn;

                SqlParameter param = new SqlParameter();



                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@UserName", user.UserName);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@Password", user.Password );
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@UserType", user.UserType);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@Department", user.Department);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@Description", user.Description);
                cmd.Parameters.Add(param);




                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@CustomerManagement", user.AllowCustomerManagement);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@CustomerAdd", user.AllowCustomerAdd);
                cmd.Parameters.Add(param);


                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@CustomerModify", user.AllowCustomerModify);
                cmd.Parameters.Add(param);


                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@CustomerView", user.AllowCustomerView);
                cmd.Parameters.Add(param);


                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ProductManagement", user.AllowProductManagement);
                cmd.Parameters.Add(param);


                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ProductView", user.AllowProductView);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ProductAdd", user.AllowPoductAdd);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ProductModify", user.AllowPoductModify);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@POManagement", user.AllowPOManagement);
                cmd.Parameters.Add(param);


                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@POAdd", user.AllowPOAdd);
                cmd.Parameters.Add(param);


                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@POModify", user.AllowPOModify);
                cmd.Parameters.Add(param);


                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@POView", user.AllowPOView);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@InvoiceManagement", user.AllowInvoiceManagement);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@InvoiceAdd", user.AllowInvoiceAdd);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@InvoiceView", user.AllowInvoiceView);
                cmd.Parameters.Add(param);


                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@UserRoleManagement", user.AllowUserRoleManagement);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@CustomerDetails", user.AllowRptCustomerDetails);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ProductDetails", user.AllowRptProductDetails);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@PODetails", user.AllowRptPOs);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@InvoiceDetails", user.AllowRptInvoiceDetails);
                cmd.Parameters.Add(param);

                SqlParameter param1 = this.AddNewParameter(System.Data.ParameterDirection.Output, "@ResultValue", user.AllowRptInvoiceDetails);
                cmd.Parameters.Add(param1);

                int resultValue = cmd.ExecuteNonQuery();

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
        /// Get the Users from tblUser table depending on UserCode
        /// </summary>
        /// <param name="UserCode"></param>
        /// <returns></returns>
        public DataTable ViewUsers()
        {

            try
            {
                SqlDataAdapter sqlAdapter = new SqlDataAdapter("GetUsers", conn);
                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds, "Users");

                DataTable dt = ds.Tables[0];

                return dt;


            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// return User which is going to be modify
        /// </summary>
        /// <param name="UserCode"></param>
        /// <returns></returns>
        public User GetUserForEdit(string UserName)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "GetUserForEdit";
                cmd.Connection = conn;

                SqlParameter param = new SqlParameter();
                User newUser = new User();

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@UserName", UserName);
                cmd.Parameters.Add(param);



                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    newUser.UserName = rdr["UserName"].ToString();
                    newUser.Password = rdr["Password"].ToString();
                    newUser.UserType = rdr["UserType"].ToString();
                    newUser.Department = rdr["Department"].ToString();
                    newUser.Description = rdr["Description"].ToString();

                    if (rdr["CustomerManagement"] != null)
                        newUser.AllowCustomerManagement = Convert.ToBoolean(rdr["CustomerManagement"]);
                    if (rdr["CustomerAdd"].ToString() != null)
                        newUser.AllowCustomerAdd = Convert.ToBoolean(rdr["CustomerAdd"]);
                    if (rdr["CustomerModify"] != null)
                        newUser.AllowCustomerModify = Convert.ToBoolean(rdr["CustomerModify"]);
                    if (rdr["CustomerView"] != null)
                        newUser.AllowCustomerView = Convert.ToBoolean(rdr["CustomerView"]);
                    if (rdr["ProductManagement"] != null)
                        newUser.AllowProductManagement = Convert.ToBoolean(rdr["ProductManagement"]);
                    if (rdr["ProductAdd"] != null)
                        newUser.AllowPoductAdd = Convert.ToBoolean(rdr["ProductAdd"]);
                    if (rdr["ProductModify"] != null)
                        newUser.AllowPoductModify = Convert.ToBoolean(rdr["ProductModify"]);
                    if (rdr["ProductModify"] != null)
                        newUser.AllowProductView = Convert.ToBoolean(rdr["ProductModify"]);
                    if (rdr["POManagement"] != null)
                        newUser.AllowPOManagement = Convert.ToBoolean(rdr["POManagement"]);
                    if (rdr["POAdd"] != null)
                        newUser.AllowPOAdd = Convert.ToBoolean(rdr["POAdd"]);
                    if (rdr["POModify"] != null)
                        newUser.AllowPOModify = Convert.ToBoolean(rdr["POModify"]);
                    if (rdr["POView"] != null)
                        newUser.AllowPOView = Convert.ToBoolean(rdr["POView"]);
                    if (rdr["InvoiceManagement"] != null)
                        newUser.AllowInvoiceManagement = Convert.ToBoolean(rdr["InvoiceManagement"]);
                    if (rdr["InvoiceAdd"] != null)
                        newUser.AllowInvoiceAdd = Convert.ToBoolean(rdr["InvoiceAdd"]);
                    if (rdr["InvoiceView"] != null)
                        newUser.AllowInvoiceView = Convert.ToBoolean(rdr["InvoiceView"]);


                    if (rdr["UserRoleManagement"] != null)
                        newUser.AllowUserRoleManagement = Convert.ToBoolean(rdr["UserRoleManagement"]);
                    if (rdr["CustomerDetails"] != null)
                        newUser.AllowRptCustomerDetails = Convert.ToBoolean(rdr["CustomerDetails"]);
                    if (rdr["ProductDetails"] != null)
                        newUser.AllowRptProductDetails = Convert.ToBoolean(rdr["ProductDetails"]);
                    if (rdr["PODetails"] != null)
                        newUser.AllowRptPOs = Convert.ToBoolean(rdr["PODetails"]);
                    if (rdr["InvoiceDetails"] != null)
                        newUser.AllowRptInvoiceDetails = Convert.ToBoolean(rdr["InvoiceDetails"]);


                }

                return newUser;


            }
            catch (Exception)
            {

                throw;
            }

        }

        #endregion





        internal int ValidateUser(string userName, string password)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "ValidateUser";
                cmd.Connection = conn;

                SqlParameter param = new SqlParameter();
                SqlParameter outParam = new SqlParameter();


                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@UserName", userName);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@Password", password);
                cmd.Parameters.Add(param);

                outParam = this.AddNewParameter(System.Data.ParameterDirection.Output, "@ValidateResult", 0);
                cmd.Parameters.Add(outParam);


                int retValue = cmd.ExecuteNonQuery();

                int isValidated = Convert.ToInt32(outParam.Value);

                return isValidated;
            }
            catch (Exception)
            {

                throw;
            }


        }
    }

}
