using System;
using System.Collections.Generic;
using System.Text;
using FiltrumTaxInvoice.BusinessObjects.BO;
using FiltrumTaxInvoice.BusinessObjects.Common;
using FiltrumTaxInvoice.DAL;
using System.Data;



namespace FiltrumTaxInvoice.BAL
{
    public class UserBAL
    {
        #region Public Methods
        public UserBAL()
        {

        }

        /// <summary>
        /// Adding User in tblUser table
        /// </summary>
        /// <param name="User"></param>
        /// <returns></returns>
        public int AddUser(User User)
        {
            UserDAL userDAL = new UserDAL();

            try
            {

                return userDAL.AddUser(User);
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
        /// Modifying the selcted User
        /// </summary>
        /// <param name="User"></param>
        /// <param name="UserCode"></param>
        /// <returns></returns>
        public int ModifyUser(User User)
        {
            UserDAL userDAL = new UserDAL();

            try
            {

                return userDAL.ModifyUser(User);
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
        /// Get Users depending on User Code and View it
        /// </summary>
        /// <param name="UserCode"></param>
        /// <returns></returns>
        public DataTable ViewUsers()
        {
            UserDAL userDAL = new UserDAL();

            try
            {

                return userDAL.ViewUsers();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {

            }
        }


        public User GetUserForEdit(string UserName)
        {
            UserDAL userDAL = new UserDAL();

            try
            {

                return userDAL.GetUserForEdit(UserName);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {

            }
        }

        public int ValidateUser(string userName, string password)
        {
            UserDAL userDAL = new UserDAL();

            try
            {

                return userDAL.ValidateUser(userName, password);
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
