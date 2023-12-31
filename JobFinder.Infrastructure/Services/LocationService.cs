﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinder.Infrastructure.Services
{
    internal class LocationService : ILocationService
    {
        private readonly IRepositoryCollection _repositoryCollection;
        public LocationService(IRepositoryCollection repositoryCollection) => _repositoryCollection = repositoryCollection; 

        public async Task AddLocationAsync(AddLocationDTO dto)
        {
            var location = new Location()
            {
                Name = dto.Name,
                X = dto.X,
                Y = dto.Y,

            };

            await _repositoryCollection._locationRepository.AddAsync(location);
        }

        public async Task<LocationDTO> GetLocationAsync(Guid Id)
        {
            var location = await _repositoryCollection._locationRepository.GetByIdAsync(Id);
            return new LocationDTO()
            {
                Name = location.Name,
                X = location.X,
                Y = location.Y
            };
        }
    }
}
