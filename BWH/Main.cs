using System;
using System.Threading;
using System.Windows.Forms;

namespace BandwagonHelper
{
    public partial class frmMain : Form
    {
        private string m_Veid = "";
        private string m_ApiKey = "";
        private string m_BwhAddress = "";

        private Service m_Service = null;

        public frmMain()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            if (CheckUserInfo())
            {
                m_Service = new Service(m_BwhAddress, m_Veid, m_ApiKey);
                RefreshUIServerStatus();
            }
            else
            {
                ShowUserInfoWindow();
            }
        }

        private bool CheckUserInfo()
        {
            bool result = false;
            m_Veid = Utility.GetSetting("veid");
            m_ApiKey = Utility.GetSetting("apiKey");
            m_BwhAddress = Utility.GetSetting("bwhAddress");
            if (m_Veid.Length > 0 && m_ApiKey.Length > 0 && m_BwhAddress.Length > 0)
            {
                result = true;
            }
            return result;
        }

        private void ShowUserInfoWindow()
        {
            UserInfo userInfo = new UserInfo();
            userInfo.FormClosed += UserInfo_FormClosed;
            userInfo.ShowDialog();
        }

        private void UserInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Init();
        }

        private void RefreshUIServerStatus()
        {
            LiveServerStatusJson serverStatus = m_Service.GetLiveServiceInfo();
            string status = serverStatus.Status;
            gpbServerStatus.Text = string.Format("Server : [{0}]", status);

            decimal planData = serverStatus.PlanMonthlyData / 1024 / 1024 / 1024;
            decimal usedData = serverStatus.DataCounter / 1024 / 1024 / 1024;
            decimal percentage = (usedData / planData) * 100;

            lblHostName.Text = serverStatus.HostName;
            lblOperatingSystem.Text = serverStatus.OperatingSystem;
            lblNodeAlias.Text = serverStatus.NodeAlias;
            lblNodeDataCenter.Text = serverStatus.NodeDataCenter;
            lblNodeIp.Text = serverStatus.NodeIp;
            lblNodeLocation.Text = serverStatus.NodeLocation;

            lblServicePlan.Text = serverStatus.ServicePlan;
            lblPlanDisk.Text = (serverStatus.PlanDisk / 1024 / 1024 / 1024).ToString() + " G";
            lblPlanMonthlyData.Text = planData.ToString() + " G";
            lblPlanRam.Text = (serverStatus.PlanRam / 1024 / 1024).ToString() + " M";

            lblDataCounter.Text = string.Format("{0} G ({1}%)", usedData.ToString("0.###"), percentage.ToString("0.##"));
            lblDataNextReset.Text = Utility.UnixTimeStampToDateTime(serverStatus.DataNextReset).ToString();
        }

        private void refreshMenuItem_Click(object sender, EventArgs e)
        {
            RefreshUIServerStatus();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            m_Service.StartServer();
            Thread.Sleep(2000);
            RefreshUIServerStatus();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            m_Service.RestartServer();
            Thread.Sleep(2000);
            RefreshUIServerStatus();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            m_Service.StopServer();
            Thread.Sleep(2000);
            RefreshUIServerStatus();
        }
    }
}
