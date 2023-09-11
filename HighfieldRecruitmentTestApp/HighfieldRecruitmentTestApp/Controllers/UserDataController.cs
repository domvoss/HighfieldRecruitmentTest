using HighfieldRecruitmentTestApp.Models;
using HighfieldRecruitmentTestApp.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.ComponentModel;

namespace HighfieldRecruitmentTestApp.Controllers
{
    [Route("[controller]")]
    public class UserDataController : Controller
    {
        Uri baseAddress = new Uri("https://recruitment.highfieldqualifications.com/api/test");
        private readonly HttpClient _httpClient;
        private List<UserDataModel> userDataList = new List<UserDataModel>();
        private IUserDataService userDataService;

        public UserDataController()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = baseAddress;

            this.userDataList = new List<UserDataModel>();
            this.userDataService = new UserDataService();
        }

        [HttpGet]
        public string Get()
        {
            HttpResponseMessage response = _httpClient.GetAsync(baseAddress).Result;

            if (response.IsSuccessStatusCode)
            {
                string returnedData = response.Content.ReadAsStringAsync().Result;
                userDataList = JsonConvert.DeserializeObject<List<UserDataModel>>(returnedData) ?? new List<UserDataModel>();
            }

            return JsonConvert.SerializeObject(userDataList); ;
        }

        [HttpGet("colour")]
        public string GetColourData()
        {
            HttpResponseMessage response = _httpClient.GetAsync(baseAddress).Result;

            if (response.IsSuccessStatusCode)
            {
                string returnedData = response.Content.ReadAsStringAsync().Result;
                userDataList = JsonConvert.DeserializeObject<List<UserDataModel>>(returnedData) ?? new List<UserDataModel>();
            }

            List<ColourDataModel> colourData = this.userDataService.ProcessColourData(userDataList);

            return JsonConvert.SerializeObject(colourData);
        }

        [HttpGet("age")]
        public string GetUserAgeData()
        {
            HttpResponseMessage response = _httpClient.GetAsync(baseAddress).Result;

            if (response.IsSuccessStatusCode)
            {
                string returnedData = response.Content.ReadAsStringAsync().Result;
                userDataList = JsonConvert.DeserializeObject<List<UserDataModel>>(returnedData) ?? new List<UserDataModel>();
            }

            List<AgeDataModel> ageDataList = this.userDataService.ProcessAgeData(userDataList);

            return JsonConvert.SerializeObject(ageDataList);
        }
    }
}
