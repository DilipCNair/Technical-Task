using System.Text.Json.Serialization;

namespace Frontend.Modal;

public class PortfolioResponse
{
    [JsonPropertyName("data")]
    public List<Portfolio> Data { get; set; } = new();
}

public class Portfolio
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    [JsonPropertyName("firmId")]
    public string FirmId { get; set; } = string.Empty;

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("nodeId")]
    public List<string> NodeId { get; set; } = new();

    [JsonPropertyName("nodeName")]
    public List<string> NodeName { get; set; } = new();

    [JsonPropertyName("currency")]
    public string Currency { get; set; } = string.Empty;

    [JsonPropertyName("currentValue")]
    public double CurrentValue { get; set; }

    [JsonPropertyName("accounts")]
    public int Accounts { get; set; }

    [JsonPropertyName("uninvestedCash")]
    public double UninvestedCash { get; set; }

    [JsonPropertyName("growth")]
    public double Growth { get; set; }

    [JsonPropertyName("growthPercent")]
    public double GrowthPercent { get; set; }

    [JsonPropertyName("adjustedGrowth")]
    public double AdjustedGrowth { get; set; }

    [JsonPropertyName("adjustedGrowthPercent")]
    public double AdjustedGrowthPercent { get; set; }
}

public enum ClientStatus
{
    Active,
    Pending,
    Registered
}
