using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shklyarova.TestEntries;
using Abp.EntityFramework;

namespace Shklyarova.EntityFramework.Repositories
{
    public class TestEntryRepository : ShklyarovaRepositoryBase<TestEntry>, ITestEntryRepository
    {
        public TestEntryRepository(IDbContextProvider<ShklyarovaDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public List<TestEntry> GetAllEntries()
        {
            var query = GetAll();
            return query.ToList();
        }
    }
}