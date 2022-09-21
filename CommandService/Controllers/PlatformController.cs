using asp.netcore_microservice.Models;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Text;
using System.Text.Json;

namespace asp.netcore_microservice.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PlatformController : ControllerBase
    {
        private readonly HttpClient httpClient;
        public PlatformController(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        [HttpPost]
        public async Task<ActionResult<Platform>> AddPlatform(Platform platform)
        {
            Console.WriteLine("--> Addind Data From CommandService...");

            var url = "http://localhost:5202/api/platform";
            var httpContent = new StringContent(
                JsonSerializer.Serialize(platform),
                Encoding.UTF8,
                "application/json");

            var response = await httpClient.PostAsync(url, httpContent);
            var responseClient = await response.Content.ReadAsStringAsync();
            return Ok(responseClient);
        }

        [HttpGet]
        public async Task<ActionResult<Platform>> GetPlatforms()
        {
            Console.WriteLine("--> Getting All Data in PlatformService From CommandService...");

            var url = "http://localhost:5202/api/platform";
            var response = await httpClient.GetAsync(url);
            var responseClient = await response.Content.ReadAsStringAsync();
            return Ok(responseClient);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Platform>> GetPlatform(int id)
        {
            Console.WriteLine("--> Getting Data By Id in PlatformService From CommandService...");

            var url = $"http://localhost:5202/api/platform/{id}";
            var response = await httpClient.GetAsync(url);
            var responseClient = await response.Content.ReadAsStringAsync();
            return Ok(responseClient);
        }

        [HttpPut]
        public async Task<ActionResult<Platform>> UpdatePlatform(Platform platform)
        {
            Console.WriteLine("--> Update Data in PlatformService From CommandService...");

            var url = "http://localhost:5202/api/platform";
            var httpContent = new StringContent(
                JsonSerializer.Serialize(platform),
                Encoding.UTF8,
                "application/json");

            var response = await httpClient.PutAsync(url, httpContent);
            var responseClient = await response.Content.ReadAsStringAsync();
            return Ok(responseClient);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Platform>> DeletePlatform(int id)
        {
            Console.WriteLine("--> Delete Data By Id in PlatformService From CommandService...");

            var url = $"http://localhost:5202/api/platform/{id}";
            var response = await httpClient.DeleteAsync(url);
            var responseClient = await response.Content.ReadAsStringAsync();
            return Ok(responseClient);
        }
    }
}
