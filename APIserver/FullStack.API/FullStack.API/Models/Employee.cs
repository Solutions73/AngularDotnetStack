﻿namespace FullStack.API.Models
{
    public class Employee
    {
        public Guid id { get; set; }

        public string Name { get; set; }

        public string email { get; set; }

        public long phone { get; set; }

        public long salary { get; set; }

        public string department { get; set; }
    }
}
