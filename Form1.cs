using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StarLabs.CashDrawer;

namespace CashDrawerDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private async void btnDiscovery_Click(object sender, EventArgs e) 
        {
            if (drawerListView1.Items.Count != 0) { drawerListView1.Items.Clear(); }

            List<StarUsbCashDrawer> connectedCashDrawers = await StarUsbCashDrawer.Discover();

            if (connectedCashDrawers.Count == 0)
            {
                btnGetStatus.Enabled = false; btnOpenTill.Enabled = false;
                textBox1.Visible = true;
            }
            else
            {
                textBox1.Visible = false;
                foreach (StarUsbCashDrawer cashDrawer in connectedCashDrawers)
                {
                    drawerListView1.Items.Add(cashDrawer.modelName).SubItems.Add(cashDrawer.port.ToString());
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnOpenTill_Click(object sender, EventArgs e)
        {
            int drawerNumber = Int32.Parse(drawerListView1.SelectedItems[0].SubItems[1].Text);

            StarUsbCashDrawer cashDrawer = new StarUsbCashDrawer(drawerNumber);
            bool success = await cashDrawer.OpenTill(cashDrawer.port);

            if (!success) { 
                MessageBox.Show($"Could not open Cash Drawer { cashDrawer.port }", "OpenTill Result");
            }

        }

        private async void btnGetStatus_Click(object sender, EventArgs e)
        {
            string strStatus = "";
            int drawerNumber = Int32.Parse(drawerListView1.SelectedItems[0].SubItems[1].Text);

            StarUsbCashDrawer cashDrawer = new StarUsbCashDrawer(drawerNumber);
            int status = await cashDrawer.GetDrawerStatus(cashDrawer.port);

            // 0 = not connected/couldn't get status
            // 1 = closed
            // 2 = open

            switch (status) {
                case 0:
                    strStatus = "Not Connected";
                    break;
                case 1:
                    strStatus = "Closed";
                    break;
                case 2:
                    strStatus = "Open";
                    break;
            }
            MessageBox.Show($"Cash Drawer {cashDrawer.port} status: {strStatus}");
        }

        private void drawerListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGetStatus.Enabled = false;
            btnOpenTill.Enabled = false;

            if (drawerListView1.Items.Count > 0)
            {
                btnGetStatus.Enabled = true;
                btnOpenTill.Enabled = true;
            }
        }
    }
}
