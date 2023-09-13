using System.Text;
using System.Text.Json;
using AtmBankingConsole;

const string baseurl = "http://localhost:1111";

JsonSerializerOptions joptions = new JsonSerializerOptions()
{
    PropertyNameCaseInsensitive = true,
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
    WriteIndented = true
};

HttpClient http = new HttpClient();

