using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;

namespace Shklyarova.TestEntries
{
    public class TestEntry : Entity
    {
        public virtual string SomeText { get; set; }
        public virtual DateTime dtEntry { get; set; }
    }
}
