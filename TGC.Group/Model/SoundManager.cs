using Microsoft.DirectX.DirectInput;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TGC.Core.Sound;
using TGC.Core.Text;

namespace TGC.Group.Model
{
    public class SoundManager
    {
        private static TgcDirectSound DirectSound = new TgcDirectSound();
        private TgcMp3Player mp3BackgroundPlayer = new TgcMp3Player();
        private static Directorio Directorio { get; set; }

        private static TgcStaticSound SonidoCaminar = new TgcStaticSound();
        private static TgcStaticSound SonidoSalto = new TgcStaticSound();

        private TgcMp3Player mp3SaltosPlayer = new TgcMp3Player();

        private TgcStaticSound pasoIzq = new TgcStaticSound();
        private TgcStaticSound pasoDer = new TgcStaticSound();

        private Boolean esPasoIzquierdo;
        private DateTime tiempoCordinacionCaminar;

        public SoundManager(Directorio directorio,Microsoft.DirectX.DirectSound.Device dsDevice)
        {
            Directorio = directorio;

            //Cargo archivo de sonido background mp3.
            mp3BackgroundPlayer.closeFile();
            mp3BackgroundPlayer.FileName = directorio.SonidoFondo;

            //Cargo sonidos estaticos.
            SonidoSalto.loadSound(directorio.SonidoSalto, dsDevice);
            SonidoCaminar.loadSound(directorio.SonidoCaminar, dsDevice);

            pasoDer.loadSound(directorio.SonidoCaminarDer, dsDevice);
            pasoIzq.loadSound(directorio.SonidoCaminarIzq, dsDevice);

            //mp3SaltosPlayer.closeFile();
            //mp3SaltosPlayer.FileName = directorio.SonidoSalto;
        }

        public void playSonidoCaminar2()
        {
            //mp3PasosPlayer.play(true);
            SonidoCaminar.play();
        }

        public void playSonidoCaminar()
        {
            DateTime tiempoSonido = DateTime.Now;

            // se pone esto con el objetivo de que no se pisen los sonidos, sino que antes de ejecutarse espere a que el otro sonido(el del otro paso) termine
            if ((tiempoSonido.Millisecond - tiempoCordinacionCaminar.Millisecond) > 500 || (tiempoSonido.Second != tiempoCordinacionCaminar.Second))
            {
                if (esPasoIzquierdo)
                {
                    pasoIzq.play();
                    esPasoIzquierdo = false;

                }
                else
                {
                    pasoDer.play();
                    esPasoIzquierdo = true;
                }

                tiempoCordinacionCaminar = DateTime.Now;
            }
        }

        public void stopSonidoCaminar()
        {
            SonidoCaminar.stop();
        }

        public void playSonidoSaltar()
        {
            //mp3SaltosPlayer.play(true);
            SonidoSalto.play(false);
        }

        public void playSonidoFondo()
        {
            mp3BackgroundPlayer.play(true);
        }

        public void dispose()
        {
           // SonidoCaminar.dispose();
        }
    }
}
