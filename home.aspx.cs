using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace sharn
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string username = txtUser.Text;
            string password = txtPass.Text;

            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["Sharn3"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "INSERT INTO bca (Username, Password) VALUES (@Username, @Password)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            Response.Write("User Registered Successfully!");


        }

        protected void Texuser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}