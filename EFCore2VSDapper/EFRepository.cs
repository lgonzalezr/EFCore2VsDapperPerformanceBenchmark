using EFCore2VSDapper.Models;
using Microsoft.EntityFrameworkCore;
using NowMobRep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCore2VSDapper
{
    public class EFRepository
    {
        public List<Authors> GetUsersWithEF()
        {
            using (var db = new EFCore2TestContext())
            {
                return db.Authors.FromSqlRaw("Select top 5000 * from Authors").AsNoTracking().ToList();
                //return db.UsersGeneral.Take(5000).AsNoTracking().ToList();
            }
        }
    }
}
