using BenchmarkDotNet.Attributes;
using NowMobRep.Models;
using System.Collections.Generic;

namespace EFCore2VSDapper
{
    public class EFCore2VsDapper
    {
        EFRepository _EFRepo;
        DapperRepository _DapperRepo;
        ADORepository _adoRepository;

        public EFCore2VsDapper()
        {
            _EFRepo = new EFRepository();
            _DapperRepo = new DapperRepository();
            _adoRepository = new ADORepository();
        }

        [Benchmark]
        public List<Authors> GetUsersWithEntityFramework() => _EFRepo.GetUsersWithEF();

        [Benchmark]
        public List<Authors> GetUsersWithDapper() => _DapperRepo.GetUsersWithDapper();

        //[Benchmark]
        //public List<UsersGeneral> GetUsersWithADO() => _adoRepository.GetUsersWithADO();
    }
}
