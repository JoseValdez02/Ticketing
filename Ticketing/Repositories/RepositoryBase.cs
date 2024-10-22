﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace Ticketing.Repositories
{
    public abstract class RepositoryBase
    {
        private readonly string _connectionString;
        public RepositoryBase() {

            _connectionString = "Server=(DESKTOP-UNCLR0E); Database=tickets_prac; Integrated Security=true";
        }

        protected SqlConnection GetConnection() { 
            
            return new SqlConnection(_connectionString);
        }
    }
}
