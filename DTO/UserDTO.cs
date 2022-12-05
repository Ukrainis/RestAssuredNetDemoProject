using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAssuredDemoProject.DTO
{
    public class UserDTO
    {
        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}
