using System;

namespace BLDataRepeater1.Shared
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
