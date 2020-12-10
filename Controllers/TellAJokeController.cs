using Newtonsoft.Json;
using System;
using System.Web.Http;
using TellaJoke.Models;
using RestSharp;

namespace TellaJoke.Controllers
{
    public class TellAJokeController : ApiController
    {
        // GET: api/TellAJoke
        [HttpGet]
        public string GetTellAJoke()
        {
            JokeWithName newJokewithName = new JokeWithName();
           
            String[] Jokeresponse = GetaJoke();
            newJokewithName.Type = Jokeresponse[0];
            newJokewithName.Joke = Jokeresponse[1];
            return (JsonConvert.SerializeObject(newJokewithName));
        }

        private string[] GetaJoke()
        {
            string[] FullName = GetName();

            string url = String.Format("http://api.icndb.com/jokes/random?firstName={0}&lastName={1}&limitTo=[nerdy]", FullName[0], FullName[1]);
            try
            {
                var response = GetApiResponse(url);
                Joke newJoke = JsonConvert.DeserializeObject<Joke>(response.Content);
                return new string[] { newJoke.Type, newJoke.Value.Joke };
            }
            catch (Exception)
            {
                return new string[] { "Fail", "" };
            }

        }

        private string[] GetName()
        {
            string url = "http://uinames.com/api/";
            try
            {
                var response = GetApiResponse(url);
                Names newName = JsonConvert.DeserializeObject<Names>(response.Content);
                return new string[] { newName.Name, newName.Surname };
            }
            catch (Exception)
            {
                return new string[] { "Name", "Surname" };
            }
        }

        private IRestResponse GetApiResponse(string url)
        {
            
            var client = new RestClient(url);
            return client.Execute(new RestRequest());
           
        }
    }
}
