using System;

namespace Tm.Instech.Data
{
    public enum InstClaimType
    {
        Collision,
        Grounding,
        BadWeather,
        Fire
    }

    public class InstClaim
    {
        public Guid Id { get; set; }
        public int Year { get; set; }
        public string? Name { get; set; }
        public InstClaimType Type { get; set; }
        public decimal DamageCost { get; set; }
    }
}
