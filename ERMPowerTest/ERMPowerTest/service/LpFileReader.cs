using System;
using System.Collections.Generic;
using ConsoleApplication1.model;
using System.IO;

namespace ConsoleApplication1.service
{
	public class LpFileReader
	{
		public List<LpDataItem> Read(string filePath)
		{
			List<LpDataItem> dataRows = new List<LpDataItem>();
			bool isFirstItem = true;
			StreamReader reader = new StreamReader(File.OpenRead(filePath));
			while (!reader.EndOfStream)
			{
				string line = reader.ReadLine();
				string[] fieldValues = line.Split(',');

				if (isFirstItem)
				{
					isFirstItem = false;
					continue;
				}

				LpDataItem dataItem = new LpDataItem
				{
					SerialNumber = fieldValues[1],
					DataValue = Convert.ToDouble(fieldValues[5]),
					DateTime = Convert.ToDateTime(fieldValues[3])
				};
				dataRows.Add(dataItem);
			}

			return dataRows;
		}
	}
}
