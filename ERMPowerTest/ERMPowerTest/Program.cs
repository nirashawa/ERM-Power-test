using System;
using System.IO;
using System.Linq;
using ConsoleApplication1.Controller;

namespace ConsoleApplication1
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Working
			var basefilePath = System.Configuration.ConfigurationSettings.AppSettings.Get("ApplicationPath");

			var filePaths = Directory.GetFiles(basefilePath, "*_*.csv").ToList();
			LpDataController.LPDataProcessing(filePaths);
			TouDataController.TouDataProcessing(filePaths);

			#endregion

			Console.ReadLine();
		}

		
	}
}
