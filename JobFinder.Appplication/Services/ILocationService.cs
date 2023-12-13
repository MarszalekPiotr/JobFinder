﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinder.Application.Services
{
    public interface ILocationService
    {
        Task<LocationDTO> GetLocationAsync(Guid Id);
        Task AddLocationAsync(AddLocationDTO  location);
    }
}
