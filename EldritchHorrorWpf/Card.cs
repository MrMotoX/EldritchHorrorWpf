using System.Collections.Generic;

namespace EldritchHorrorWpf
{
    class Card
    {
        private string Name;
        private List<string> Traits;

        public Card(string name, List<string> traits)
        {
            Name = name;
            Traits = traits;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
