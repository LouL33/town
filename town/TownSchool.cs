using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace town
{
    class TownSchool
    {
        public string School { get; set; }
        public string BuildingType { get; set; }
        public int NumberOfRoom { get; set; }
        public string ConstructionMaterial { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public Double Length { get; set; }
        public Double SquareFootage { get { return Width * Length; } }
        public int Floor { get; set; }
        public int Classrooms { get; set; }
        public int BathRooms { get; set; }
        public Double Volume { get { return Width * Length * Height; } }
        public string FullAddress { get { return $"{Address1} {Address2} {City} {State} {Zip}"; } }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public Boolean InSession { get; set; }
        public int NumberOfTeachers { get; set; }

        public string TeacherStudentRatio()
        {
            return $"teacher[student]";
        }

        private int _CurrentOccupants;
        public int CurrentOccupants { get { return _CurrentOccupants; } }

        public void IncreaseOccupants()
        {
            this._CurrentOccupants++;
        }

        public void DecreaseOccupants()
        {
            this._CurrentOccupants++;
        }



    }
    }
