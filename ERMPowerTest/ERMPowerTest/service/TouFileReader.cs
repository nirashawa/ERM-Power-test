using System;
using System.Collections.Generic;
using ConsoleApplication1.model;
using System.IO;


namespace ConsoleApplication1.service
{
	public class TouFileReader
	{
		public List<TouDataItem> Read(string filePath)
		{
			List<TouDataItem> dataRows = new List<TouDataItem>();
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

				TouDataItem dataItem = new TouDataItem
				{
					SerialNumber = fieldValues[1],
					Energy = Convert.ToDouble(fieldValues[5]),
					DateTime = Convert.ToDateTime(fieldValues[3])
				};
				dataRows.Add(dataItem);
			}

			return dataRows;
		}
	}
}
