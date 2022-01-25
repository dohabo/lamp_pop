using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Head_Lamp.Model
{
    class Process3
    {
        string machineWorkNum;
        string startTime;
        string finishTime;
        string passQuan;
        string failQuan;

        public Process3(string machineWorkNum, string startTime, 
            string finishTime, string passQuan, string failQuan)
        {
            this.machineWorkNum = machineWorkNum;
            this.startTime = startTime;
            this.finishTime = finishTime;
            this.passQuan = passQuan;
            this.failQuan = failQuan;
        }

        public string MachineWorkNum { get => machineWorkNum; set => machineWorkNum = value; }
        public string StartTime { get => startTime; set => startTime = value; }
        public string FinishTime { get => finishTime; set => finishTime = value; }
        public string PassQuan { get => passQuan; set => passQuan = value; }
        public string FailQuan { get => failQuan; set => failQuan = value; }
    }
}
