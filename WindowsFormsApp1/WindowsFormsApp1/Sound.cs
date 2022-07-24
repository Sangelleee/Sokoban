using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace WindowsFormsApp1
{
    class Sound
    {
        static SoundPlayer moveSound =
            new SoundPlayer(Properties.Resources.uverennyiy_shag);
        static SoundPlayer victorySound =
            new SoundPlayer(Properties.Resources.pobeda);
        private static bool flagMoveSound = true;

        public static void MoveSoundPlay()
        {
            if(flagMoveSound)
            moveSound.Play();
        }

        internal static void MoveSoundPlayON()
        {
            flagMoveSound = true;
        }

        internal static void MoveSoundPlayOFF()
        {
            flagMoveSound = false;
        }

        internal static void VictorySoundPlay()
        {
            if (flagMoveSound)
                victorySound.Play();
        }
    }
}
