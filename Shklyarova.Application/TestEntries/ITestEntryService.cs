using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shklyarova.TestEntries.Dtos;

namespace Shklyarova.TestEntries
{
    public interface ITestEntryService : IApplicationService
    {
        List<TestEntry> GetEntries();
        void CreateEntry(CreateEntryInput input);
    }
}