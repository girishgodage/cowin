using System.Collections.Generic;

namespace BlazorCowin.Models
{
    public class Session
    {
        public string session_id { get; set; }
        public string date { get; set; }
        public decimal available_capacity { get; set; }
        public int min_age_limit { get; set; }
        public string vaccine { get; set; }
        public List<string> slots { get; set; }
    }
}
