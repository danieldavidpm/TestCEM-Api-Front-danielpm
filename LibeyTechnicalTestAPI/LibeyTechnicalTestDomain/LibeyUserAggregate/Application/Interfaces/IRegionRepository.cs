﻿using LibeyTechnicalTestDomain.LibeyUserAggregate.Domain;

namespace LibeyTechnicalTestDomain.LibeyUserAggregate.Application.Interfaces
{
    public interface IRegionRepository
    {
        IEnumerable<Region> GetAll();
    }
}