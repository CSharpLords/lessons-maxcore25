using System;

namespace AsianCuisine.Model
{
    class Country
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Flag { get; set; }

        public override string ToString()
        {
            return $"{ID}, {Name}, {Flag}";
        }
    }
}
