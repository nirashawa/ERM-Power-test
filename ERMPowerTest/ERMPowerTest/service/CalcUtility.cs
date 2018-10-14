using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.model;

namespace ConsoleApplication1.service
{
	public class CalcUtility
	{
		public static double getMedianLp(List<LpDataItem> dataItems)
		{
			return dataItems.Sum(x => x.DataValue) / dataItems.Count;

		}

		public static double getMedianTou(List<TouDataItem> dataItems)
		{
			return dataItems.Sum(x => x.Energy) / dataItems.Count;

		}
	}
}
