using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Head_Lamp.Model
{
    class Work
    {
        int orderNum;
        string itemNum;
        int orderQuan;
        string state;
        int accumPassQuan;
        int accumFailQuan;

        public Work(int orderNum, string itemNum, int orderQuan, 
            string state, int accumPassQuan, int accumFailQuan)
        {
            this.orderNum = orderNum;
            this.itemNum = itemNum;
            this.orderQuan = orderQuan;
            this.state = state;
            this.accumPassQuan = accumPassQuan;
            this.accumFailQuan = accumFailQuan;
        }

        public Work(string itemNum, int orderQuan)
        {
            this.itemNum = itemNum;
            this.orderQuan = orderQuan;
        }

        public Work(int orderNum, string itemNum, int orderQuan, string state)
        {
            this.orderNum = orderNum;
            this.itemNum = itemNum;
            this.orderQuan = orderQuan;
            this.state = state;
        }

        public int OrderNum { get => orderNum; set => orderNum = value; }
        public string ItemNum { get => itemNum; set => itemNum = value; }
        public int OrderQuan { get => orderQuan; set => orderQuan = value; }
        public string State { get => state; set => state = value; }
        public int AccumPassQuan { get => accumPassQuan; set => accumPassQuan = value; }
        public int AccumFailQuan { get => accumFailQuan; set => accumFailQuan = value; }
    }
}
