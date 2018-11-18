using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Zad1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			LoadPlugins();
		}

		private void Save_Click(object sender, EventArgs e)
		{
		}

		private void Read_Click(object sender, EventArgs e)
		{
		}
		private void LoadPlugins()
		{
			string[] files = Directory.GetFiles(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, "*.dll", SearchOption.AllDirectories);
			string[] distinctFiles = files.Distinct().ToArray();
			foreach (string myFilename in distinctFiles)
			{
				Assembly plugin = Assembly.LoadFrom(myFilename);
				foreach (Type item in plugin.GetTypes())
				{ //lista klas
					foreach (MethodInfo method in item.GetMethods())
					{
						if (method.Name != "Equals" && method.Name != "GetHashCode" && method.Name != "getPluginName" && method.Name != "ToString" && method.Name != "GetType")
						{
							Operacja.DropDownItems.Add(new ToolStripMenuItem(method.Name, null, (sender, e) =>
							 MenuHandler(sender, e, plugin.GetName().Name), method.Name));
						}
					}
				}
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void submitName_Click(object sender, EventArgs e)
		{

		}
		private void MenuHandler(object sender, EventArgs e, string pluginName)
		{
			operationTypeLabel.Text = pluginName;
			ToolStripMenuItem item = (ToolStripMenuItem)sender;
			Assembly plugin = Assembly.LoadFrom(new FileInfo(pluginName + ".dll").FullName);
			ObjectHandler.setPlugin(plugin);
			
		}

		private void Result_Click(object sender, EventArgs e)
		{
			float val1f;
			float val2f;
			float.TryParse(val1.Text, out val1f);
			float.TryParse(val2.Text, out val2f);
			float[] values = { val1f, val2f };
			Assembly plugin = ObjectHandler.getPlugin();
			foreach (Type type in plugin.GetTypes())
			{
				MethodInfo infoMethod = type.GetMethod("getPluginName");
				object methodName = null;
				if (infoMethod != null)
				{
					methodName = infoMethod.Invoke(null, new object[] { });
					MethodInfo pluginMethod = type.GetMethod((string)methodName);
					if (pluginMethod != null)
					{
						float res = (float)pluginMethod.Invoke(null, new object[] { values });
						resultLabel.Text = res.ToString();
					}
				}
			}
		}
	}
}
