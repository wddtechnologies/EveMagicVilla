﻿namespace EveMagicVilla_VillaAPI.Models.Dto
{
    public class VillaDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public double Rate { get; set; }
        public int Occupancy {  get; set; }
        public int Sqft {  get; set; }
        public string ImageUrl { get; set; }
        public string Anemity { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}
