using System;

namespace BLDataGrid1.Shared
{
    [Serializable]
    public class Customer
    {
        public string id { get; set; }
        public string name { get; set; }
        public string age { get; set; }
        public string address { get; set; }
        public string zip { get; set; }
        public bool vip { get; set; }

    }
}
