using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dodawanie
{
    public class Dodawanie
    {
		public static string getPluginName()
		{
			return "dodaj";
		}
		public static float dodaj(float[] values)
		{
			return values.Sum();
		}
	}
}
