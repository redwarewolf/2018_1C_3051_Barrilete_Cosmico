using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGC.Group.Model.AI
{
    class Platform : PatrolObject
    {
        public void Update()
        {
            PatrolLogic();
        }
    }

}
