using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGC.Core.Mathematica;

namespace TGC.Group.Model.AI
{
    class Platform : PatrolObject
    {
        private List<TGCVector3> positions;
        private int currentPosition = 0;

        public Platform(List<TGCVector3> newPositions) : base(newPositions)
        {
            positions = newPositions;
        }

        public void Update()
        {
            PatrolLogic();
        }
    }

}
