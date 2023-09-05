using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using prjHacker.forms;
using WMPLib;

namespace prjHacker.classes
{
    static class Sound
    {
        private static WindowsMediaPlayer c = new WindowsMediaPlayer();
        private static WindowsMediaPlayer k = new WindowsMediaPlayer();
        private static WindowsMediaPlayer s = new WindowsMediaPlayer();
        private static WindowsMediaPlayer h = new WindowsMediaPlayer();
        private static WindowsMediaPlayer f = new WindowsMediaPlayer();
        private static WindowsMediaPlayer co = new WindowsMediaPlayer();
        private static WindowsMediaPlayer con = new WindowsMediaPlayer();

        private static void play(WindowsMediaPlayer player, string url)
        {
            if (frmConfiguracoes.som)
            {
                player.settings.volume = frmConfiguracoes.volume;
                player.URL = url;
            }
        }
        public static void click()
        {
            play(c, "sounds/click.wav");
        }
        public static void select()
        {
            play(s, "sounds/select.wav");
        }
        public static void key()
        {
            Random r = new Random();
            play(k, "sounds/key/" + r.Next(1, 5) + ".wav");
        }
        public static void hacking(bool play = true)
        {
            if (!play)
            {
                h.controls.stop();
                return;
            }
            if (frmConfiguracoes.som)
            {
                h.settings.volume = frmConfiguracoes.volume;
                h.settings.setMode("loop", true);
                h.URL = "sounds/hacking.wav";
            }
        }
        public static void fail()
        {
            play(f, "sounds/fail.wav");
        }
        public static void complete()
        {
            play(co, "sounds/complete.wav");
        }
        public static void congrats()
        {
            play(con, "sounds/congrats.wav");
        }
    }
}
