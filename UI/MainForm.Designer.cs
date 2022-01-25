
namespace Car_Head_Lamp
{
    partial class MainForm
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.showProcess1 = new Sunny.UI.UISymbolButton();
            this.showProcess2 = new Sunny.UI.UISymbolButton();
            this.showProcess3 = new Sunny.UI.UISymbolButton();
            this.showProcess4 = new Sunny.UI.UISymbolButton();
            this.showProcess5 = new Sunny.UI.UISymbolButton();
            this.addWorkOrder = new Sunny.UI.UISymbolButton();
            this.centerLayout = new System.Windows.Forms.Panel();
            this.goHome = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // showProcess1
            // 
            this.showProcess1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showProcess1.FillPressColor = System.Drawing.Color.RoyalBlue;
            this.showProcess1.FillSelectedColor = System.Drawing.Color.Blue;
            this.showProcess1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showProcess1.Location = new System.Drawing.Point(14, 251);
            this.showProcess1.Margin = new System.Windows.Forms.Padding(5);
            this.showProcess1.MinimumSize = new System.Drawing.Size(1, 1);
            this.showProcess1.Name = "showProcess1";
            this.showProcess1.Radius = 20;
            this.showProcess1.Size = new System.Drawing.Size(130, 80);
            this.showProcess1.Style = Sunny.UI.UIStyle.Custom;
            this.showProcess1.Symbol = 61573;
            this.showProcess1.TabIndex = 0;
            this.showProcess1.Text = "1공정 현황";
            this.showProcess1.Click += new System.EventHandler(this.showProcess1_Click);
            // 
            // showProcess2
            // 
            this.showProcess2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showProcess2.FillPressColor = System.Drawing.Color.RoyalBlue;
            this.showProcess2.FillSelectedColor = System.Drawing.Color.Blue;
            this.showProcess2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showProcess2.Location = new System.Drawing.Point(14, 341);
            this.showProcess2.Margin = new System.Windows.Forms.Padding(5);
            this.showProcess2.MinimumSize = new System.Drawing.Size(1, 1);
            this.showProcess2.Name = "showProcess2";
            this.showProcess2.Radius = 20;
            this.showProcess2.Size = new System.Drawing.Size(130, 80);
            this.showProcess2.Style = Sunny.UI.UIStyle.Custom;
            this.showProcess2.Symbol = 61573;
            this.showProcess2.TabIndex = 1;
            this.showProcess2.Text = "2공정 현황";
            this.showProcess2.Click += new System.EventHandler(this.showProcess2_Click);
            // 
            // showProcess3
            // 
            this.showProcess3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showProcess3.FillPressColor = System.Drawing.Color.RoyalBlue;
            this.showProcess3.FillSelectedColor = System.Drawing.Color.Blue;
            this.showProcess3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showProcess3.Location = new System.Drawing.Point(14, 431);
            this.showProcess3.Margin = new System.Windows.Forms.Padding(5);
            this.showProcess3.MinimumSize = new System.Drawing.Size(1, 1);
            this.showProcess3.Name = "showProcess3";
            this.showProcess3.Radius = 20;
            this.showProcess3.Size = new System.Drawing.Size(130, 80);
            this.showProcess3.Style = Sunny.UI.UIStyle.Custom;
            this.showProcess3.Symbol = 61573;
            this.showProcess3.TabIndex = 2;
            this.showProcess3.Text = "3공정 현황";
            this.showProcess3.Click += new System.EventHandler(this.showProcess3_Click);
            // 
            // showProcess4
            // 
            this.showProcess4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showProcess4.FillPressColor = System.Drawing.Color.RoyalBlue;
            this.showProcess4.FillSelectedColor = System.Drawing.Color.Blue;
            this.showProcess4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showProcess4.Location = new System.Drawing.Point(14, 521);
            this.showProcess4.Margin = new System.Windows.Forms.Padding(5);
            this.showProcess4.MinimumSize = new System.Drawing.Size(1, 1);
            this.showProcess4.Name = "showProcess4";
            this.showProcess4.Radius = 20;
            this.showProcess4.Size = new System.Drawing.Size(130, 80);
            this.showProcess4.Style = Sunny.UI.UIStyle.Custom;
            this.showProcess4.Symbol = 61573;
            this.showProcess4.TabIndex = 3;
            this.showProcess4.Text = "4공정 현황";
            this.showProcess4.Click += new System.EventHandler(this.showProcess4_Click);
            // 
            // showProcess5
            // 
            this.showProcess5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showProcess5.FillPressColor = System.Drawing.Color.RoyalBlue;
            this.showProcess5.FillSelectedColor = System.Drawing.Color.Blue;
            this.showProcess5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showProcess5.Location = new System.Drawing.Point(14, 611);
            this.showProcess5.Margin = new System.Windows.Forms.Padding(5);
            this.showProcess5.MinimumSize = new System.Drawing.Size(1, 1);
            this.showProcess5.Name = "showProcess5";
            this.showProcess5.Radius = 20;
            this.showProcess5.Size = new System.Drawing.Size(130, 80);
            this.showProcess5.Style = Sunny.UI.UIStyle.Custom;
            this.showProcess5.Symbol = 61573;
            this.showProcess5.TabIndex = 4;
            this.showProcess5.Text = "5공정 현황";
            this.showProcess5.Click += new System.EventHandler(this.showProcess5_Click);
            // 
            // addWorkOrder
            // 
            this.addWorkOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addWorkOrder.FillPressColor = System.Drawing.Color.RoyalBlue;
            this.addWorkOrder.FillSelectedColor = System.Drawing.Color.Blue;
            this.addWorkOrder.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWorkOrder.Location = new System.Drawing.Point(14, 71);
            this.addWorkOrder.Margin = new System.Windows.Forms.Padding(5);
            this.addWorkOrder.MinimumSize = new System.Drawing.Size(1, 1);
            this.addWorkOrder.Name = "addWorkOrder";
            this.addWorkOrder.Radius = 20;
            this.addWorkOrder.Size = new System.Drawing.Size(130, 80);
            this.addWorkOrder.Style = Sunny.UI.UIStyle.Custom;
            this.addWorkOrder.Symbol = 61508;
            this.addWorkOrder.TabIndex = 5;
            this.addWorkOrder.Text = "작업 등록";
            this.addWorkOrder.Click += new System.EventHandler(this.addWorkOrder_Click);
            // 
            // centerLayout
            // 
            this.centerLayout.BackColor = System.Drawing.Color.White;
            this.centerLayout.Location = new System.Drawing.Point(159, 64);
            this.centerLayout.Margin = new System.Windows.Forms.Padding(0);
            this.centerLayout.Name = "centerLayout";
            this.centerLayout.Size = new System.Drawing.Size(955, 635);
            this.centerLayout.TabIndex = 6;
            // 
            // goHome
            // 
            this.goHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goHome.FillPressColor = System.Drawing.Color.RoyalBlue;
            this.goHome.FillSelectedColor = System.Drawing.Color.SlateBlue;
            this.goHome.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goHome.Location = new System.Drawing.Point(14, 161);
            this.goHome.Margin = new System.Windows.Forms.Padding(5);
            this.goHome.MinimumSize = new System.Drawing.Size(1, 1);
            this.goHome.Name = "goHome";
            this.goHome.Radius = 20;
            this.goHome.Size = new System.Drawing.Size(130, 80);
            this.goHome.Style = Sunny.UI.UIStyle.Custom;
            this.goHome.Symbol = 362069;
            this.goHome.TabIndex = 7;
            this.goHome.Text = "공정별 현황";
            this.goHome.Click += new System.EventHandler(this.goHome_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 700);
            this.Controls.Add(this.addWorkOrder);
            this.Controls.Add(this.goHome);
            this.Controls.Add(this.centerLayout);
            this.Controls.Add(this.showProcess5);
            this.Controls.Add(this.showProcess4);
            this.Controls.Add(this.showProcess3);
            this.Controls.Add(this.showProcess2);
            this.Controls.Add(this.showProcess1);
            this.Name = "MainForm";
            this.Text = "자동차 헤드램프 생산 현황";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton showProcess1;
        private Sunny.UI.UISymbolButton showProcess2;
        private Sunny.UI.UISymbolButton showProcess3;
        private Sunny.UI.UISymbolButton showProcess4;
        private Sunny.UI.UISymbolButton showProcess5;
        private Sunny.UI.UISymbolButton addWorkOrder;
        private System.Windows.Forms.Panel centerLayout;
        private Sunny.UI.UISymbolButton goHome;
    }
}

