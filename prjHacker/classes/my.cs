using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjHacker.classes
{
    static class my
    {
        private static List<script> scripts = new List<script>();
        private static int selectedScript = -1;
        public static double lost = 0;

        public static void scriptsAdd(script script)
        {
            scripts.Add(script);
        }

        public static void scriptsRemove()
        {
            scripts.RemoveAt(selectedScript);
            selectedScript = -1;
        }

        public static script currentScript()
        {
            return scripts[selectedScript];
        }

        public static void selectScript(int index)
        {
            selectedScript = index;
        }

        public static List<string> scriptNames()
        {
            List<string> names = new List<string>();
            foreach (script item in scripts){
                names.Add(item.name);
            } return names;
        }
    }
}
