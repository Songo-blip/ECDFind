using FindECD.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FindECD.Services
{
    public interface ILocation
    {
        System.Threading.Tasks.Task<List<LocationModel>> getlocations();

    }
}