using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlatformService.Models;

namespace PlatformService.Data
{
    public interface IPlatformRepo
    {
        IEnumerable<Platform> GetAllPlatform();
        Platform GetPlatformById(int id);
        void CreatePlatform(Platform plat);
        bool SaveChanges();
    }
}