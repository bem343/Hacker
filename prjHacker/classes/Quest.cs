using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace prjHacker.classes
{
	class Quest
	{
        private static List<Quest> _Currents = new List<Quest>();

        public int Index { get; set; }
        public int TipoProg { get; set; }
        public double CounterProg { get; set; }
		public double MaxProg { get; set; }
        public bool Completed { get; set; }

        public Quest(int Index)
        {
            this.Index = Index;
            this.TipoProg = 0;
			this.CounterProg = 0;
			this.MaxProg = 1;
			this.Completed = false;
        }
		public Quest(int Index, int TipoProg, double MaxProg)
		{
			this.Index = Index;
			this.TipoProg = TipoProg;
			this.CounterProg = 0;
			this.MaxProg = MaxProg;
			this.Completed = false;
		}

		public static void Start(int Index)
		{
			_Currents.Add(new Quest(Index));
		}
		public static void Start(Quest newQuest)
		{
			_Currents.Add(newQuest);
		}
		public static void Complete(int Index)
		{
			_Currents.Find(x => x.Index == Index).Completed = true;
		}
		public static bool Increment(int Index, double value = 1)
		{
			Quest quest = _Currents.Find(x => x.Index == Index);
			quest.CounterProg += value;

			bool completed = quest.CounterProg >= quest.MaxProg;
			if (completed) Complete(Index);
			return completed;
		}

		public static bool IsCurrent(int Index)
		{
			return !_Currents.Where(q => q.Index == Index).Select(q => q.Completed).SingleOrDefault();
		}
		public static int QuestIndex(int IndexList)
		{
			return _Currents.Where(q => q.Completed == false).Select(q => q.Index).ToList()[IndexList];
		}
		public static string QuestInfo(int Index, out double CounterProg, out double MaxProg)
		{
			string ProgFormatado(int Tipo, double Counter, double Max)
			{
				switch (Tipo)
				{
					case 1: return $"{Counter.ToString("F2")}/{Max.ToString("F2")}";
					default: return $"{(int)Counter}/{(int)Max}";
				}
			}

			Quest quest = _Currents.Find(q => q.Index == Index);
			CounterProg = quest.CounterProg;
			MaxProg = quest.MaxProg;

			return ProgFormatado(quest.TipoProg, CounterProg, MaxProg);
		}
	}
}
