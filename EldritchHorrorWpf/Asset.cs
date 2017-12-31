using System.Collections.Generic;

namespace EldritchHorrorWpf
{
    class Asset : Card
    {
        private int Cost;

        public Asset(string name, List<string> traits, int cost) : base(name, traits)
        {
            Cost = cost;
        }
    }
}
