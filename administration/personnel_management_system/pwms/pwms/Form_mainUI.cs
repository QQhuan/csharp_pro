using pwms.ModuleClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace pwms
{
    public partial class Form_mainUI : Form
    {
        public Form_mainUI()
        {
            InitializeComponent();
            PopulateChart();
        }

        private void PopulateChart()
        {
            // 清空图表
            chart1.Series.Clear();

            // 创建一个新系列并设置类型为折线图
            Series series = new Series("峰图");
            series.ChartType = SeriesChartType.Line;

            // 添加数据点
            series.Points.AddXY(1, 10);
            series.Points.AddXY(2, 15.5);
            series.Points.AddXY(3, 7);
            series.Points.AddXY(4, 22);
            series.Points.AddXY(5, 12);
            series.Points.AddXY(6, 62);
            series.Points.AddXY(7, 52);
            series.Points.AddXY(8, 11);
            series.Points.AddXY(9, 122);

            // 将系列添加到图表
            chart1.Series.Add(series);

            // 设置图表标题和轴标签
            chart1.Titles.Add("mass spectrometry");
            chart1.ChartAreas[0].AxisX.Title = "m/z";
            chart1.ChartAreas[0].AxisY.Title = "intensity(ion)";
        }

        private void Form_mainUI_Load(object sender, EventArgs e)
        {
            // 加载时获取用户的数据
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void 员工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet ds = MyModule.Instance.GetStaffInfo();
            dataGridView1.DataSource = ds.Tables["staff_info"];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = String.Format("第{0}行，第{1}列", dataGridView1.CurrentCell.RowIndex, dataGridView1.CurrentCell.ColumnIndex);
            int index = dataGridView1.CurrentRow.Index;
            string row_msg = "";
            foreach (DataGridViewCell cell in dataGridView1.Rows[index].Cells)
            {
                row_msg += cell.Value.ToString() + "/";
            }
            richTextBox1.Text = msg + "\t" + row_msg;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("更新成功！");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
