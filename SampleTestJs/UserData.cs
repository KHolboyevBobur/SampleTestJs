using Newtonsoft.Json;

namespace SampleTestJs
{
    public class UserData
    {
        [JsonProperty("jur_tin")]
        public string JurTin { get; set; }

        [JsonProperty("org_name")]
        public string OrgName { get; set; }

        [JsonProperty("individual_fullname")]
        public string IndividualFullName { get; set; }

        [JsonProperty("individual_pinfl")]
        public string IndividualPinfl { get; set; }
    }
}