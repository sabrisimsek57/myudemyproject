using HotelProject.WebUI.Dtos.FollowersDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashborrdSubscribeCountPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofileinfo/sabri57_"),
				Headers =
	{
		{ "X-RapidAPI-Key", "d7d547041bmsh96fa1fc74719801p1a1ae5jsn9339853ae1c1" },
		{ "X-RapidAPI-Host", "instagram-profile1.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				ResultInstagramFallowrsDto resultInstagramFallowrsDto = JsonConvert.DeserializeObject<ResultInstagramFallowrsDto>(body);
				ViewBag.v1 = resultInstagramFallowrsDto.followers;
				ViewBag.v2 = resultInstagramFallowrsDto.following;
			
			}
			
			var client2 = new HttpClient();
			var request2 = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://twitter154.p.rapidapi.com/user/details?username=saabrii034"),
				Headers =
	{
		{ "X-RapidAPI-Key", "d7d547041bmsh96fa1fc74719801p1a1ae5jsn9339853ae1c1" },
		{ "X-RapidAPI-Host", "twitter154.p.rapidapi.com" },
	},
			};
			using (var response2 = await client.SendAsync(request2))
			{
				response2.EnsureSuccessStatusCode();
				var body2 = await response2.Content.ReadAsStringAsync();
				ResultTwitterFallowrsDto resultTwitterFallowrsDto = JsonConvert.DeserializeObject<ResultTwitterFallowrsDto>(body2);
				ViewBag.v3 = resultTwitterFallowrsDto.follower_count;
				ViewBag.v4 = resultTwitterFallowrsDto.following_count;
			}

			
			var client3 = new HttpClient();
			var request3 = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Fsabri-%25C5%259Fim%25C5%259Fek-2a1b13256%2F"),
				Headers =
	{
		{ "X-RapidAPI-Key", "d7d547041bmsh96fa1fc74719801p1a1ae5jsn9339853ae1c1" },
		{ "X-RapidAPI-Host", "fresh-linkedin-profile-data.p.rapidapi.com" },
	},
			};
			using (var response3 = await client.SendAsync(request3))
			{
				response3.EnsureSuccessStatusCode();
				var body3 = await response3.Content.ReadAsStringAsync();
				ResulLinkledinFallowrs resulLinkledinFallowrs = JsonConvert.DeserializeObject<ResulLinkledinFallowrs>(body3);
				ViewBag.v5 = resulLinkledinFallowrs.data.followers_count;


			}
			return View();

		}

    }
}
