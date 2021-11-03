using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StayYonetimProg.test
{
    public partial class WebTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                List<TestData> liste = new List<TestData>();

                for (int i = 0; i < 10; i++)
                {
                    TestData item = new TestData();
                    item.code = i.ToString();
                    item.name = i + " nolu Item";

                    liste.Add(item);
                }

                chkListDepo.DataSource = liste;
                chkListDepo.DataTextField = "name";
                chkListDepo.DataValueField = "code";
                chkListDepo.DataBind();
            }
        }

        protected void chkListDepo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBilgi.Text = "";
            for(int i = 0; i < chkListDepo.Items.Count; i++)
            {
                if (chkListDepo.Items[i].Selected)
                    lblBilgi.Text = lblBilgi.Text + " - " + chkListDepo.Items[i].Text;
            }
        }

        public class TestData
        {
            public string code { set; get; }
            public string name { set; get; }
        }
    }
}