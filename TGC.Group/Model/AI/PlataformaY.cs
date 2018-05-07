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
    class PlataformaY : Plataforma
    {
        private int toleranciaLimiteSuperior = 10;
        private TgcMesh plataformaMesh;
        private Escenario escenario;
        private TGCVector3 posicionInicial;
        private TGCVector3 vectorMovimiento = new TGCVector3(0, -1, 0); //Solo moveriamos en Y a las plataformas.

        public PlataformaY(TgcMesh plataformaMesh, Escenario escenario) : base(plataformaMesh, escenario)
        {
            this.plataformaMesh = plataformaMesh;
            this.posicionInicial = plataformaMesh.Position;
            this.escenario = escenario;
        }

        public override void Update()
        {

            TGCVector3 posicionSiguiente = plataformaMesh.Position + vectorMovimiento;

            //Si la plataforma colisiona con el piso, cambiamos el sentido de movimiento.
            if (escenario.colisionaConPiso(plataformaMesh)) vectorMovimiento.Multiply(-1);

            //Si la plataforma supera en una cierta cantidad de veces a su altura inicial, cambiamos el sentido de movimiento.
            if (posicionSiguiente.Y >= toleranciaLimiteSuperior * posicionInicial.Y) vectorMovimiento.Multiply(-1);

            //Desplazamos la plataforma en el sentido correcto.
            plataformaMesh.Move(vectorMovimiento);
        }

    }
}
