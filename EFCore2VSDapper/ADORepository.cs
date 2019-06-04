using NowMobRep.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace EFCore2VSDapper
{
    public class ADORepository
    {
        public List<Authors> GetUsersWithADO()
        {
            using (var conn = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=TestDB2;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                var sql = "select top 5000 * from Authors";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        var resultTable = new DataTable();
                        adapter.Fill(resultTable);

                        return (from DataRow dr in resultTable.Rows
                                           select new Authors()
                                           {
                                               Id = Convert.ToInt32(dr["Id"]),
                                               Name = dr["Name"].ToString(),
                                               Country = dr["Country"].ToString()
                                           }).ToList();
                    }
                }
            }
        }
    }
}
