using JobFinder.Application.DTOs.CreatingJobDTO;
using JobFinder.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinder.Application.Mappers
{
    public interface ILocationMapper
    {
        IEnumerable<Location> Map(LocationFromFormDTO location);
        IEnumerable<LocationFromFormDTO> Map(Location location);
    }
}
