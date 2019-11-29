using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_MakeHouse
{
    class RoomWithDoor : Room, IHasExteriorDoor
    {
        // DoorLocation 속성
        public Location DoorLocation { get; set; }
        // 읽기 전용 DoorDescription
        public string DoorDescription { get; private set; }
        public RoomWithDoor(string name, string decoration, string doorDescription)
            : base(name,  decoration)
        {
            this.DoorDescription = doorDescription;
        }
    }
}
