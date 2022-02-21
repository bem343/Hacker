using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMPLib;

namespace prjHacker.classes
{
    class Music
    {
        static WindowsMediaPlayer player = new WindowsMediaPlayer();

        public static void initPlayer()
        {
            player.settings.volume = 100;
            player.settings.setMode("loop", true);
            player.URL = "sounds/music/Dirty Ninoff - Fantastic.mp3";
            playMusic();
        }

        public static void playMusic()
        {
            player.controls.play();
        }

        public static void stopMusic()
        {
            player.controls.stop();
        }

        public static void pauseMusic()
        {
            player.controls.pause();
        }
    }
}
