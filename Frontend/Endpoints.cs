namespace Frontend;

public static class Endpoints
{
    public static string BaseUrl = "https://pfolio-api-staging.seccl.tech";

    public static string LoginUrl = $"{BaseUrl}/authenticate";

    public static string AllClients = $"{BaseUrl}/portfolio";

    public static string ClientDetails = $"{BaseUrl}/portfolio/summary";

}
