using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.service
{
	public class FileUtil
	{
		public static string getFileName(string filePath)
		{
			return filePath.Split('\\').Last();
		}
	}
}
