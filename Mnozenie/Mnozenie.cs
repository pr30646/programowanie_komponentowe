using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mnozenie
{
    public class Mnozenie
    {
		public static string getPluginName()
		{
			return "pomnoz";
		}
		public static float pomnoz(float[] values)
		{
			float result = values[0];
			for (int i = 1; i < values.Length; i++)
			{
				result = result * values[i];
			}
			return result;
		}
	}
}
