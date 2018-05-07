using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGC.Core.Mathematica;
using TGC.Core.SceneLoader;
using TGC.Core.Collision;

namespace TGC.Group.Model.AI
{
    class Plataforma 
    {
        private TgcMesh plataformaMesh;
        private Escenario escenario;

        public Plataforma(TgcMesh plataformaMesh, Escenario escenario)
        {
            this.plataformaMesh = plataformaMesh;
            this.escenario = escenario;
        }

        public virtual void Update()
        {
            
        }


    }
}
