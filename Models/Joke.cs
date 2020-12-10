using System.Collections.Generic;

namespace TellaJoke.Models
{
    
    public class Joke
    {
        
        public string Type { get; set; }
        
        public Value Value { get; set; }

    }

    public class Value
    {
        public int Id { get; set; }
        public string Joke { get; set; }
        public List<string> Categories { get; set; }
    }
}