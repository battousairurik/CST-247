using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Register : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{

	}

    protected void RegistrationQuery()
    {
        string strcon = "Data Source=.;uid=root;pwd=root;database=team";
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand com = new SqlCommand("CUser", con);
        com.CommandType = System.Data.CommandType.StoredProcedure;

        SqlParameter p1 = new SqlParameter("firstname", TextBoxfirstname.Text);
        SqlParameter p2 = new SqlParameter("lastname", TextBoxlastname.Text);
        SqlParameter p3 = new SqlParameter("gender", TextBoxgender.Text);
        SqlParameter p4 = new SqlParameter("age", TextBoxage.Text);
        SqlParameter p5 = new SqlParameter("state", TextBoxstate.Text);
        SqlParameter p6 = new SqlParameter("email", TextBoxemail.Text);
        SqlParameter p7 = new SqlParameter("username", TextBoxusername.Text);
        SqlParameter p8 = new SqlParameter("password", TextBoxpassword.Text);

        com.Parameters.Add(p7);
        com.Parameters.Add(p1);
        com.Parameters.Add(p2);
        com.Parameters.Add(p3);
        com.Parameters.Add(p4);
        com.Parameters.Add(p5);
        com.Parameters.Add(p6);
        com.Parameters.Add(p8);

        con.Open();
        SqlDataReader rd = com.ExecuteReader();

        if (rd.HasRows)
        {
            rd.Read();
            Label3.Text = "Registration successful.";
            Label3.Visible = true;
        }
        else
        {
            Label3.Text = "Invalid username or password.";
            Label3.Visible = true;
        }
    }

	protected void Buttonregister_Click(object sender, EventArgs e)
	{
        RegistrationQuery();
		
	}

	protected void Button2_Click(object sender, EventArgs e)
	{
		Response.Redirect("~/Login.aspx");
	}



	
}