using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Head_Lamp.Model
{
    class PassQuan
    {
        string orderQuan;
        string process1PassQuan;
        string process2PassQuan;
        string process3PassQuan;
        string process4PassQuan;
        string process5PassQuan;

        public PassQuan(string orderQuan, string process1PassQuan, 
            string process2PassQuan, string process3PassQuan, 
            string process4PassQuan, string process5PassQuan)
        {
            this.orderQuan = orderQuan;
            this.process1PassQuan = process1PassQuan;
            this.process2PassQuan = process2PassQuan;
            this.process3PassQuan = process3PassQuan;
            this.process4PassQuan = process4PassQuan;
            this.process5PassQuan = process5PassQuan;
        }

        public string OrderQuan { get => orderQuan; set => orderQuan = value; }
        public string Process1PassQuan { get => process1PassQuan; set => process1PassQuan = value; }
        public string Process2PassQuan { get => process2PassQuan; set => process2PassQuan = value; }
        public string Process3PassQuan { get => process3PassQuan; set => process3PassQuan = value; }
        public string Process4PassQuan { get => process4PassQuan; set => process4PassQuan = value; }
        public string Process5PassQuan { get => process5PassQuan; set => process5PassQuan = value; }
    }
}
