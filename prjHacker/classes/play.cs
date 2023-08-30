using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using prjHacker.forms;
using WMPLib;

namespace prjHacker.classes
{
    static class Play
    {
        private static WindowsMediaPlayer c = new WindowsMediaPlayer();
        private static WindowsMediaPlayer k = new WindowsMediaPlayer();
        private static WindowsMediaPlayer s = new WindowsMediaPlayer();
        public static WindowsMediaPlayer h = new WindowsMediaPlayer();
        private static WindowsMediaPlayer f = new WindowsMediaPlayer();
        private static WindowsMediaPlayer co = new WindowsMediaPlayer();
        private static WindowsMediaPlayer con = new WindowsMediaPlayer();

        public static void click()
        {
            if (frmConfiguracoes.som)
            {
                c.settings.volume = frmConfiguracoes.volume;
                c.URL = "sounds/click.wav";
            }
        }
        public static void select()
        {
            if (frmConfiguracoes.som)
            {
                s.settings.volume = frmConfiguracoes.volume;
                s.URL = "sounds/select.wav";
            }
        }
        public static void key()
        {
            if (frmConfiguracoes.som)
            {
                Random r = new Random();
                k.settings.volume = frmConfiguracoes.volume;
                k.URL = "sounds/key/" + r.Next(1, 5) + ".wav";
            }
        }
        public static void hacking()
        {
            if (frmConfiguracoes.som)
            {
                h.settings.volume = frmConfiguracoes.volume;
                h.settings.setMode("loop", true);
                h.URL = "sounds/hacking.wav";
            }
        }
        public static void fail()
        {
            if (frmConfiguracoes.som)
            {
                f.settings.volume = frmConfiguracoes.volume;
                f.URL = "sounds/fail.wav";
            }
        }
        public static void complete()
        {
            if (frmConfiguracoes.som)
            {
                co.settings.volume = frmConfiguracoes.volume;
                co.URL = "sounds/complete.wav";
            }
        }
        public static void congrats()
        {
            if (frmConfiguracoes.som)
            {
                con.settings.volume = frmConfiguracoes.volume;
                con.URL = "sounds/congrats.wav";
            }
        }
    }
}
