using System.Runtime.Serialization;

namespace TellaJoke.Models
{
    [DataContract]
    public class JokeWithName
    {
        [DataMember (Name="type")]
        public string Type { get; set; }

        [DataMember(Name ="joke")]
        public string Joke { get; set; }
    }
}