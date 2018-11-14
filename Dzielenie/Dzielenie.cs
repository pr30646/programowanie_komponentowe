using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dzielenie
{
	public class Dzielenie
	{
		public static string getPluginName()
		{
			return "podziel";
		}
		public static float podziel(float[] values)
		{
			float result = values[0];
			for (int i = 1; i < values.Length; i++)
			{
				result = result / values[i];
			}
			return result;
		}
	}
}
