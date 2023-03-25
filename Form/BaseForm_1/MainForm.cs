using System;
using System.Windows.Forms;

namespace BaseForm_1
{
    public partial class MainForm : Common.BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SuccessMSG(null);
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            InitServersView();
        }


        private void InitServersView()
        {
            lvServers.BeginUpdate();
            lvServers.Items.Clear();

            lvServers.GridLines = true;
            lvServers.FullRowSelect = true;
            lvServers.View = View.Details;
            lvServers.Scrollable = true;
            lvServers.MultiSelect = true;
            lvServers.HeaderStyle = ColumnHeaderStyle.Clickable;
            lvServers.RegisterDragEvent(UpdateDragEventHandler);

            lvServers.Columns.Add("", 30);
            lvServers.Columns.Add("LvServiceType", 80);
            lvServers.Columns.Add("LvAlias", 100);
            lvServers.Columns.Add("LvAddress", 120);
            lvServers.Columns.Add("LvPort", 100);
            lvServers.Columns.Add(".LvEncryptionMethod", 120);
            lvServers.Columns.Add("LvTransportProtocol", 120);
            lvServers.Columns.Add("LvTLS", 100);
            lvServers.Columns.Add("LvSubscription", 100);
            lvServers.Columns.Add("LvTestResults", 120, HorizontalAlignment.Right);

            
                lvServers.Columns.Add("LvTodayDownloadDataAmount", 70);
                lvServers.Columns.Add("LvTodayUploadDataAmount", 70);
                lvServers.Columns.Add("LvTotalDownloadDataAmount", 70);
                lvServers.Columns.Add("LvTotalUploadDataAmount", 70);
            
            lvServers.EndUpdate();
        }

        private void UpdateDragEventHandler(int index, int targetIndex)
        {
            if (index < 0 || targetIndex < 0)
            {
                return;
            }

        }
    }
}
