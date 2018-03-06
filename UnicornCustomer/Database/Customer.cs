using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace UnicornCustomer.Database
{
    public class Customer
    {
        public bool Save(string FirstName, string LastName, string Nationality, int Age)
        {
            var connstring = @"Data Source = .\SQLEXPRESS;Initial Catalog=test;User Id=sa;Password=admin";

            using (SqlConnection openCon = new SqlConnection(connstring))
            {
                var ssql = "insert into dbo.Customer"
                    + " ([First Name], [Last Name], Nationality, Age)"
                    + " values (@FirstName, @LastName, @Nationality, @Age)";

                using (SqlCommand sqlCommand = new SqlCommand(ssql))
                {
                    sqlCommand.Connection = openCon;
                    sqlCommand.Parameters.AddWithValue("@FirstName", FirstName);
                    sqlCommand.Parameters.AddWithValue("@LastName", LastName);
                    sqlCommand.Parameters.AddWithValue("@Nationality", Nationality);
                    sqlCommand.Parameters.AddWithValue("@Age", Age);
                    openCon.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }


            return false;
        }
    }
}