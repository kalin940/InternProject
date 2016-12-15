using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using ShopWeb.Data;

namespace ShopWebForms
{
    public partial class Products : System.Web.UI.Page
    {
        List<Design> model;
        protected void Page_Load(object sender, EventArgs e)
        {
            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("http://localhost:49557");
            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //HttpResponseMessage responce =await client.GetAsync("/api/Designs");

            //var request = (HttpWebRequest)WebRequest.Create("http://localhost:49557/api/Designs");
            //request.Method = "GET";
            //using (var resp = (HttpWebResponse)request.GetResponse())
            //{
            //    HyperLink1.Text = resp.ContentLength.ToString();
            //}

            // string noArrJson = responseFromServer.Substring(1, responseFromServer.Length-2);
            // Design m = JsonConvert.DeserializeObject<Design>(noArrJson);
            // HyperLink1.Text = m.Info;
            WebRequest request = WebRequest.Create("http://localhost:49557/api/Designs");
            request.Credentials = CredentialCache.DefaultCredentials;
            request.ContentType = "application/json; charset=utf-8";
            WebResponse response = request.GetResponse();
           
            Stream dataStream = response.GetResponseStream();          
            StreamReader reader = new StreamReader(dataStream);
      
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            response.Close();
            
            model = JsonConvert.DeserializeObject<List<Design>>(responseFromServer);
            int counter = 0;
            foreach (var item in model)
            {
                
                counter++;
                if (counter == model.Capacity-1 )
                {
                    HyperLink1.Text += item.Title;
                }
                else if (counter == model.Capacity - 2)
                {
                    HyperLink2.Text += item.Title;
                }
                else if (counter == model.Capacity - 3)
                {
                    HyperLink3.Text += item.Title;
                }

            }

        }
        //public static string ShowProduct(Design product)
        //{
        //    return ($"Name: {product.Title}\tPrice: {product.Price}\tInfo: {product.Info}");
        //}
        //public static async Task<Design> GetProductAsync(string path)
        //{
        //    Design product = null;
        //    HttpResponseMessage response = await client.GetAsync(path);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        product = await response.Content.ReadAsAsync<Design>();
        //    }
        //    return product;
        //}
    }

    //public class Design
    //{
    //    public int Id { get; set; }

    //    public string Title { get; set; }

    //    public string Info { get; set; }

    //    public double Price { get; set; }

    //    public byte[] Img { get; set; }

    //    public string Content { get; set; }

    //    public DateTime? Date { get; set; }
    //}
    //public class MyClass
    //{
    //    public List<Design> data { get; set; }
    //}
}