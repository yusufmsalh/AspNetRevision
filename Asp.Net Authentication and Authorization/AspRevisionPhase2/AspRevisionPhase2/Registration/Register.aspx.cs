using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Security;
using System.Data;
namespace AspRevisionPhase2.Registration
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                #region Unique UserName
                //if (CanRegisterUserName(txtUserName.Text))
                //{
                //    lblMessage.Text = "User Registered SuccessFully";
                //    lblMessage.ForeColor = System.Drawing.Color.Green;

                //}

                //else
                //{
                //    lblMessage.Text = "UserName Already Exists";
                //    lblMessage.ForeColor = System.Drawing.Color.Red;
                //} 
                #endregion

                if (RegisterNew(txtUserName.Text, txtPassword.Text ,txtEmail.Text))
                {
                    lblMessage.Text = "User Logged Successfully,redirecting to Login Page ...";
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                    lblMessage.Visible = true;
                    System.Threading.Thread.Sleep(5000);
                       Server.Transfer("~/Login.aspx", true);

                }
                else
                {
                    lblMessage.Text = "Failed to Register";
                    lblMessage.ForeColor = System.Drawing.Color.OrangeRed;
                }
            }


        }



        private bool CanRegisterUserName(string username)
        {


            string CS = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
            // SqlConnection is in System.Data.SqlClient namespace
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("spCanRegisterUsername", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // FormsAuthentication is in System.Web.Security
                // SqlParameter is in System.Data namespace
                SqlParameter paramUsername = new SqlParameter("@username", username);


                cmd.Parameters.Add(paramUsername);

                con.Open();
                int ReturnCode = (int)cmd.ExecuteScalar();
                return ReturnCode == 1;
            }
        }


        private bool RegisterNew(string username, string password,string email)
        {

            string CS = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
            // SqlConnection is in System.Data.SqlClient namespace
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("spRegisterUser", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // FormsAuthentication is in System.Web.Security
                // SqlParameter is in System.Data namespace
                SqlParameter paramUsername = new SqlParameter("@username", username);
                SqlParameter paramPassword = new SqlParameter("@password", password);//Hash it in the future
                SqlParameter paramEmail = new SqlParameter("@email", email);//Hash it in the future


                cmd.Parameters.Add(paramUsername);
                cmd.Parameters.Add(paramPassword);
                cmd.Parameters.Add(paramEmail);

                con.Open();
                int ReturnCode = (int)cmd.ExecuteScalar();
                return ReturnCode == 1;


            }

        }
    }
}
