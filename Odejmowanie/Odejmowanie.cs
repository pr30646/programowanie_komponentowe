using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odejmowanie
{
    public class Odejmowanie
    {
		public static string getPluginName()
		{
			return "odejmij";
		}
		public static float odejmij(float[] values)
		{
			float result = values[0];
			for (int i = 1; i < values.Length; i++)
			{
				result = result - values[i];
			}
			return result;
		}
	}
}
