using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Login : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{

	}

	protected void Buttonlogin_Click(object sender, EventArgs e)
	{
		string strcon = "Data Source=.;uid=root;pwd=root;database=team";
		SqlConnection con = new SqlConnection(strcon);
		SqlCommand com = new SqlCommand("CUser", con);
		com.CommandType = System.Data.CommandType.StoredProcedure;
		SqlParameter p1 = new SqlParameter("username", TextBoxusername.Text);
		SqlParameter p2 = new SqlParameter("password", TextBoxpassword.Text);
		com.Parameters.Add(p1);
		com.Parameters.Add(p2);
		con.Open();
		SqlDataReader rd = com.ExecuteReader();
		if (rd.HasRows)
		{
			rd.Read();
			Label1.Text = "Login successful.";
			Label1.Visible = true;
		}
		else
		{
			Label1.Text = "Invalid username or password.";
			Label1.Visible = true;
		}
	}

	protected void Buttonregister_Click(object sender, EventArgs e)
	{
		Response.Redirect("~/Register.aspx");
	}
}