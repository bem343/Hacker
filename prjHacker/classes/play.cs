using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using prjHacker.forms;
using WMPLib;

namespace prjHacker.classes
{
    static class play
    {
        private static WindowsMediaPlayer c = new WindowsMediaPlayer();
        private static WindowsMediaPlayer k = new WindowsMediaPlayer();
        private static WindowsMediaPlayer s = new WindowsMediaPlayer();

        public static void click()
        {
            if (frmConfiguracoes.som)
            {
                c.settings.volume = frmConfiguracoes.volume;
                c.URL = "sounds/click5.wav";
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
                k.URL = "sounds/key/5/" + r.Next(1, 5) + ".wav";
            }
        }
    }
}
