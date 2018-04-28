using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGC.Core.Mathematica;
using TGC.Core.SceneLoader;

namespace TGC.Group.Model.AI
{
    abstract class PatrolObject : TgcMesh
    {
        private List<TGCVector3> positions;
        private int currentPoint = 0;

        public void Update()
        {

        }

        public void PatrolLogic()
        {
            if (TGCVector3.Equals(Position, positions[currentPoint]))
            {
                currentPoint++;
            }
            if( currentPoint == positions.Count)
            {
                currentPoint = 0;
                positions.Reverse();
            }
            Move(positions[currentPoint]);
        }
    }
}
