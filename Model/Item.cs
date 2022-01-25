using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Head_Lamp.Model
{
    class Item
    {
        string itemNum;
        string itemName;

        public Item(string itemNum, string itemName)
        {
            this.itemNum = itemNum;
            this.itemName = itemName;
        }

        public Item(string itemNum)
        {
            this.itemNum = itemNum;
        }

        public string ItemNum { get => itemNum; set => itemNum = value; }
        public string ItemName { get => itemName; set => itemName = value; }
    }
}
