using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjHacker.classes
{
	class LanguageClass
	{
		private static List<LanguageClass> _Purchased = new List<LanguageClass>();
		
		public int Index { get; set; }
		public bool Finished { get; set; }

		public LanguageClass(int Index)
		{
			this.Index = Index;
			this.Finished = false;
		}

		public static void Finish(int Index)
		{
			_Purchased.Find(x => x.Index == Index).Finished = true;
		}
		public static void Purchase(int Index)
		{
			_Purchased.Add(new LanguageClass(Index));
		}
		public static bool IsAvaialable(int Index)
		{
			return !_Purchased.Exists(c => c.Index == Index);
		}
		public static bool IsPurchased(int Index)
		{
			return _Purchased.Count(c => c.Index == Index && !c.Finished) > 0;
		}
		public static bool IsFinished(int Index)
		{
			return _Purchased.Count(c => c.Index == Index && c.Finished) > 0;
		}
	}
}
