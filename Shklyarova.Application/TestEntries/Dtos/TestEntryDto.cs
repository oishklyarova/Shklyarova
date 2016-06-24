using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shklyarova.TestEntries.Dtos
{
    public class TestEntryDto : EntityDto
    {
        public string SomeText { get; set; }
        public DateTime dtEntry { get; set; }
    }
}