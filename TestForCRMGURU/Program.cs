using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using Google.Apis; //NuGet: Install-Package Google.Apis -Version 1.49.0
//NuGet AsyncApi: Install-Package Microsoft.AspNet.WebApi.Client

namespace TestForCRMGURU
{
    public class Currency //JSON Deserializer
    {
        public string code { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class Language //JSON Deserializer
    {
        public string iso639_1 { get; set; }
        public string iso639_2 { get; set; }
        public string name { get; set; }
        public string nativeName { get; set; }
    }

    public class Translations //JSON Deserializer
    {
        public string de { get; set; }
        public string es { get; set; }
        public string fr { get; set; }
        public string ja { get; set; }
        public string it { get; set; }
        public string br { get; set; }
        public string pt { get; set; }
        public string nl { get; set; }
        public string hr { get; set; }
        public string fa { get; set; }
    }

    public class MyArray //JSON Deserializer
    {
        public string name { get; set; }
        public List<string> topLevelDomain { get; set; }
        public string alpha2Code { get; set; }
        public string alpha3Code { get; set; }
        public List<string> callingCodes { get; set; }
        public string capital { get; set; }
        public List<string> altSpellings { get; set; }
        public string region { get; set; }
        public string subregion { get; set; }
        public int population { get; set; }
        public List<double> latlng { get; set; }
        public string demonym { get; set; }
        public double area { get; set; }
        public double gini { get; set; }
        public List<string> timezones { get; set; }
        public List<string> borders { get; set; }
        public string nativeName { get; set; }
        public string numericCode { get; set; }
        public List<Currency> currencies { get; set; }
        public List<Language> languages { get; set; }
        public Translations translations { get; set; }
        public string flag { get; set; }
        public List<object> regionalBlocs { get; set; }
        public string cioc { get; set; }
    }

    public class Root //JSON Deserializer - main class
    {
        public List<MyArray> MyArray { get; set; }
        public Boolean Loaded { get; set; }
    }
    public class Request
    {
        public string Country { get; set; }
    }

    public class API_CRMGURU
    {

        public Root result;
        public Request request;


        //static HttpClient client = new HttpClient();
        public async void GetInfoTask()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://restcountries.eu/rest/v2/name/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    string path = this.request.Country;
                    HttpResponseMessage response = await client.GetAsync(path);
                    if (response.IsSuccessStatusCode)
                    {
                        this.result.Loaded = false;
                        var arr = await response.Content.ReadAsAsync<List<MyArray>>();
                        this.result.MyArray = new List<MyArray>();
                        this.result.MyArray = arr;
                        this.result.Loaded = true;
                    }
                }
                catch (Exception e) {}
            }
        }
        //<summary>Получает по API информацию о стране и заполняет result object класса API_CRMGURU</summary>
        public async void GetInfo()
        {

                await Task.Run(() => GetInfoTask());
        }
        //<summary>Конструктор класса API_CRMGURU</summary>
        //<param name="country">Имя странны, по которой необходимо получить информацию (на английском)</param>
        public API_CRMGURU(string country)
        {
            request = new Request
            {
                Country = country
            };
            result = new Root();
        }
    }

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
