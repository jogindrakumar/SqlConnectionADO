﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace SqlConnectionADOweb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
           
            using (SqlConnection con = new SqlConnection(CS))
            {

                //SqlCommand cmd = new SqlCommand("Select * from tblProduct", con);
                //con.Open();
                //GridView1.DataSource = cmd.ExecuteReader();
                //GridView1.DataBind();

                //2nd way
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select * from tblProduct";
                cmd.Connection= con;
                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();



            }



        }
    }
}