
namespace Frontend.Models
{
    public class Room
    {
        
        public string Id { get; set; }

        public string roomNumber { get; set; }
        
        public string roomName { get; set; }

        public int maxCount { get; set; }

        public int currentRent { get; set; }
    }
}