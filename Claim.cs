using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimAPPv2
{
    public class Claim
    {
        public string Description { get; set; }
        public string DocumentPath { get; set; }

        // Ensure this property exists in your class
        public string Status { get; set; } = "Pending";  // Default status is "Pending"

        // Constructor
        public Claim(string description, string documentPath)
        {
            Description = description;
            DocumentPath = documentPath;
            Status = "Pending";  // Initialize status as Pending by default
        }

        // Optional parameterless constructor for flexibility
        public Claim()
        {
        }
    }
}
