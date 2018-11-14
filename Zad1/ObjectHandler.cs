using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
	class ObjectHandler
	{
		private static Assembly plugin;

		public static Assembly getPlugin()
		{
			return plugin;
		}

		public static void setPlugin(Assembly pluginToSet)
		{
			plugin = pluginToSet;
		}
	}
}
