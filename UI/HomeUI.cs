using Car_Head_Lamp.DAO;
using Car_Head_Lamp.Model;
using Car_Head_Lamp.Network;
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

namespace Car_Head_Lamp.UI
{
    public partial class HomeUI : UserControl
    {
        ThingSpeak ts = new ThingSpeak();
        ThingSpeakTimer totalTimer, rp1Timer, rp2Timer, rp3Timer, rp4Timer, rp5Timer;

        private void HomeUI_Load(object sender, EventArgs e)
        {
            totalTimer = new ThingSpeakTimer(new Timer(
                new TimerCallback(readHandler),
                null, 60000, 60000));
            rp1Timer = new ThingSpeakTimer(new Timer(
                new TimerCallback(readHandler1),
                null, 1000, 10000));
            rp2Timer = new ThingSpeakTimer(new Timer(
                new TimerCallback(readHandler2),
                null, 2000, 10000));
            rp3Timer = new ThingSpeakTimer(new Timer(
                new TimerCallback(readHandler3),
                null, 3000, 10000));
            rp4Timer = new ThingSpeakTimer(new Timer(
                new TimerCallback(readHandler4),
                null, 4000, 10000));
            rp5Timer = new ThingSpeakTimer(new Timer(
                new TimerCallback(readHandler5),
                null, 5000, 10000));
        }
        void readHandler(object args)
        {
            List<PassQuan> list = ts.readThingSpeak();
            for(int i = 0; i< list.Count; i++)
            {
                int passNum = int.Parse(list[i].Process5PassQuan);
                int failNum = 100 - passNum;
                total_orderQuan.Text = (int.Parse(total_orderQuan.Text) + 
                    int.Parse(list[i].OrderQuan)).ToString();
                total_passQuan.Text = (int.Parse(total_passQuan.Text) +
                    int.Parse(list[i].Process5PassQuan)).ToString();
                total_failQuan.Text = (int.Parse(total_failQuan.Text) + failNum).ToString();
                failRate.Text =
                    ((double.Parse(total_failQuan.Text) / double.Parse(total_orderQuan.Text))*100).ToString("F2") + "%";
            }
        }
        void readHandler1(object args)
        {
            List<Work> workList = new List<Work>();
            workList = OraMgr.Instance.getProcess1();
            if(workList.Count > 0) 
            {
                p1_item.Text = workList[0].ItemNum;
                p1_order.Text = workList[0].OrderNum.ToString();
                p1_ingQuan.Text = workList[0].OrderQuan.ToString();
                p1_passQuan.Text = "0";
                p1_failQuan.Text = "0";
                led_p1_ing.Color = Color.Yellow;
                led_p1_wait.Color = Color.Gray;
                OraMgr.Instance.commitDB();
            }
            else
            {
                led_p1_ing.Color = Color.Gray;
                led_p1_wait.Color = Color.Yellow;
                p1_passQuan.Text = OraMgr.Instance.getProcess1PassNum();
                p1_failQuan.Text = OraMgr.Instance.getProcess1FailNum();
            }
            
        }
        void readHandler2(object args)
        {
            List<Work> workList = new List<Work>();
            workList = OraMgr.Instance.getProcess2();
            if (workList.Count > 0)
            {
                p2_item.Text = workList[0].ItemNum;
                p2_order.Text = workList[0].OrderNum.ToString();
                p2_ingQuan.Text = workList[0].OrderQuan.ToString();
                p2_passQuan.Text = "0";
                p2_failQuan.Text = "0";
                led_p2_ing.Color = Color.Yellow;
                led_p2_wait.Color = Color.Gray;
                OraMgr.Instance.commitDB();
            }
            else
            {
                led_p2_ing.Color = Color.Gray;
                led_p2_wait.Color = Color.Yellow;
                p2_passQuan.Text = OraMgr.Instance.getProcess2PassNum();
                p2_failQuan.Text = OraMgr.Instance.getProcess2FailNum();
            }

        }
        void readHandler3(object args)
        {
            List<Work> workList = new List<Work>();
            workList = OraMgr.Instance.getProcess3();
            if (workList.Count > 0)
            {
                p3_item.Text = workList[0].ItemNum;
                p3_order.Text = workList[0].OrderNum.ToString();
                p3_ingQuan.Text = workList[0].OrderQuan.ToString();
                p3_passQuan.Text = "0";
                p3_failQuan.Text = "0";
                led_p3_ing.Color = Color.Yellow;
                led_p3_wait.Color = Color.Gray;
                OraMgr.Instance.commitDB();
            }
            else
            {
                led_p3_ing.Color = Color.Gray;
                led_p3_wait.Color = Color.Yellow;
                p3_passQuan.Text = OraMgr.Instance.getProcess3PassNum();
                p3_failQuan.Text = OraMgr.Instance.getProcess3FailNum();
            }

        }
        void readHandler4(object args)
        {
            List<Work> workList = new List<Work>();
            workList = OraMgr.Instance.getProcess4();
            if (workList.Count > 0)
            {
                p4_item.Text = workList[0].ItemNum;
                p4_order.Text = workList[0].OrderNum.ToString();
                p4_ingQuan.Text = workList[0].OrderQuan.ToString();
                p4_passQuan.Text = "0";
                p4_failQuan.Text = "0";
                led_p4_ing.Color = Color.Yellow;
                led_p4_wait.Color = Color.Gray;
                OraMgr.Instance.commitDB();
            }
            else
            {
                led_p4_ing.Color = Color.Gray;
                led_p4_wait.Color = Color.Yellow;
                p4_passQuan.Text = OraMgr.Instance.getProcess4PassNum();
                p4_failQuan.Text = OraMgr.Instance.getProcess4FailNum();
            }

        }
        void readHandler5(object args)
        {
            List<Work> workList = new List<Work>();
            workList = OraMgr.Instance.getProcess5();
            if (workList.Count > 0)
            {
                p5_item.Text = workList[0].ItemNum;
                p5_order.Text = workList[0].OrderNum.ToString();
                p5_ingQuan.Text = workList[0].OrderQuan.ToString();
                p5_passQuan.Text = "0";
                p5_failQuan.Text = "0";
                led_p5_ing.Color = Color.Yellow;
                led_p5_wait.Color = Color.Gray;
                OraMgr.Instance.commitDB();
            }
            else
            {
                led_p5_ing.Color = Color.Gray;
                led_p5_wait.Color = Color.Yellow;
                p5_passQuan.Text = OraMgr.Instance.getProcess5PassNum();
                p5_failQuan.Text = OraMgr.Instance.getProcess5FailNum();
            }

        }

        public HomeUI()
        {
            InitializeComponent();
        }
    }
}
