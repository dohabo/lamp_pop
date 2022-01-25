using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Head_Lamp.UI
{
    public partial class Process1UI : UserControl
    {
        public Process1UI()
        {
            InitializeComponent();
        }

        private void Process1UI_Load(object sender, EventArgs e)
        {
            //initBarChart();
            //initPieChart();
        }

        //void initBarChart()
        //{
        //    UIBarOption option = new UIBarOption();
        //    option.Title = new UITitle();
        //    option.Title.Text = "생산1라인";
        //    option.Title.SubText = "온도 상태";

        //    // 범례 (Legend)
        //    option.Legend = new UILegend();
        //    option.Legend.Orient = UIOrient.Horizontal;
        //    option.Legend.Top = UITopAlignment.Top;
        //    option.Legend.Left = UILeftAlignment.Left;
        //    option.Legend.AddData("온도");
        //    //option.Legend.AddData("습도");

        //    option.ToolTip = new UIBarToolTip();
        //    var series = new UIBarSeries();
        //    series.Name = "Temp";
        //    series.AddData(11);
        //    series.AddData(15);
        //    series.AddData(28);
        //    series.AddData(37);
        //    option.Series.Add(series);

        //    option.XAxis.Data.Add("21년9월3일");
        //    option.XAxis.Data.Add("21년9월4일");
        //    option.XAxis.Data.Add("21년9월5일");
        //    option.XAxis.Data.Add("21년9월6일");
        //    option.YAxis.Scale = true;

        //    option.XAxis.Name = "시간";
        //    option.YAxis.Name = "온도";
        //    uiBarChart1.SetOption(option);
        //}

        //void initPieChart()
        //{
        //    var option = new UIPieOption();
        //    option.Title = new UITitle();
        //    option.Title.Text = "생산2라인";
        //    option.Title.SubText = "습도 상태";
        //    option.Title.Left = UILeftAlignment.Center;
        //    option.ToolTip = new UIPieToolTip();

        //    option.Legend = new UILegend();
        //    option.Legend.Orient = UIOrient.Vertical;
        //    option.Legend.Top = UITopAlignment.Top;
        //    option.Legend.Left = UILeftAlignment.Left;

        //    option.Legend.AddData("온도");
        //    option.Legend.AddData("습도");
        //    option.Legend.AddData("미세먼지");

        //    var series = new UIPieSeries();
        //    series.Name = "Humi";
        //    series.Center = new UICenter(50, 55);
        //    series.Radius = 70;
        //    series.AddData("온도", 38);
        //    series.AddData("습도", 40);
        //    series.AddData("미세먼지", 32);
        //    option.Series.Add(series);
        //    uiPieChart1.SetOption(option);
        //}
    }
}
