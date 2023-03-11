using Newtonsoft.Json;

namespace EnkaSharp.Models;

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

public class Info
{
    [JsonProperty("playerInfo")] public PlayerInfo PlayerInfo { get; set; }

    [JsonProperty("ttl")] public int Ttl { get; set; }

    [JsonProperty("owner")] public Owner Owner { get; set; }

    [JsonProperty("uid")] public string Uid { get; set; }
}

public class Owner
{
    [JsonProperty("hash")] public string Hash { get; set; }

    [JsonProperty("username")] public string Username { get; set; }

    [JsonProperty("profile")] public Profile Profile { get; set; }
}

public class PlayerInfo
{
    [JsonProperty("nickname")] public string Nickname { get; set; }

    [JsonProperty("level")] public int Level { get; set; }

    [JsonProperty("worldLevel")] public int WorldLevel { get; set; }

    [JsonProperty("nameCardId")] public int NameCardId { get; set; }

    [JsonProperty("finishAchievementNum")] public int FinishAchievementNum { get; set; }

    [JsonProperty("towerFloorIndex")] public int TowerFloorIndex { get; set; }

    [JsonProperty("towerLevelIndex")] public int TowerLevelIndex { get; set; }

    [JsonProperty("showAvatarInfoList")] public List<ShowAvatarInfoList> ShowAvatarInfoList { get; set; }

    [JsonProperty("showNameCardIdList")] public List<int> ShowNameCardIdList { get; set; }

    [JsonProperty("profilePicture")] public ProfilePicture ProfilePicture { get; set; }
}

public class Profile
{
    [JsonProperty("bio")] public string Bio { get; set; }

    [JsonProperty("level")] public int Level { get; set; }

    [JsonProperty("signup_state")] public int SignupState { get; set; }

    [JsonProperty("avatar")] public string Avatar { get; set; }
}

public class ProfilePicture
{
    [JsonProperty("avatarId")] public int AvatarId { get; set; }
}



public class ShowAvatarInfoList
{
    [JsonProperty("avatarId")] public int AvatarId { get; set; }

    [JsonProperty("level")] public int Level { get; set; }
}