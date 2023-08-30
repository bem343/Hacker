using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace prjHacker.classes
{
    public class Script
    {
        public string language { get; set; }
        public string name { get; set; }
        public int linesP { get; set; } = 0;
        public List<string> lines { get; set; }

		public Script(string language, string name, int lines)
        {
            this.lines = new List<string>();
            this.language = language;
            this.name = name;
            geraLinhas(lines);
        }

        private void geraLinhas(int nLinhas)
        {
            XmlDocument arquivo = new XmlDocument(); arquivo.Load("lines.xml");
            XmlNodeList lines = arquivo.GetElementsByTagName("line");
            Random r = new Random();
            for (int i = 0; i < nLinhas; i++)
            {
                int nr = r.Next(lines.Count);
                this.lines.Add(lines[nr].InnerText);
            }
        }
    }
}
