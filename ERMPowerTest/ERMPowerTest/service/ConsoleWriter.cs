using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApplication1.model;

namespace ConsoleApplication1.service
{
	public class ConsoleWriter
	{
		public static List<LpDataItem> GetListOfLpRecordsToWrite(List<LpDataItem> dataItems, double medianValue)
		{
			return dataItems.Where(x => x.DataValue > (medianValue * 1.2) || x.DataValue < (medianValue *0.8)).ToList() ;
		}


		public static void WriteLpData(List<LpDataItem> dataItems, double medianValue, string fileName)
		{
			dataItems.ForEach(item => Console.WriteLine(fileName + " " + item.DateTime + " " + item.DataValue + " " + medianValue));
		}

		public static List<TouDataItem> GetListOfTouRecordsToWrite(List<TouDataItem> dataItems, double medianValue)
		{
			return dataItems.Where(x => x.Energy > (medianValue * 1.2) || x.Energy < (medianValue * 0.8)).ToList();
		}


		public static void WriteTouData(List<TouDataItem> dataItems, double medianValue, string fileName)
		{
			dataItems.ForEach(item => Console.WriteLine(fileName + " " + item.DateTime + " " + item.Energy + " " + medianValue));
		}
	}

	
}
