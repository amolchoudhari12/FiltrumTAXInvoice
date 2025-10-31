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
    public class InvoiceDAL
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
        public InvoiceDAL()
        {

            /// <summary>
            /// Open the Sql Connection
            /// </summary>
            string connectionString = ConfigurationSettings.AppSettings["connectionString1"].ToString();
            conn = new SqlConnection(connectionString);
            conn.Open();
        }


        /// <summary>
        /// Add the Invoice into database
        /// </summary>
        /// <param name="Invoice"></param>
        /// <returns></returns>
        public int AddInvoice(Invoice Invoice)
        {
            SqlCommand cmd = new SqlCommand("", conn);
            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "AddInvoice";
                cmd.Connection = conn;

                SqlParameter param = new SqlParameter();

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@SerialNumber", Invoice.SerialNumber);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@CustomerCode", Invoice.CustomerCode);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@PurchaseOrderCode", Invoice.POCode);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@PODate", Invoice.PODate);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ExcisableName", Invoice.ProductName);
                cmd.Parameters.Add(param);

                //
                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ChapterHeading1", Invoice.ChapterHeading1);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ChapterHeading2", Invoice.ChapterHeading2);
                cmd.Parameters.Add(param);

                if (Invoice.RateOfDuty != string.Empty)
                {
                    param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@RateOfDuty", Invoice.RateOfDuty);
                    cmd.Parameters.Add(param);
                }
                else
                {
                    param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@RateOfDuty", 0);
                    cmd.Parameters.Add(param);
                }

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@TransportMode", Invoice.TranseportMode);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@VehicleNumber", Invoice.VehicleNumber);
                cmd.Parameters.Add(param);

                //

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@InvoiceNetValue", Invoice.NetValue);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@InvoiceGrossValue", Invoice.GrossAmount);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@CentralExciseDuty",Invoice.ExsiceDuty);
                cmd.Parameters.Add(param);


               SqlParameter outParam = this.AddNewParameter(System.Data.ParameterDirection.Output, "@InvoiceID", 0);
               cmd.Parameters.Add(outParam);

                param = this.AddNewParameter(System.Data.ParameterDirection.Output, "@ResultValue", 0);
                cmd.Parameters.Add(param);

                int resultValue = cmd.ExecuteNonQuery();

                return Convert.ToInt32(outParam.Value) ;



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
        /// Modify the Invoice
        /// </summary>
        /// <param name="Invoice"></param>
        /// <returns></returns>
        public int ModifyInvoice(Invoice Invoice, int InvoiceCode)
        {
            SqlCommand cmd = new SqlCommand("", conn);
            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "ModifyInvoice";
                cmd.Connection = conn;

                SqlParameter param = new SqlParameter();

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@SerialNumber", Invoice.SerialNumber);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@CustomerCode", Invoice.CustomerCode);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@PurchaseOrderCode", Invoice.POCode);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@PODate", Invoice.PODate);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ExcisableName", Invoice.ProductName);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ChapterHeading1", Invoice.ChapterHeading1);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ChapterHeading2", Invoice.ChapterHeading2);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@RateOfDuty", Invoice.RateOfDuty);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@TransportMode", Invoice.TranseportMode);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@VehicleNumber", Invoice.VehicleNumber);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@InvoiceNetValue", Invoice.NetValue);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@InvoiceGrossValue", Invoice.GrossAmount);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@CentralExciseDuty", Invoice.ExsiceDuty);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@BillingAddress", Invoice.BillingAddress);
                param.SqlDbType = System.Data.SqlDbType.Bit;
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ShippingAddress", Invoice.ShippingAddress);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@CustomerECCCode", Invoice.ECCNum);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ExciseDutyAmount", Invoice.ExsiceDuty);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@CessDutyAmount", Invoice.CessDuty);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ECessDutyAmount", Invoice.EcessDuty);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@SHCessDutyAmount", Invoice.SHCessDuty);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@VATRateAmount", Invoice.VATDuty);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@InvoiceDate", Invoice.InvoiceDate);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@InvoiceTime", Invoice.InvoiceTime);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@RemovalDate", Invoice.RemovalDate);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@RemovalTime", Invoice.RemovalTime);
                cmd.Parameters.Add(param);



                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@InvoiceCreatedBy", Invoice.UserName);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@MachineName", Invoice.MashineName);
                cmd.Parameters.Add(param);


                foreach (POItem poItem in Invoice.POItems)
                {

                    param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@POItemID", poItem.POItemID);
                    cmd.Parameters.Add(param);

                    param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@POItemName", poItem.ProductName);
                    cmd.Parameters.Add(param);

                    param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@CustomerPartNumber", poItem.CustomerPartNumber);
                    cmd.Parameters.Add(param);

                    param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@FFTLPartNumber", poItem.FFTLPartNumber);
                    cmd.Parameters.Add(param);

                    param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@PackagesDescription", poItem.DescriptionOfPackages);
                    cmd.Parameters.Add(param);


                    param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@UnitOfQuanity", poItem.UnitOfMesurement);
                    cmd.Parameters.Add(param);

                    param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@PriceRate", poItem.PriceRate);
                    cmd.Parameters.Add(param);

                    param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ItemTotalAmount", poItem.ItemTotalAmount);
                    cmd.Parameters.Add(param);


                    param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@Description", "");
                    cmd.Parameters.Add(param);

                }






                param = this.AddNewParameter(System.Data.ParameterDirection.Output, "@InvoiceID", 0);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Output, "@InvoiceHistoryID", 0);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Output, "@InvoiceItemID", 0);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Output, "@ResultValue", 0);
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
        /// Get the Invoices from tblInvoice table depending on InvoiceCode
        /// </summary>
        /// <param name="InvoiceCode"></param>
        /// <returns></returns>
        public DataTable ViewInvoices()
        {

            try
            {
                SqlDataAdapter sqlAdapter = new SqlDataAdapter("GetInvoices", conn);
                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds, "Invoices");

                DataTable dt = ds.Tables[0];

                return dt;


            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// return Invoice which is going to be modify
        /// </summary>
        /// <param name="InvoiceCode"></param>
        /// <returns></returns>
        public Invoice GetInvoiceForEdit(int InvoiceID)
        {
            return null;
        }
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand("", conn);

        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //        cmd.CommandText = "GetInvoiceForEdit";
        //        cmd.Connection = conn;

        //        SqlParameter param = new SqlParameter();
        //        Invoice newInvoice = new Invoice();

        //        param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@InvoiceCode", InvoiceCode);
        //        cmd.Parameters.Add(param);

        //        SqlDataReader rdr = cmd.ExecuteReader();

        //        while (rdr.Read())
        //        {
        //            currentInvoice.SerialNumber = 
        //            currentInvoice.CustomerCode = 
        //            currentInvoice.BillingAddress = 
        //            currentInvoice.ShippingAddress = 
        //            currentInvoice.POCode = 
        //            currentInvoice.PODate = 
        //            currentInvoice.TranseportMode = 
        //            currentInvoice.VehicleNumber =
        //            currentInvoice.ProductName = 
        //            currentInvoice.ChapterHeading1 = 
        //            currentInvoice.ChapterHeading2 =
        //            currentInvoice.RateOfDuty =
        //            currentInvoice.NetValue = 
        //            currentInvoice.ExsiceDuty = 
        //            if (txtCessDuty.Text != "")
        //                currentInvoice.CessDuty = 

        //            if (txtECessDuty.Text != "")
        //                currentInvoice.EcessDuty = 

        //            if (txtSHCessDuty.Text != "")
        //                currentInvoice.SHCessDuty = 

        //            if (txtVATRate.Text != "")
        //                currentInvoice.VATDuty = 

        //            if (txtGrossValue.Text != "")
        //                currentInvoice.GrossAmount = 
        //            currentInvoice.ExciseAmountInWords = 
        //            currentInvoice.GrossAmountInWords =
        //            currentInvoice.InvoiceDate = 
        //            currentInvoice.InvoiceTime =
        //            currentInvoice.RemovalDate = 
        //            currentInvoice.RemovalTime = 

        //            List<POItem> selectedPOItems = new List<POItem>();

        //            selectedPOItems = GetSelectedPOItems();
        //            currentInvoice.POItems = selectedPOItems;




        //            SessionDataScope.currentInvoice = currentInvoice;

        //            int retyrnValue = balInvoice.AddInvoice(currentInvoice);







        //        }

        //        return newInvoice;


        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //}

        #endregion





        internal int AddInvoicePOItems(POItem poItem, int invoiceID)
        {

            SqlCommand cmd = new SqlCommand("", conn);
            try
            {
                int resultValue = 0;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "SaveInvoicePOItems";
                cmd.Connection = conn;


                SqlParameter param = new SqlParameter();

                //param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@PurchaseOrderCode", Invoice.POCode);
                //cmd.Parameters.Add(param);

                //param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@PODate", Invoice.PODate);
                //cmd.Parameters.Add(param);

               
                   

                    param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@InvoiceID", invoiceID );
                    cmd.Parameters.Add(param);
              
                    param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@POItemID", poItem.POItemID);
                    cmd.Parameters.Add(param);

                    param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@POItemName", poItem.ProductName);
                    cmd.Parameters.Add(param);

                    param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@CustomerPartNumber", poItem.CustomerPartNumber );
                    cmd.Parameters.Add(param);

                    //

                    param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@FFTLPartNumber", poItem.FFTLPartNumber );
                    cmd.Parameters.Add(param);

                    param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@PackagesDescription", poItem.DescriptionOfPackages);
                    cmd.Parameters.Add(param);


                    param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@UnitOfQuanity", poItem.UnitOfMesurement );
                    cmd.Parameters.Add(param);


                    param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@TotalQuantity", poItem.NumberOfQuantity  );
                    cmd.Parameters.Add(param);


                    param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@PriceRate", poItem.PriceRate);
                    cmd.Parameters.Add(param);

                    param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ItemTotalAmount", poItem.ItemTotalAmount);
                    cmd.Parameters.Add(param);

                    param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@Description", "");
                    cmd.Parameters.Add(param);

                    param = this.AddNewParameter(System.Data.ParameterDirection.Output, "@InvoiceItemID", 0);
                    cmd.Parameters.Add(param);


                    param = this.AddNewParameter(System.Data.ParameterDirection.Output, "@ResultValue", 0);
                    cmd.Parameters.Add(param);

                    resultValue = cmd.ExecuteNonQuery();

              

              
               
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

        internal int AddInvoiceHistory(Invoice Invoice)
        {
            SqlCommand cmd = new SqlCommand("", conn);
            try
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "SaveInvoiceHistory";
                cmd.Connection = conn;

                SqlParameter param = new SqlParameter();


                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@InvoiceID", Invoice.InvoiceCode );
                cmd.Parameters.Add(param);


                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@CustomerCode", Invoice.CustomerCode);
                cmd.Parameters.Add(param);
             
                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@BillingAddress", Invoice.BillingAddress);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ShippingAddress", Invoice.ShippingAddress);
                cmd.Parameters.Add(param);
                //

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@CustomerECCCode", Invoice.ECCNum);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ExciseDutyAmount", Invoice.ExsiceDuty);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@CessDutyAmount", Invoice.CessDuty);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@ECessDutyAmount", Invoice.EcessDuty);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@SHCessDutyAmount", Invoice.SHCessDuty);
                cmd.Parameters.Add(param);
             
                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@VATRateAmount", Invoice.VATDuty);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@InvoiceDate", Invoice.InvoiceDate);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@InvoiceTime", Invoice.InvoiceTime);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@RemovalDate", Invoice.RemovalDate);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@RemovalTime", Invoice.RemovalTime);
                cmd.Parameters.Add(param);      

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@InvoiceCreatedBy", Invoice.UserName);
                cmd.Parameters.Add(param);

                param = this.AddNewParameter(System.Data.ParameterDirection.Input, "@MachineName", Invoice.MashineName);
                cmd.Parameters.Add(param);  

                param = this.AddNewParameter(System.Data.ParameterDirection.Output, "@InvoiceHistoryID", 0);
                cmd.Parameters.Add(param);


                param = this.AddNewParameter(System.Data.ParameterDirection.Output, "@ResultValue", 0);
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

        public DataTable GetInvoicesOfCustomer(int CustomerCode)
        {
            try
            {
                 // DataSet that will hold the returned results
                DataSet ds;

                // Call ExecuteDataset static method of SqlHelper class that returns a Dataset
                // We pass in database connection string, command type, stored procedure name and categoryID SqlParameter
                // that has a value of "1"
                ds = SqlHelper.ExecuteDataset(conn, CommandType.StoredProcedure, "GetInvoicesOfCustomer", new SqlParameter("@CustomerCode", CustomerCode));

                // Get XML representation of the dataset and display results in text box
                return ds.Tables[0];
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }

}
