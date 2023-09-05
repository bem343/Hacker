using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjHacker.classes
{
    static class MyScripts
    {
        private static List<Script> collection = new List<Script>();
        private static int selected = -1;
        public static double lost = 0;

        public static void Add(Script script)
        {
            collection.Add(script);
        }

        public static void Remove()
        {
            collection.RemoveAt(selected);
            selected = -1;
        }

        public static Script Current()
        {
            return collection[selected];
        }

        public static void Select(int index)
        {
            selected = index;
        }

        public static List<string> Names()
        {
            List<string> names = new List<string>();
            foreach (Script item in collection){
                names.Add(item.name);
            } return names;
        }
    }
}
