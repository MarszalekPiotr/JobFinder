using JobFinder.Application.DTOs.CreatingJobDTO;
using JobFinder.Application.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinder.Infrastructure.Mappers
{
    public class LocationMapper : ILocationMapper
    {
        public IEnumerable<Location> Map(LocationFromFormDTO location)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LocationFromFormDTO> Map(Location location)
        {
            throw new NotImplementedException();
        }
    }
}
