using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Application.DTO
{
    public record RegionResponses
    {
        public string? RegionCode { get; set; }
        public string? RegionDescription { get; set; }
    }
}
