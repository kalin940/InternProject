using Newtonsoft.Json;
using ShopWeb.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopWebForms
{
    public partial class Designs : System.Web.UI.Page
    {
        List<Design> model;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindGrid();
            }
        }

        private void BindGrid()
        {
            if (Session["MyDataKey"] == null)
            {
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
                foreach (var item in model)
                {
                    string imageBase64 = Convert.ToBase64String(item.Img);
                    string imageSrc = string.Format("data:image/gif;base64,{0}", imageBase64);
                    item.ImgStr = imageSrc;
                }

                Session["MyDataKey"] = model;
            }
            else
            {
                model = Session["MyDataKey"] as List<Design>;
            }

            DesignsListRepeater.DataSource = model;
            DesignsListRepeater.DataBind();
        }

        protected void DesignsListRepeater_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

        protected void ButtonBuy_Click(object sender, EventArgs e)
        {

        }
    }
}