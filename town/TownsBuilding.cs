using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace town
{
    class TownsBuilding
    {
        public string Name { get; set; }
        
        public string Displayname()
        {
            return Name;
        }
        public override string ToString()
        {
            return $"house; {this.Name}";
        }
    }
}
