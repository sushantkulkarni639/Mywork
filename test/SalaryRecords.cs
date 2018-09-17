﻿using System;
using System.Data.SqlClient;

namespace Assesment
{
    class SalaryRecords
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;

            try
            {
                con = new SqlConnection("data source=.; database=student; integrated security=true");
                SqlCommand query = new SqlCommand("select fullname, manager from Employee;", con);
                con.Open();
                SqlDataReader data = query.ExecuteReader();
                int count = data.FieldCount;
                while (data.Read())
                {
                    for (int i = 0; i < count; i++)
                    {
                        Console.Write(data[i] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("some wrong:" + e);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
