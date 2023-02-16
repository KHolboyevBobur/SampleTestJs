using Newtonsoft.Json;

namespace SampleTestJs
{
    public class UserModel
    {
        [JsonProperty("user_type")]
        public string UserType { get; set; }

        [JsonProperty("data")]
        public UserData Data { get; set; }
    }
}
