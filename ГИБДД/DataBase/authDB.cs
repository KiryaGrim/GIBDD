﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ГИБДД
{
    internal class authDB
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Sourse=GRIM_LORD;Initial Catalog=auth_db;Integrated Security=True");

        public void openConnection()
        {
            if(sqlConnection.State ==  System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if(sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getSqlConnection()
        {
            return sqlConnection;
        }
    }
}
