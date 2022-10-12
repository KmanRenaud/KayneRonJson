using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using System.Xml.Linq;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using KayneRonJson;

#region
var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
string connString = config.GetConnectionString("DefaultConnection");
IDbConnection conn = new MySqlConnection(connString);
#endregion


for (int i = 0; i < 5; i++)
{
    Quotes.Kanye();
    Console.WriteLine();
    Thread.Sleep(5000);
    Quotes.Ron();
    Console.WriteLine();
    Thread.Sleep(5000);
}