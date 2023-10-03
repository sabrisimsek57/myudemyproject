using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapiApi.Consume.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RapiApi.Consume.Controllers
{
    public class ImdbController : Controller
    {
        public async Task< IActionResult> Index()
        {
			List<ApiMovieViewModel> apiMovieViewModels = new List<ApiMovieViewModel>();
		
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
				Headers =
	{
		{ "X-RapidAPI-Key", "d7d547041bmsh96fa1fc74719801p1a1ae5jsn9339853ae1c1" },
		{ "X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				apiMovieViewModels = JsonConvert.DeserializeObject<List<ApiMovieViewModel>>(body);
				return View(apiMovieViewModels);
			}
			
    }
}
}
