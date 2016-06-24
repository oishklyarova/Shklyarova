using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shklyarova.TestEntries.Dtos;
using AutoMapper;

namespace Shklyarova.TestEntries
{
    public class TestEntryService : ApplicationService, ITestEntryService
    {
        private readonly ITestEntryRepository _testEntryRepository;

        public TestEntryService(ITestEntryRepository testEntryRepository)
        {
            _testEntryRepository = testEntryRepository;
        }

        public List<TestEntry> GetEntries()
        {
            var testEntries = _testEntryRepository.GetAllEntries();

            /*try
            {
                return new GetEntriesOutput
                {
                    TestEntries = Mapper.Map<List<TestEntryDto>>(testEntries)
                };
            }
            catch (AutoMapperMappingException autoMapperException)
            {
                throw autoMapperException.InnerException;
                // this will break your call stack
                // you may not know where the error is called and rather
                // want to clone the InnerException or throw a brand new Exception
            }*/
            return testEntries;
        }

        public void CreateEntry(CreateEntryInput input)
        {
            var testEntry = new TestEntry { SomeText = input.SomeText, dtEntry = DateTime.Now };

            _testEntryRepository.Insert(testEntry);
        }
    }
}