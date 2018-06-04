using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Security;
using System.Data;

namespace AspRevisionPhase2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //bool authenticated = FormsAuthentication.Authenticate(txtUserName.Text, txtPassword.Text);//that's against web config
            bool authenticated = Authenticate(txtUserName.Text, txtPassword.Text);
            if (authenticated)
            {

                FormsAuthentication.RedirectFromLoginPage(txtUserName.Text, chkBoxRememberMe.Checked);
            }
            else
            {
                lblMessage.Text = "Invalid UserName and/or password";
            }

        }
        private bool Authenticate(string username, string password)
        {

            string CS = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
            // SqlConnection is in System.Data.SqlClient namespace
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("spAuthenticateUser", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // FormsAuthentication is in System.Web.Security
                // SqlParameter is in System.Data namespace
                SqlParameter paramUsername = new SqlParameter("@username", username);
                SqlParameter paramPassword = new SqlParameter("@password", password);


                cmd.Parameters.Add(paramUsername);
                cmd.Parameters.Add(paramPassword);

                con.Open();
                int ReturnCode = (int)cmd.ExecuteScalar();
                return ReturnCode == 1;
            }

        }
    }
}