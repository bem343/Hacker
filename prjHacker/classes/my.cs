using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjHacker.classes
{
    static class my
    {
        public static List<script> scripts = new List<script>();
        public static script selectedScript = null;

        public static void selecionarScript(int index)
        {
            selectedScript = scripts[index];
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
