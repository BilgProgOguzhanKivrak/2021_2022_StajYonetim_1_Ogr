using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StayYonetimProg.test
{
    public partial class WebTest2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Sehirler istanbul = new Sehirler();
                istanbul.code = "34";
                istanbul.name = "İStanbul";

                Sehirler izmir = new Sehirler();
                izmir.code = "35";
                izmir.name = "İzmir";

                Sehirler hatay = new Sehirler();
                hatay.code = "31";
                hatay.name = "Hatay";

                List<Sehirler> liste = new List<Sehirler>();
                liste.Add(istanbul);
                liste.Add(izmir);
                liste.Add(hatay);

                ddListSehirler.DataTextField = "name";
                ddListSehirler.DataValueField = "code";
                ddListSehirler.DataSource = liste;

                ddListSehirler.DataBind();

                IlceDoldur();
            }
        }

        protected void ddListSehirler_SelectedIndexChanged(object sender, EventArgs e)
        {
            IlceDoldur();
        }

        private void IlceDoldur()
        {
            ddListIlceler.Items.Clear();
            if (ddListSehirler.SelectedItem.Value == "34")
            {
                ddListIlceler.Items.Add("Kadıköy");
                ddListIlceler.Items.Add("Beşiktaş");
                ddListIlceler.Items.Add("Bahçelievler");

            }
            else if (ddListSehirler.SelectedItem.Value == "35")
            {
                ddListIlceler.Items.Add("Bornova");
                ddListIlceler.Items.Add("Gaziemir");
            }
        }

        public class Sehirler
        {
            public string code { set; get; }
            public string name { set; get; }
        }
    }
}