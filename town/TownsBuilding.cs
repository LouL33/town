using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace town
{
    class TownsBuilding
    {
        public string Name { get; set;}
        public string BuildingTtype { get; set; }
        public int NumberOfRooms { get; set; }
        public string ConstructionMaterial { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public Double Length { get; set; }
        public Double SquareFootage { get { return Width * Length; } }
        public int Floors { get; set; }
        public int BedRooms { get; set; }
        public int BathRooms { get; set; }
        public Double Volume { get { return Width * Length * Height; } }
        public string FullAddress { get { return $"{Address1} {Address2} {City} {State}, {Zip}"; } }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        private int _CurrentOccupants;
        public int CurrentOccupants { get { return _CurrentOccupants; } }
        //increase Occupants
        public void IncreaseOccupants()
        {
            this._CurrentOccupants++;
        }
        // decrease Occupants
        public void decreaseOccupants()
        {
            this._CurrentOccupants--;
        }

        public string Displayname()
        {
            return Name;
        }
        public override string ToString()
        {
            return $"house; {this.Name}";
        }

        // constructoer
        public TownsBuilding()
        {

        }
        
    }
}
