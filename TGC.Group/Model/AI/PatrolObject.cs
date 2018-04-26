using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGC.Core.Mathematica;

namespace TGC.Group.Model.AI
{
    abstract class PatrolObject
    {
        private List<TGCVector3> positions;
        private int currentPoint = 0;

        public void Update()
        {

        }

        public void PatrolLogic()
        {
            if (TGCVector3.Equals(CurrentPosition(), positions[currentPoint]))
            {
                currentPoint++;
            }
            if( currentPoint == positions.Count)
            {
                currentPoint = 0;
                positions.Reverse();
            }
            MoveTo(positions[currentPoint]);
        }

        void MoveTo(TGCVector3 direction)
        {

        }

        private TGCVector3 CurrentPosition()
        {
            return new TGCVector3();
        }
    }
}
