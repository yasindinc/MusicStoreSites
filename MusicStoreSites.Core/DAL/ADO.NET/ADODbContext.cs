using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreSites.Core.DAL.ADO.NET
{
    public class ADODbContext
    {
        public SqlConnection connection { get; }
        public SqlCommand command { get; set; }
        public ADODbContext()
        {
            connection = new SqlConnection();
            command = new SqlCommand();
            command.Connection = connection;
        }
    }
}
