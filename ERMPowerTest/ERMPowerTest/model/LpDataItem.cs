using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.model
{
	public class LpDataItem:TouDataItem
	{
		public string MeterPointCode { get; set; }
		public string SerialNumber { get; set; }
		public string PlantCode { get; set; }
		public DateTime DateTime { get; set; }
		public string DataType { get; set; }
		public double DataValue { get; set; }
		public string Unit { get; set; }
		public string Status { get; set; }
	}
}
