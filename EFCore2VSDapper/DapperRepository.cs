using Dapper;
using EFCore2VSDapper.Models;
using Microsoft.EntityFrameworkCore;
using NowMobRep.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace EFCore2VSDapper
{
    public class DapperRepository
    {
        public List<Authors> GetUsersWithDapper()
        {
            using (IDbConnection db = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=TestDB2;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                return db.Query<Authors>
                ($"select top 5000 * from Authors").ToList();

            }
        }
    }
}
