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
    partial class WorkOrderUI : UserControl
    {
        Random r = new Random();
        ThingSpeak ts = new ThingSpeak();
        ThingSpeakTimer sTimer, p1Timer, p2Timer, p3Timer, p4Timer, p5Timer, rTimer;

        private void DeleteWorkOrder_Click(object sender, EventArgs e)
        {
            int n = workOrderListView.SelectedItems[0].Index;
            string orderNum = workOrderListView.Items[n].SubItems[0].Text;
            string state = workOrderListView.Items[n].SubItems[3].Text;
            if (state != "작업대기")
            {
                MessageBox.Show("현재 공정 진행 중으로 삭제 할 수 없는 작업오더입니다.");
            }
            else
            {
                OraMgr.Instance.DeleteWorkDB(orderNum);
            }
        }

        private void WorkOrderUI_Load(object sender, EventArgs e)
        {
            List<Item> itemList = OraMgr.Instance.getItem();
            for (int i = 0; i < itemList.Count; i++)
            {
                item.Items.AddRange(new string[]
                {
                    itemList[i].ItemNum
                });
            }
        }

        private void addWorkOrder_Click(object sender, EventArgs e)
        {
            if (item.Text == "선택하세요" || quan.Text == "")
            {
                MessageBox.Show("품목번호 선택 또는 작업 지시 수량을 입력하세요");
            }
            else
            {
                OraMgr.Instance.insertWork(item.Text, int.Parse(quan.Text));
                MessageBox.Show("작업 지시 등록이 완료 되었습니다.");
            }
        }

        public WorkOrderUI()
        {
            InitializeComponent();
            rTimer = new ThingSpeakTimer(
                new Timer(new TimerCallback(readWorkDB),
                null, 1000, 2200));
        }

        private void workMeth_TextChanged(object sender, EventArgs e)
        {
            if (workMeth.Text == "자동 등록")
            {
                sTimer = new ThingSpeakTimer(
                new Timer(new TimerCallback(writeHandler),
                null, 1000, 60000));
                p1Timer = new ThingSpeakTimer(
                new Timer(new TimerCallback(writeHandler1),
                null, 11000, 60000));
                p2Timer = new ThingSpeakTimer(
                new Timer(new TimerCallback(writeHandler2),
                null, 21000, 60000));
                p3Timer = new ThingSpeakTimer(
                new Timer(new TimerCallback(writeHandler3),
                null, 31000, 60000));
                p4Timer = new ThingSpeakTimer(
                new Timer(new TimerCallback(writeHandler4),
                null, 41000, 60000));
                p5Timer = new ThingSpeakTimer(
                new Timer(new TimerCallback(writeHandler5),
                null, 51000, 60000));
            }
            else if (workMeth.Text == "수동 등록")
            {

            }
        }

        void writeHandler(object args)
        {
            string itemNum = OraMgr.Instance.getRanItem(r.Next(1, 11));
            OraMgr.Instance.insertAutoOrderDB(itemNum);
            OraMgr.Instance.commitDB();
        }

        void writeHandler1(object args)
        {
            int orderNum = OraMgr.Instance.getAutoOrderNum();
            int process1_PassQuan = r.Next(98, 101);
            OraMgr.Instance.insertProcess1DB(orderNum, process1_PassQuan);
            OraMgr.Instance.commitDB();
            OraMgr.Instance.UpdateWork1DB(orderNum);
            OraMgr.Instance.commitDB();
        }

        void writeHandler2(object args)
        {
            int orderNum = OraMgr.Instance.getAutoOrderNum("1공정완료");
            int passNum = OraMgr.Instance.getProcess1PassNum(orderNum);
            int process2_PassQuan = r.Next(passNum - 2, passNum + 1);
            OraMgr.Instance.insertProcess2DB(orderNum, process2_PassQuan, passNum);
            OraMgr.Instance.commitDB();
            OraMgr.Instance.UpdateWork2DB(orderNum, passNum);
            OraMgr.Instance.commitDB();
        }

        void writeHandler3(object args)
        {
            int orderNum = OraMgr.Instance.getAutoOrderNum("2공정완료");
            int passNum = OraMgr.Instance.getProcess2PassNum(orderNum);
            int process3_PassQuan = r.Next(passNum - 2, passNum + 1);
            OraMgr.Instance.insertProcess3DB(orderNum, process3_PassQuan, passNum);
            OraMgr.Instance.commitDB();
            OraMgr.Instance.UpdateWork3DB(orderNum);
            OraMgr.Instance.commitDB();
        }

        void writeHandler4(object args)
        {
            int orderNum = OraMgr.Instance.getAutoOrderNum("3공정완료");
            int passNum = OraMgr.Instance.getProcess3PassNum(orderNum);
            int process4_PassQuan = r.Next(passNum - 2, passNum + 1);
            OraMgr.Instance.insertProcess4DB(orderNum, process4_PassQuan, passNum);
            OraMgr.Instance.commitDB();
            OraMgr.Instance.UpdateWork4DB(orderNum);
            OraMgr.Instance.commitDB();
        }

        void writeHandler5(object args)
        {
            int orderNum = OraMgr.Instance.getAutoOrderNum("4공정완료");
            int passNum = OraMgr.Instance.getProcess4PassNum(orderNum);
            int process5_PassQuan = r.Next(passNum - 2, passNum + 1);
            OraMgr.Instance.insertProcess5DB(orderNum, process5_PassQuan, passNum);
            OraMgr.Instance.commitDB();
            OraMgr.Instance.UpdateWork5DB(orderNum);
            OraMgr.Instance.commitDB();

            int passquan1 = OraMgr.Instance.getProcess1PassNum(orderNum);
            int passquan2 = OraMgr.Instance.getProcess2PassNum(orderNum);
            int passquan3 = OraMgr.Instance.getProcess3PassNum(orderNum);
            int passquan4 = OraMgr.Instance.getProcess4PassNum(orderNum);
            int passquan5 = OraMgr.Instance.getProcess5PassNum(orderNum);

            bool chk = ts.sendDataToThingSpeak(
                "100", passquan1, passquan2, passquan3, passquan4, passquan5,
                null, null);

            if (chk == true)
            {
                Console.WriteLine("데이터 전송 성공!");
            }
            else
            {
                Console.WriteLine("데이터 전송 실패!");
            }
        }

        void getWriteInfo(object args)
        {
            string itemNum = OraMgr.Instance.getRanItem(r.Next(0, 11));
            string orderNum = OraMgr.Instance.getOrderNum();
            string orderQuan = OraMgr.Instance.getOrderQuan();
            int process1_PassQuan = r.Next(98, 101);
            int process2_PassQuan = r.Next(process1_PassQuan - 2, process1_PassQuan + 1);
            int process3_PassQuan = r.Next(process2_PassQuan - 2, process2_PassQuan + 1);
            int process4_PassQuan = r.Next(process3_PassQuan - 2, process3_PassQuan + 1);
            int process5_PassQuan = r.Next(process4_PassQuan - 2, process4_PassQuan + 1);

        }

        void readWorkDB(object args)
        {
            workOrderListView.Items.Clear();
            List<Work> list = OraMgr.Instance.getWorkInfo();
            initWorkOrderListView(list, workOrderListView);
        }

        public void initWorkOrderListView(List<Work> worklist, ListView workOrderListView)
        {
            for (int i = 0; i < worklist.Count; i++)
            {
                workOrderListView.Items.Add(new ListViewItem(new string[]
                {
                    worklist[i].OrderNum.ToString(),
                    worklist[i].ItemNum,
                    worklist[i].OrderQuan.ToString(),
                    worklist[i].State,
                    worklist[i].AccumPassQuan.ToString(),
                    worklist[i].AccumFailQuan.ToString()
                }));
            }
        }
    }
}
