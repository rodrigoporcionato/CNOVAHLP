using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNOVAHLP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
            cbmSite.DataSource = Enum.GetValues(typeof(Sites));
            cmbPoolsList.DataSource = ApplicationPools.GetListAppPools();
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            var host = new Hosts();
            var listHostSelect = host.HostList((Sites)cbmSite.SelectedItem);
            ChangeHostFile(listHostSelect);
            TestPing(listHostSelect);
        }
        private void btnDesligar_Click(object sender, EventArgs e)
        {
            var pathHost = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/hosts");
            using (StreamWriter w = new StreamWriter(pathHost, false))
            {
                w.WriteLine("");
            }
            txtStatusSite.Text = "Desligado...";
        }


        private void TestPing(List<Hosts> listHostSelect)
        {
            txtStatusSite.Text = "Retorno do Ping no Site \r\n";
            listHostSelect.ForEach(x =>
            {
                Ping p = new Ping();
                PingReply r = p.Send(x.HostName);
                if (r.Status == IPStatus.Success)
                {
                    if (r.Address.ToString() == x.IP)
                    {
                        txtStatusSite.Text += "RESPONDENDO CORRETAMENTE - " + x.HostName + " [" + x.IP + "] Response Delay = " + r.RoundtripTime.ToString() + "ms" + "\r\n";
                    }
                    else
                    {
                        txtStatusSite.Text += "RESPONDENDO PARA UM IP DIFERENTE! - " + x.HostName + " [" + x.IP + "] Response Delay = " + r.RoundtripTime.ToString() + "ms" + "\r\n";
                    }
                }
                else
                {
                    txtStatusSite.Text += "FALHA NO PING - " + x.HostName + " [" + x.IP + "] Response Delay = " + r.RoundtripTime.ToString() + "ms" + "\r\n";
                }
            });
        }
        private void ChangeHostFile(List<Hosts> hostname) {

            var pathHost = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/hosts");

            using (StreamWriter w = new StreamWriter(pathHost, false))
            {
                foreach (var h in hostname)
                {
                    w.WriteLine(h.IP + " " + h.HostName);
                }
            }
        }

        private void btnRecyclePool_Click(object sender, EventArgs e)
        {
            if (cmbPoolsList.SelectedItem!=null)
            {
                ApplicationPools.RecycleAppPool(cmbPoolsList.SelectedItem.ToString().Split('|')[0]);
            }
        }
    }
}
