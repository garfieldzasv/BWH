using Newtonsoft.Json;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;

namespace BandwagonHelper
{
    public class Service
    {
        private string m_BwhAddress = "";
        private string m_Veid = "";
        private string m_ApiKey = "";
        
        public Service(string bwhAddress, string veid, string apiKey)
        {
            m_BwhAddress = bwhAddress;
            m_Veid = veid;
            m_ApiKey = apiKey;
        }

        public ServerStatusJson GetServiceInfo()
        {
            string url = ApiUrl.SERVICE_INFO;
            string responseText = ApiRequest(url);
            return JsonConvert.DeserializeObject<ServerStatusJson>(responseText);
        }
        public LiveServerStatusJson GetLiveServiceInfo()
        {
            string url = ApiUrl.LIVE_SERVICE_INFO;
            string responseText = ApiRequest(url);
            return JsonConvert.DeserializeObject<LiveServerStatusJson>(responseText);
        }

        public bool StartServer()
        {
            string url = ApiUrl.START;
            string responseText = ApiRequest(url);
            return JsonConvert.DeserializeObject<ExecuteResultJson>(responseText).Error == 0;
        }
        public bool RestartServer()
        {
            string url = ApiUrl.RESTART;
            string responseText = ApiRequest(url);
            return JsonConvert.DeserializeObject<ExecuteResultJson>(responseText).Error == 0;
        }
        public bool StopServer()
        {
            string url = ApiUrl.STOP;
            string responseText = ApiRequest(url);
            return JsonConvert.DeserializeObject<ExecuteResultJson>(responseText).Error == 0;
        }


        private NameValueCollection InitUserInfo(NameValueCollection param = null)
        {
            if (param == null) param = new NameValueCollection();
            param["veid"] = m_Veid;
            param["api_key"] = m_ApiKey;

            return param;
        }
        private string ApiRequest(string url, NameValueCollection param = null)
        {
            param = InitUserInfo(param);
            StringBuilder sb = new StringBuilder();
            foreach (string key in param.AllKeys)
            {
                sb.Append(string.Format("&{0}={1}", key, param[key]));
            }
            string paramUrl = sb.ToString();
            paramUrl = "?" + paramUrl.TrimStart('&');

            string actualUrl = m_BwhAddress + url + paramUrl;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(actualUrl);
            request.Method = "get";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader myreader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string responseText = myreader.ReadToEnd();

            return responseText;
        }
    }
}
