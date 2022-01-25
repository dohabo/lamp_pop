
namespace Car_Head_Lamp.UI
{
    partial class WorkOrderUI
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
            this.workOrderListView = new System.Windows.Forms.ListView();
            this.list_orderNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_itemNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_orderQuan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_state = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_accumPassQuan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_accumFailQuan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.workMeth = new Sunny.UI.UIComboBox();
            this.addWorkOrder = new Sunny.UI.UISymbolButton();
            this.quan = new Sunny.UI.UITextBox();
            this.DeleteWorkOrder = new Sunny.UI.UISymbolButton();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.item = new Sunny.UI.UIComboBox();
            this.SuspendLayout();
            // 
            // workOrderListView
            // 
            this.workOrderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.list_orderNum,
            this.list_itemNum,
            this.list_orderQuan,
            this.list_state,
            this.list_accumPassQuan,
            this.list_accumFailQuan});
            this.workOrderListView.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.workOrderListView.FullRowSelect = true;
            this.workOrderListView.HideSelection = false;
            this.workOrderListView.Location = new System.Drawing.Point(16, 235);
            this.workOrderListView.Name = "workOrderListView";
            this.workOrderListView.Size = new System.Drawing.Size(913, 382);
            this.workOrderListView.TabIndex = 1;
            this.workOrderListView.UseCompatibleStateImageBehavior = false;
            this.workOrderListView.View = System.Windows.Forms.View.Details;
            // 
            // list_orderNum
            // 
            this.list_orderNum.Text = "작업 번호";
            this.list_orderNum.Width = 120;
            // 
            // list_itemNum
            // 
            this.list_itemNum.Text = "품목번호";
            this.list_itemNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_itemNum.Width = 120;
            // 
            // list_orderQuan
            // 
            this.list_orderQuan.Text = "지시 수량";
            this.list_orderQuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_orderQuan.Width = 100;
            // 
            // list_state
            // 
            this.list_state.Text = "완료여부";
            this.list_state.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_state.Width = 120;
            // 
            // list_accumPassQuan
            // 
            this.list_accumPassQuan.Text = "현재 공정 양품 수량";
            this.list_accumPassQuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_accumPassQuan.Width = 160;
            // 
            // list_accumFailQuan
            // 
            this.list_accumFailQuan.Text = "현재 공정 불량 수량";
            this.list_accumFailQuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_accumFailQuan.Width = 160;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "작업 지시 등록";
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(16, 55);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(195, 44);
            this.uiSymbolLabel1.TabIndex = 8;
            this.uiSymbolLabel1.Text = "작업 등록 방법";
            this.uiSymbolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // workMeth
            // 
            this.workMeth.DataSource = null;
            this.workMeth.FillColor = System.Drawing.Color.White;
            this.workMeth.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.workMeth.Items.AddRange(new object[] {
            "자동 등록",
            "수동 등록"});
            this.workMeth.Location = new System.Drawing.Point(230, 55);
            this.workMeth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.workMeth.MinimumSize = new System.Drawing.Size(63, 0);
            this.workMeth.Name = "workMeth";
            this.workMeth.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.workMeth.Size = new System.Drawing.Size(150, 50);
            this.workMeth.TabIndex = 9;
            this.workMeth.Text = "선택하세요";
            this.workMeth.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.workMeth.TextChanged += new System.EventHandler(this.workMeth_TextChanged);
            // 
            // addWorkOrder
            // 
            this.addWorkOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addWorkOrder.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addWorkOrder.Location = new System.Drawing.Point(387, 109);
            this.addWorkOrder.MinimumSize = new System.Drawing.Size(1, 1);
            this.addWorkOrder.Name = "addWorkOrder";
            this.addWorkOrder.Size = new System.Drawing.Size(117, 50);
            this.addWorkOrder.Symbol = 61508;
            this.addWorkOrder.TabIndex = 10;
            this.addWorkOrder.Text = "작업 등록";
            this.addWorkOrder.Click += new System.EventHandler(this.addWorkOrder_Click);
            // 
            // quan
            // 
            this.quan.ButtonSymbol = 61761;
            this.quan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quan.FillColor = System.Drawing.Color.White;
            this.quan.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.quan.Location = new System.Drawing.Point(230, 165);
            this.quan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quan.Maximum = 2147483647D;
            this.quan.Minimum = -2147483648D;
            this.quan.MinimumSize = new System.Drawing.Size(1, 1);
            this.quan.Name = "quan";
            this.quan.Size = new System.Drawing.Size(150, 50);
            this.quan.TabIndex = 11;
            this.quan.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeleteWorkOrder
            // 
            this.DeleteWorkOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteWorkOrder.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.DeleteWorkOrder.Location = new System.Drawing.Point(387, 165);
            this.DeleteWorkOrder.MinimumSize = new System.Drawing.Size(1, 1);
            this.DeleteWorkOrder.Name = "DeleteWorkOrder";
            this.DeleteWorkOrder.Size = new System.Drawing.Size(117, 50);
            this.DeleteWorkOrder.Symbol = 61944;
            this.DeleteWorkOrder.TabIndex = 12;
            this.DeleteWorkOrder.Text = "작업 삭제";
            this.DeleteWorkOrder.Click += new System.EventHandler(this.DeleteWorkOrder_Click);
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel2.Location = new System.Drawing.Point(16, 109);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(191, 50);
            this.uiSymbolLabel2.TabIndex = 13;
            this.uiSymbolLabel2.Text = "품목 번호";
            this.uiSymbolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolLabel3.Location = new System.Drawing.Point(16, 165);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(191, 46);
            this.uiSymbolLabel3.TabIndex = 14;
            this.uiSymbolLabel3.Text = "작업 지시 수량";
            this.uiSymbolLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // item
            // 
            this.item.DataSource = null;
            this.item.FillColor = System.Drawing.Color.White;
            this.item.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.item.Location = new System.Drawing.Point(230, 109);
            this.item.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.item.MinimumSize = new System.Drawing.Size(63, 0);
            this.item.Name = "item";
            this.item.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.item.Size = new System.Drawing.Size(150, 50);
            this.item.TabIndex = 10;
            this.item.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WorkOrderUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.item);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.DeleteWorkOrder);
            this.Controls.Add(this.quan);
            this.Controls.Add(this.addWorkOrder);
            this.Controls.Add(this.workMeth);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.workOrderListView);
            this.Name = "WorkOrderUI";
            this.Size = new System.Drawing.Size(955, 635);
            this.Load += new System.EventHandler(this.WorkOrderUI_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView workOrderListView;
        private System.Windows.Forms.ColumnHeader list_orderNum;
        private System.Windows.Forms.ColumnHeader list_itemNum;
        private System.Windows.Forms.ColumnHeader list_orderQuan;
        private System.Windows.Forms.ColumnHeader list_state;
        private System.Windows.Forms.ColumnHeader list_accumPassQuan;
        private System.Windows.Forms.ColumnHeader list_accumFailQuan;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UIComboBox workMeth;
        private Sunny.UI.UISymbolButton addWorkOrder;
        private Sunny.UI.UITextBox quan;
        private Sunny.UI.UISymbolButton DeleteWorkOrder;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UIComboBox item;
    }
}
