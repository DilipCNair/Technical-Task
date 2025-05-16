namespace Frontend.Modal;

public class Data
{
    public string Token { get; set; } = string.Empty;
    public string UserName { get; set; } = string.Empty;
    public string UserType { get; set; } = string.Empty;
    public List<string> Scopes { get; set; } = [];
    public List<string> Services { get; set; } = [];
}

//{
//  "data": {
//    "token": "<token>",
//    "userName": "<name>",
//    "userType": "<User or Machine>",
//    "scopes": [
//      "Admin"
//    ],
//    "services": [
//      "Core",
//      "Pfolio"
//    ]
//  }
//}
