using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using prjHacker.forms;
using System.Windows.Forms;

namespace prjHacker.classes
{
    static class Vpn
    {
        private static Timer timer = null;
        public static int time = 0;
        public static int maximum = 0;
        public static bool isActive = false;

        public static void sign(int vMaximum)
        {
            isActive = true;
            maximum = vMaximum;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += vpn_Tick;
        }
        private static void vpn_Tick(object sender, EventArgs e)
        {
            if (time == maximum)
            {
                time = 0;
                timer.Stop();
                isActive = false;
            }
            time++;
        }
        public static void start() { timer.Start(); }
        public static void stop() { timer.Stop(); }
    }
}
