using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.model;
using ConsoleApplication1.service;


namespace ConsoleApplication1.Controller
{
	public class LpDataController
	{
		public static void LPDataProcessing(List<string> filePaths)
		{
			var lpFiles = filePaths.Where(x => x.Contains("LP")).ToList();
			foreach (var file in lpFiles)
			{
				List<LpDataItem> lpDataRecs = new LpFileReader().Read(file);
				double lpMedian = CalcUtility.getMedianLp(lpDataRecs);
				var listOfRecordsToWrite = ConsoleWriter.GetListOfLpRecordsToWrite(lpDataRecs, lpMedian);
				ConsoleWriter.WriteLpData(lpDataRecs, lpMedian, FileUtil.getFileName(file));
			}
		}
	}
}
