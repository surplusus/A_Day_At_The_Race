using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_MakeHouse
{
    class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        public OutsideWithDoor(string name, bool isHot, string doorDescription)
            : base(name, isHot)
        {
            this.DoorDescription = doorDescription;
        }
        // DoorLocation 속성
        public Location DoorLocation { get; set; }
        // 읽기 전용 DoorDescription 속성
        public string DoorDescription { get; private set; }
        public override string Description
        {
            get
            {
                return base.Description + " You see " + DoorDescription + ".";
            }
        }
    }
}
