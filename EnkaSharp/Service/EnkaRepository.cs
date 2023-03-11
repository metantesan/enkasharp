using EnkaSharp.Models;
using EnkaSharp.Repository;
using Newtonsoft.Json;

namespace EnkaSharp.Service;

public class EnkaRepository:IEnkaRepository
{
    private string BaseUrl="https://enka.network/api/uid";
    private string lang;

    public EnkaRepository(string lang)
    {
        this.lang = lang;
    }

    public async Task<Info> Info(long uid)
    {
        string data;
        string Url = $"{BaseUrl}/{uid}?info";
        try
        {
            using (HttpClient client = new HttpClient())
            {
                //In the next using statement you will initiate the Get Request, use the await keyword so it will execute the using statement in order.
                //The HttpResponseMessage which contains status code, and data from response.
                using (HttpResponseMessage res = await client.GetAsync(Url))
                {
                    //Then get the data or content from the response in the next using statement, then within it you will get the data, and convert it to a c# object.
                    using (HttpContent content = res.Content)
                    {
                     
                        data = await content.ReadAsStringAsync();
                       
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
       
        return  JsonConvert.DeserializeObject<Info>(data);
    }
}