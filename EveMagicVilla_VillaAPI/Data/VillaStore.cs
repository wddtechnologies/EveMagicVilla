using EveMagicVilla_VillaAPI.Models.Dto;

namespace EveMagicVilla_VillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO> {
            new VillaDTO { Id = 1,Name="Pool Side View",Sqft=100, Occupancy=4 },
            new VillaDTO { Id = 2,Name="Beach side View",Sqft=200, Occupancy=6 },
             new VillaDTO { Id = 3,Name="Tower Side View",Sqft=100, Occupancy=2  },
            new VillaDTO { Id = 4,Name=" Window side View",Sqft=300, Occupancy=6 }
        };
    }
}
