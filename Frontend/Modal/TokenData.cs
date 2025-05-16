using System.Text.Json.Serialization;

namespace Frontend.Modal;

public class RootResponse
{
    public DataResponse Data { get; set; } = new();
}

public class DataResponse
{
    public string Token { get; set; } = string.Empty;
    public string UserName { get; set; } = string.Empty;
    public string UserType { get; set; } = string.Empty;
    public List<Scope> Scopes { get; set; } = new();
    public List<string> Services { get; set; } = new();
}

public class Scope
{
    public string ScopeName { get; set; } = string.Empty;

    [JsonPropertyName("scope")]
    public string JsonScopeName
    {
        get => ScopeName;
        set => ScopeName = value;
    }

    public List<string>? Ranges { get; set; }
}


