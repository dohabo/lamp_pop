
namespace Car_Head_Lamp.UI
{
    partial class Process3UI
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.processBarChart = new Sunny.UI.UIBarChart();
            this.processPieChart = new Sunny.UI.UIPieChart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchProcess = new Sunny.UI.UISymbolButton();
            this.orderQuan = new Sunny.UI.UITextBox();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.state = new Sunny.UI.UIComboBox();
            this.itemNum = new Sunny.UI.UIComboBox();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.orderNum = new Sunny.UI.UIComboBox();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.processListView = new System.Windows.Forms.ListView();
            this.list_WorkOrderNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_Quan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_StartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_FinishTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_PassQuan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_FailQuan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // processBarChart
            // 
            this.processBarChart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.processBarChart.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.processBarChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.processBarChart.Location = new System.Drawing.Point(612, 139);
            this.processBarChart.MinimumSize = new System.Drawing.Size(1, 1);
            this.processBarChart.Name = "processBarChart";
            this.processBarChart.Size = new System.Drawing.Size(330, 236);
            this.processBarChart.TabIndex = 7;
            this.processBarChart.Text = "uiBarChart1";
            // 
            // processPieChart
            // 
            this.processPieChart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.processPieChart.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.processPieChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.processPieChart.Location = new System.Drawing.Point(612, 390);
            this.processPieChart.MinimumSize = new System.Drawing.Size(1, 1);
            this.processPieChart.Name = "processPieChart";
            this.processPieChart.Size = new System.Drawing.Size(330, 231);
            this.processPieChart.TabIndex = 5;
            this.processPieChart.Text = "uiPieChart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.searchProcess);
            this.panel1.Controls.Add(this.orderQuan);
            this.panel1.Controls.Add(this.uiSymbolLabel4);
            this.panel1.Controls.Add(this.uiSymbolLabel3);
            this.panel1.Controls.Add(this.state);
            this.panel1.Controls.Add(this.itemNum);
            this.panel1.Controls.Add(this.uiSymbolLabel2);
            this.panel1.Controls.Add(this.orderNum);
            this.panel1.Controls.Add(this.uiSymbolLabel1);
            this.panel1.Location = new System.Drawing.Point(16, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 97);
            this.panel1.TabIndex = 8;
            // 
            // searchProcess
            // 
            this.searchProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchProcess.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProcess.Location = new System.Drawing.Point(634, 13);
            this.searchProcess.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchProcess.Name = "searchProcess";
            this.searchProcess.Size = new System.Drawing.Size(117, 76);
            this.searchProcess.Symbol = 61442;
            this.searchProcess.TabIndex = 6;
            this.searchProcess.Text = "검색";
            // 
            // orderQuan
            // 
            this.orderQuan.ButtonSymbol = 61761;
            this.orderQuan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.orderQuan.FillColor = System.Drawing.Color.White;
            this.orderQuan.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.orderQuan.Location = new System.Drawing.Point(477, 54);
            this.orderQuan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orderQuan.Maximum = 2147483647D;
            this.orderQuan.Minimum = -2147483648D;
            this.orderQuan.MinimumSize = new System.Drawing.Size(1, 1);
            this.orderQuan.Name = "orderQuan";
            this.orderQuan.Size = new System.Drawing.Size(130, 30);
            this.orderQuan.TabIndex = 5;
            this.orderQuan.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel4.Location = new System.Drawing.Point(316, 54);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(154, 35);
            this.uiSymbolLabel4.TabIndex = 4;
            this.uiSymbolLabel4.Text = "작업 지시 수량";
            this.uiSymbolLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel3.Location = new System.Drawing.Point(14, 49);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(147, 35);
            this.uiSymbolLabel3.TabIndex = 2;
            this.uiSymbolLabel3.Text = "품목번호";
            this.uiSymbolLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // state
            // 
            this.state.DataSource = null;
            this.state.FillColor = System.Drawing.Color.White;
            this.state.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.state.Location = new System.Drawing.Point(477, 13);
            this.state.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.state.MinimumSize = new System.Drawing.Size(63, 0);
            this.state.Name = "state";
            this.state.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.state.Size = new System.Drawing.Size(130, 30);
            this.state.TabIndex = 3;
            this.state.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // itemNum
            // 
            this.itemNum.DataSource = null;
            this.itemNum.FillColor = System.Drawing.Color.White;
            this.itemNum.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.itemNum.Location = new System.Drawing.Point(168, 54);
            this.itemNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.itemNum.MinimumSize = new System.Drawing.Size(63, 0);
            this.itemNum.Name = "itemNum";
            this.itemNum.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.itemNum.Size = new System.Drawing.Size(130, 30);
            this.itemNum.TabIndex = 3;
            this.itemNum.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(316, 13);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(154, 35);
            this.uiSymbolLabel2.TabIndex = 2;
            this.uiSymbolLabel2.Text = "완료여부";
            this.uiSymbolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // orderNum
            // 
            this.orderNum.DataSource = null;
            this.orderNum.FillColor = System.Drawing.Color.White;
            this.orderNum.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.orderNum.Location = new System.Drawing.Point(168, 13);
            this.orderNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orderNum.MinimumSize = new System.Drawing.Size(63, 0);
            this.orderNum.Name = "orderNum";
            this.orderNum.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.orderNum.Size = new System.Drawing.Size(130, 30);
            this.orderNum.TabIndex = 1;
            this.orderNum.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(14, 8);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(147, 35);
            this.uiSymbolLabel1.TabIndex = 0;
            this.uiSymbolLabel1.Text = "작업 지시 번호";
            this.uiSymbolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "3공정 생산 현황";
            // 
            // processListView
            // 
            this.processListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.list_WorkOrderNum,
            this.list_Item,
            this.list_Quan,
            this.list_StartTime,
            this.list_FinishTime,
            this.list_PassQuan,
            this.list_FailQuan});
            this.processListView.FullRowSelect = true;
            this.processListView.HideSelection = false;
            this.processListView.Location = new System.Drawing.Point(16, 139);
            this.processListView.Name = "processListView";
            this.processListView.Size = new System.Drawing.Size(580, 482);
            this.processListView.TabIndex = 9;
            this.processListView.UseCompatibleStateImageBehavior = false;
            this.processListView.View = System.Windows.Forms.View.Details;
            // 
            // list_WorkOrderNum
            // 
            this.list_WorkOrderNum.Text = "작업 번호";
            this.list_WorkOrderNum.Width = 70;
            // 
            // list_Item
            // 
            this.list_Item.Text = "품목번호";
            this.list_Item.Width = 70;
            // 
            // list_Quan
            // 
            this.list_Quan.Text = "지시 수량";
            this.list_Quan.Width = 80;
            // 
            // list_StartTime
            // 
            this.list_StartTime.Text = "작업 시작 시간";
            this.list_StartTime.Width = 100;
            // 
            // list_FinishTime
            // 
            this.list_FinishTime.Text = "작업 종료 시간";
            this.list_FinishTime.Width = 100;
            // 
            // list_PassQuan
            // 
            this.list_PassQuan.Text = "양품 수량";
            this.list_PassQuan.Width = 70;
            // 
            // list_FailQuan
            // 
            this.list_FailQuan.Text = "불량 수량";
            this.list_FailQuan.Width = 70;
            // 
            // Process3UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.processListView);
            this.Controls.Add(this.processBarChart);
            this.Controls.Add(this.processPieChart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Process3UI";
            this.Size = new System.Drawing.Size(955, 635);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIBarChart processBarChart;
        private Sunny.UI.UIPieChart processPieChart;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UISymbolButton searchProcess;
        private Sunny.UI.UITextBox orderQuan;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UIComboBox state;
        private Sunny.UI.UIComboBox itemNum;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UIComboBox orderNum;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView processListView;
        private System.Windows.Forms.ColumnHeader list_WorkOrderNum;
        private System.Windows.Forms.ColumnHeader list_Item;
        private System.Windows.Forms.ColumnHeader list_Quan;
        private System.Windows.Forms.ColumnHeader list_StartTime;
        private System.Windows.Forms.ColumnHeader list_FinishTime;
        private System.Windows.Forms.ColumnHeader list_PassQuan;
        private System.Windows.Forms.ColumnHeader list_FailQuan;
    }
}
