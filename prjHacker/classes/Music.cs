using System;
using System.Collections.Generic;
using System.IO;
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
            IWMPPlaylist playlist = player.playlistCollection.newPlaylist("OST");
            IWMPMedia media;

            string[] music_paths = Directory.GetFiles("sounds/music");

            foreach (string file in music_paths)
            {
                media = player.newMedia(file.Replace("\\", "/"));
                playlist.appendItem(media);
            }

            player.settings.volume = 100;
            player.settings.setMode("loop", true);
            player.currentPlaylist = playlist;
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

        public static void increaseVolume()
        {
            player.settings.volume += 20;
        }

        public static void decreaseVolume()
        {
            player.settings.volume -= 20;
        }

        public static void nextMusic()
        {
            player.controls.next();
        }
    }
}
