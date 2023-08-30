using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjHacker.classes
{
    static class My
    {
        private static List<Script> scripts = new List<Script>();
        private static int selectedScript = -1;
        public static double lost = 0;

        public static void scriptsAdd(Script script)
        {
            scripts.Add(script);
        }

        public static void scriptsRemove()
        {
            scripts.RemoveAt(selectedScript);
            selectedScript = -1;
        }

        public static Script currentScript()
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
            foreach (Script item in scripts){
                names.Add(item.name);
            } return names;
        }
    }
}
