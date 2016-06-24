using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shklyarova.TestEntries.Dtos
{
    public class CreateEntryInput : IInputDto
    {
        [Required]
        public string SomeText { get; set; }
    }
}