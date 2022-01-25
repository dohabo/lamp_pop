using Car_Head_Lamp.DAO;
using Car_Head_Lamp.Network;
using Car_Head_Lamp.UI;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Threading.Timer;

namespace Car_Head_Lamp
{
    public partial class MainForm : MaterialForm
    {
        const string UC_NAME_HOMEUI = "HomeUI";
        const string UC_NAME_WORKORDERUI = "WorkOrderUI";
        const string UC_NAME_PROCESS1UI = "Process1UI";
        const string UC_NAME_PROCESS2UI = "Process2UI";
        const string UC_NAME_PROCESS3UI = "Process3UI";
        const string UC_NAME_PROCESS4UI = "Process4UI";
        const string UC_NAME_PROCESS5UI = "Process5UI";

        public MainForm()
        {
            InitializeComponent();
            OraMgr.Instance.connectDB();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            WorkOrderUI workorderUI = new WorkOrderUI();
            controllView(workorderUI, UC_NAME_WORKORDERUI);
        }

        private void addWorkOrder_Click(object sender, EventArgs e)
        {
            WorkOrderUI workorderUI = new WorkOrderUI();
            controllView(workorderUI, UC_NAME_WORKORDERUI);
        }
        
        private void goHome_Click(object sender, EventArgs e)
        {
            HomeUI homeUI = new HomeUI();
            controllView(homeUI, UC_NAME_HOMEUI);
        }

        private void showProcess1_Click(object sender, EventArgs e)
        {
            Process1UI process1UI = new Process1UI();
            controllView(process1UI, UC_NAME_PROCESS1UI);
        }

        private void showProcess2_Click(object sender, EventArgs e)
        {
            Process2UI process2UI = new Process2UI();
            controllView(process2UI, UC_NAME_PROCESS2UI);
        }

        private void showProcess3_Click(object sender, EventArgs e)
        {
            Process3UI process3UI = new Process3UI();
            controllView(process3UI, UC_NAME_PROCESS3UI);
        }

        private void showProcess4_Click(object sender, EventArgs e)
        {
            Process4UI process4UI = new Process4UI();
            controllView(process4UI, UC_NAME_PROCESS4UI);
        }

        private void showProcess5_Click(object sender, EventArgs e)
        {
            Process5UI process5UI = new Process5UI();
            controllView(process5UI, UC_NAME_PROCESS5UI);
        }

        public void controllView(UserControl uc, string viewName)
        {
            if (!centerLayout.Controls.ContainsKey(viewName))
            {
                centerLayout.Controls.Add(uc);
            }
            centerLayout.Controls[viewName].BringToFront();
        }
    }
}
