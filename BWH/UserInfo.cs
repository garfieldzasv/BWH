using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Windows.Forms;

namespace BandwagonHelper
{
    public partial class UserInfo : Form
    {

        public UserInfo()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            txbApiUrl.Text = ConfigurationManager.AppSettings["bwhAddress"];
            txbVeid.Text = ConfigurationManager.AppSettings["veid"];
            txbApiKey.Text = ConfigurationManager.AppSettings["apiKey"];
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string veid = txbVeid.Text;
            string apiKey = txbApiKey.Text;
            string apiUrl = txbApiUrl.Text;
            NameValueCollection keyValuePair = new NameValueCollection();
            keyValuePair["veid"] = veid;
            keyValuePair["apiKey"] = apiKey;
            keyValuePair["bwhAddress"] = apiUrl;
            Utility.SetSetting(keyValuePair);
            Close();
        }
    }
}
