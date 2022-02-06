using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using prjHacker.forms;

namespace prjHacker.classes
{
    static class play
    {
        private static SoundPlayer c = new SoundPlayer();
        private static SoundPlayer k = new SoundPlayer();
        private static SoundPlayer s = new SoundPlayer();

        public static void click()
        {
            c.SoundLocation = "sounds/click" + frmConfiguracoes.volume + ".wav";
            if (frmConfiguracoes.som) { c.Play(); }
        }
        public static void select()
        {
            s.SoundLocation = "sounds/select.wav";
            if (frmConfiguracoes.som) { s.Play(); }
        }
        public static void key()
        {
            if (frmConfiguracoes.som)
            {
                Random r = new Random();
                k.SoundLocation = "sounds/key/" + frmConfiguracoes.volume + "/" + r.Next(1, 5) + ".wav";
                k.Play();
            }
        }
    }
}
