using System;

namespace BLDataRepeater2.Shared
{
	[Serializable]
	public class Customer
	{
		public string id { get; set; }
		public string name { get; set; }
		public string address { get; set; }
		public string zip { get; set; }
	}
}
