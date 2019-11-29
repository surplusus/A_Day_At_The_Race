using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_MakeHouse
{
    class Outside : Location
    {
        private bool Hot;
        public Outside(string name, bool isHot)
            : base(name)
        {
            this.Hot = isHot;
        }
        public override string Description
        {
            get
            {
                string newDescription = base.Description;
                if (Hot)
                    newDescription += " It's very hot.";
                return newDescription;
            }
        }
    }
}
