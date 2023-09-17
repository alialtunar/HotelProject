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
    public class _DashboardSubscribeCountPartial: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofile/altunarali"),
                Headers =
    {
        { "X-RapidAPI-Key", "1a0f4b7622mshcc8e9a772cb6444p1e9011jsnccb67f46abe2" },
        { "X-RapidAPI-Host", "instagram-profile1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                ResultInstagramFollowersDto resultInstagramFollowers = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
                ViewBag.InstagramFollowers = resultInstagramFollowers.followers;
                ViewBag.InstagramFollowing = resultInstagramFollowers.following;

           
            }

            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://twitter154.p.rapidapi.com/user/details?username=alialtunar3&user_id=96479162"),
                Headers =
    {
        { "X-RapidAPI-Key", "1a0f4b7622mshcc8e9a772cb6444p1e9011jsnccb67f46abe2" },
        { "X-RapidAPI-Host", "twitter154.p.rapidapi.com" },
    },
            };
            using (var response2 = await client2.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                ResultTwitterFollowersDto resultTwitterFollowers = JsonConvert.DeserializeObject<ResultTwitterFollowersDto>(body2);
                ViewBag.TwitterFollowers = resultTwitterFollowers.follower_count;
                ViewBag.TwitterFollowing = resultTwitterFollowers.following_count;
            }

            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Falialtunar%2F"),
                Headers =
    {
        { "X-RapidAPI-Key", "1a0f4b7622mshcc8e9a772cb6444p1e9011jsnccb67f46abe2" },
        { "X-RapidAPI-Host", "fresh-linkedin-profile-data.p.rapidapi.com" },
    },
            };
            using (var response3 = await client3.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body3 = await response3.Content.ReadAsStringAsync();
                ResultLinkedinFollowersDto resultLinkedinFollowers = JsonConvert.DeserializeObject<ResultLinkedinFollowersDto>(body3);
                ViewBag.LinkedinFollowers = resultLinkedinFollowers.data.followers_count;
                ViewBag.LinkedinFollowing = resultLinkedinFollowers.data.connections_count;
            }

            return View();

        }
    }
}
