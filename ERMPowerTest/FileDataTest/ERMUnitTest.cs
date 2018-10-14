using System;
using System.Collections.Generic;
using ConsoleApplication1.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace FileDataTest
{
	[TestClass]
	public class ERMUnitTest
	{
		[TestMethod]
		public void LPDataMedianTest()
		{
			double expected = 4;
			var lpData = MockDataLpDataItems();
			var result = ConsoleApplication1.service.CalcUtility.getMedianLp(lpData);
			Assert.AreEqual(result, expected);
		}

		[TestMethod]
		public void ToUDataMedianTest()
		{
			double expected = 5;
			var lpData = MockDataTouDataItems();
			var result = ConsoleApplication1.service.CalcUtility.getMedianTou(lpData);
			Assert.AreEqual(result, expected);
		}

		private static List<LpDataItem> MockDataLpDataItems()
		{
			List<LpDataItem> lpData = new List<LpDataItem>
			{
				new LpDataItem
				{
					DataValue = 4,
					DateTime = DateTime.Today.AddDays(1)
				},
				new LpDataItem
				{
					DataValue = 3,
					DateTime = DateTime.Today.AddDays(2)
				},
				new LpDataItem
				{
					DataValue = 5,
					DateTime = DateTime.Today.AddDays(-3)
				}
			};
			return lpData;
		}

		private static List<TouDataItem> MockDataTouDataItems()
		{
			List<TouDataItem> lpData = new List<TouDataItem>
			{
				new TouDataItem
				{
					Energy = 4,
					DateTime = DateTime.Today.AddDays(1)
				},
				new TouDataItem
				{
					Energy = 3,
					DateTime = DateTime.Today.AddDays(2)
				},
				new TouDataItem
				{
					Energy = 5,
					DateTime = DateTime.Today.AddDays(-3)
				},
				new TouDataItem
				{
					Energy = 8,
					DateTime = DateTime.Today.AddDays(-3)
				},
			};
			return lpData;
		}
	}
}
