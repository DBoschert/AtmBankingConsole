using System.Text;
using System.Text.Json;
using AtmBankingConsole;
using AtmBankingConsole.Models;
using TestPrsApi;
using static System.Net.WebRequestMethods;

const string baseurl = "http://localhost:1111";

JsonSerializerOptions joptions = new JsonSerializerOptions()
{
    PropertyNameCaseInsensitive = true,
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
    WriteIndented = true
};

var cardCode; //readline here
var pinCode; // readline here
HttpClient http = new HttpClient();

var jsonresponse = await LoginAsync(http, joptions, cardCode, pinCode);
var customers = jsonresponse.DataReturned as Customer;

async Task<JsonResponse> LoginAsnyc(HttpClient Http, JsonSerializerOptions joption, int cardCode, int pinCode)
{
    HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, $"{baseurl}/");
}
















/*

/*
$ Enter Card Code : 1234<enter>
$ Enter Pin Code  : 6789<enter>
Then there should be a menu showing the customer what the options are for the ATM. Options should include:

* Balance
* Deposit
* Withdraw
* Transfer
* Show Transactions



HttpClient http = new HttpClient();

var read = Console.ReadLine();

Console.WriteLine("'b' = Balance");
Console.WriteLine("'d' = Deposit");
Console.WriteLine("'w' = Withdraw");
Console.WriteLine("'t' = Transfer");
Console.WriteLine("'st' = Show Transactions");

Console.Write("Enter Card Code: ");

var cardCode = Console.ReadLine();
Console.WriteLine();

Console.Write("Enter Pin Code: ");
var pinCode = Console.ReadLine();
// check for the Pin Code here




*/


