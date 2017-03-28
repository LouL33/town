using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace town
{
    class TownBank
    {
        public string name { get; set; }
        
        public string BuildingType { get; set; }
        public int NumberOfRoom { get; set; }
        public string ConstructionMaterial { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public Double Length { get; set; }
        public Double SquareFootage { get { return Width * Length; } }
        public int Floors { get; set; }
        public int BathRooms { get; set; }
        public Double Volume { get { return Width * Length * Height; } }
        public string FullAddress { get { return $"{Address1} {Address2} {City} {State} {Zip}";  } }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        private int _CurrentOccupants;
        private Double _AmountOfMoney;
        public int CurrentOccupants { get { return _CurrentOccupants; } }
        private Double AmountOfMoney { get { return _AmountOfMoney; } }

        public void IncreaseOccupants()
        {
            this._CurrentOccupants++;
        }

        public void decreaseOccupants()
        {
            this._CurrentOccupants--;
        }
        //withdraw and deposite money
        public void DepositeOfMoney(double Amount)
        {
            this. _AmountOfMoney += Amount;
        }

        public void WithdrawMoney(double Amount)
        {
            this._AmountOfMoney -= Amount;
        }

        // constuctor

        public TownBank()
        {

        }

    }
}
