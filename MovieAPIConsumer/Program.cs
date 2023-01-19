using System;                               //first of all, packages that are being used
using System.Net.Http;


//exemple of consuming an third part API from TMDB (The Movie Database)
//url that is being used = https://api.themoviedb.org/3/movie/76341?api_key=<<api_key>>
//API key = 4880772064fd684d0ad7beeb0cc42cea


//namespace
namespace MovieAPIConsumer
{
    //primary class
    class Program
    {
        //main method
        //routine of how to consume the api
        static async Task Main() {
            int movieID = 550;
            var path = "https://api.themoviedb.org/3/movie/" + movieID + "?api_key=4880772064fd684d0ad7beeb0cc42cea";

            HttpClient client = new HttpClient();
            var response = await client.GetAsync(path);
            var content = await response.Content.ReadAsStringAsync();

            Console.WriteLine(content);

        }        
    }
}