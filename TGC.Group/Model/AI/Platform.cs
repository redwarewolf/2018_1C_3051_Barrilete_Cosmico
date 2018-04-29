using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGC.Core.Mathematica;
using TGC.Core.SceneLoader;

namespace TGC.Group.Model.AI
{
    class Platform : PatrolObject
    {
        private TgcMesh objectMesh;
        private List<TGCVector3> positions;

        public Platform(List<TGCVector3> newPositions, TgcMesh theObjectsMesh) : base(newPositions, theObjectsMesh)
        {
            positions = newPositions;
            objectMesh = theObjectsMesh;
        }


    }
}
