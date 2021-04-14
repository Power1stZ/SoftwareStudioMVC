using System;

namespace Frontend.Models
{
    public class Tool
    {

        public string Id { get; set; }

        public string toolName { get; set; }

        public bool isRent { get; set; }

        public DateTime rentTime { get; set; }

        public string room { get; set; }

        public string description { get; set; }

        public string rental { get; set; }
    }
}