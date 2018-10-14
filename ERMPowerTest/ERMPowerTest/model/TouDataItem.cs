using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.model
{
	public class TouDataItem
	{
		public string MeterPointCode { get; set; }
		public string SerialNumber { get; set; }
		public string PlantCode { get; set; }
		public DateTime DateTime { get; set; }
		public string DataType { get; set; }
		public double Energy { get; set; }
		public double MaximumDemand { get; set; }
		public DateTime TimeofMaxDemand { get; set; }
		public string Unit { get; set; }
		public string Status { get; set; }
		public string Period { get; set; }
		public string DLSActive { get; set; }
		public int BillingResetCount { get; set; }
		public DateTime BillingResetDateTime { get; set; }

		public string Rate { get; set; }
	}
}
