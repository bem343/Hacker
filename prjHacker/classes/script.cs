using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjHacker.classes
{
    class script
    {
        public string language { get; set; }
        public string name { get; set; }
        public int lines { get; set; }

        public script(string language, string name, int lines)
        {
            this.language = language;
            this.name = name;
            this.lines = lines;
        }
    }
}
