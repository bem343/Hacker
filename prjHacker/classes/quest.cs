using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjHacker.classes
{
    static class quest
    {
        public static string name = "";
        public static string instruction = "";
        public static bool currentNow = false;
        public static int current = 0;

        public static void start(string vName, string vInstuction)
        {
            name = vName;
            instruction = vInstuction;
            currentNow = true;
            current++;
        }
        public static void complete()
        {
            name = "";
            instruction = "";
            currentNow = false;
        }
    }
}
