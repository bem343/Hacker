using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WMPLib;
using prjHacker.forms;

namespace prjHacker.classes
{
    class Music
    {
        static WindowsMediaPlayer player = new WindowsMediaPlayer();

        public static void initPlayer()
        {
            //IWMPPlaylist playlist = player.playlistCollection.newPlaylist("OST");
            //IWMPMedia media;

            //string[] music_paths = Directory.GetFiles("sounds/music");

            //foreach (string file in music_paths)
            //{
            //    media = player.newMedia(file.Replace("\\", "/"));
            //    playlist.appendItem(media);
            //}
            //player.currentPlaylist = playlist;

            player.settings.volume = 50;
            player.settings.setMode("loop", true);
            play("# (5).mp3");
        }

        //public static void next()
        //{
        //    player.controls.next();
        //}

        public static void play()
        {
            if (frmConfiguracoes.som)
            { player.controls.play(); }
            else { pause(); }
        }

        public static void play(string name)
        {
            if (frmConfiguracoes.som)
            { player.URL = "sounds/music/" + name; }
        }

        public static void stop()
        {
            player.controls.stop();
        }

        public static void pause()
        {
            player.controls.pause();
        }

        public static void increaseVolume()
        {
            player.settings.volume += 10;
        }

        public static void decreaseVolume()
        {
            player.settings.volume -= 10;
        }

    }
}
