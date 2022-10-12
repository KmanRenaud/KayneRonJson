using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using System.Xml.Linq;
using System.Net.Http;
using Newtonsoft.Json.Linq;





namespace KayneRonJson
{
    public class Quotes
    {

        public static HttpClient client = new HttpClient();


        public static void Kanye()
        {

            var kayneUrl = "https://api.kanye.rest";
            var kanyeResponse = client.GetStringAsync(kayneUrl).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();


            Console.WriteLine($"Kanye: \"{kanyeQuote}\"");

        }
        public static void Ron()
        {

            var ronUrl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronResponse = client.GetStringAsync(ronUrl).Result;
            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine($"Ron: {ronQuote}");

        }
    }
}
