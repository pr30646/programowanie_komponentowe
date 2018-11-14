using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potegowanie
{
    public class Potegowanie
    {
		public static string getPluginName()
		{
			return "poteguj";
		}
		public static float poteguj(float[] value)
		{
			return (float) Math.Pow((double)value[0], (double)value[1]);
		}
	}
}
