﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WellSpring.Core.Model;

namespace WellSpring.Core.Interfaces
{
    public interface ILocationsDatabase
    {
        Task<IEnumerable<Location>> GetLocations();

        Task<int> DeleteLocation(object id);

        Task<int> InsertLocation(Location location);
        Task<int> InsertLocation(LocationAutoCompleteResult location);

        Task<bool> CheckIfExists(Location location);
        Task<bool> CheckIfExists(LocationAutoCompleteResult location);


    }
}
