using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShopWeb.Data;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace ShopWebForms
{
    public partial class UserControls : System.Web.UI.Page
    {
        List<MyControl> controlModel;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindGrid();
            }
        }
        private void BindGrid()
        {
            if (Session["MyDataControls"] == null)
            {
                WebRequest request = WebRequest.Create("http://localhost:49557/api/Controls");
                request.Credentials = CredentialCache.DefaultCredentials;
                request.ContentType = "application/json; charset=utf-8";
                WebResponse response = request.GetResponse();

                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);

                string responseFromServer = reader.ReadToEnd();
                reader.Close();
                response.Close();

                controlModel = JsonConvert.DeserializeObject<List<MyControl>>(responseFromServer);
                foreach (var item in controlModel)
                {
                    string imageBase64 = Convert.ToBase64String(item.Img);
                    string imageSrc = string.Format("data:image/gif;base64,{0}", imageBase64);
                    item.ImgStr = imageSrc;
                }

                Session["MyDataControls"] = controlModel;
            }
            else
            {
                controlModel = Session["MyDataControls"] as List<MyControl>;
            }

            ControlsListRepeater.DataSource = controlModel;
            ControlsListRepeater.DataBind();
        }
    }
}