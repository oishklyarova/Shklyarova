using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shklyarova.TestEntries
{
    public interface ITestEntryRepository : IRepository<TestEntry>
    {
        List<TestEntry> GetAllEntries();
    }
}