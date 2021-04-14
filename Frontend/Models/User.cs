

namespace Frontend.Models
{
    public class User
    {

        public string Id { get; set; }

        public string studentNumber { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string email { get; set; }

        public string password { get; set; }

        public bool isBan { get; set; }

        public int role { get; set; }

    }
}