using System;

namespace LocalStoragesArray
{
    [Serializable]
    public class User
    {
        public string username;
        public string email;
        public string jwt;
        public DateTime created;
    }
}
