using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DataLayer;

namespace ComputerMetricsWinForms
{
    public partial class Form1 : Form
    {
        private readonly FullDataManager dataManager;
        private readonly DatabaseHandler databaseHandler;

        private const string CpuUsage = "Cpu Usage";
        private const string RamUsage = "Ram Usage";
        private const string AverageDiskQueueLength = "Average Disk Queue Length";
        
        public Form1()
        {
            dataManager = new FullDataManager();
            databaseHandler = new DatabaseHandler();
            InitializeComponent();
            chartUsage.Series.Clear();
            chartAverageDiskQueueLength.Series.Clear();

            chartUsage.Series.Add(CpuUsage);
            chartUsage.Series[CpuUsage].ChartType = SeriesChartType.Line;
            chartUsage.Series[CpuUsage].Color = System.Drawing.Color.Blue;

            chartUsage.Series.Add(RamUsage);
            chartUsage.Series[RamUsage].ChartType = SeriesChartType.Line;
            chartUsage.Series[RamUsage].Color = System.Drawing.Color.DarkRed;

            chartAverageDiskQueueLength.Series.Add(AverageDiskQueueLength);
            chartAverageDiskQueueLength.Series[AverageDiskQueueLength].ChartType = SeriesChartType.Line;
            chartAverageDiskQueueLength.Series[AverageDiskQueueLength].Color = System.Drawing.Color.DarkRed;
        }

        private void buttonComputerSummary_Click(object sender, EventArgs e)
        {
            buttonComputerSummary.Enabled = false;

            ComputerSummary computerSummary = dataManager.GetComputerSummary();

            textBoxName.Text = computerSummary.Name;
            textBoxUser.Text = computerSummary.User;
            textBoxCpu.Text = computerSummary.Cpu;
            textBoxRam.Text = computerSummary.Ram.ToString();
            textBoxVideoCard.Text = computerSummary.VideoCard;
            textBoxIpAddress.Text = computerSummary.Ip.ToString();
            textBoxCpuUsage.Text = computerSummary.CpuUsage.ToString();
            textBoxRamUsage.Text = computerSummary.RamUsage.ToString();
            textBoxAvailableDiskSpace.Text = computerSummary.AvailableDiskSpaceGb.ToString();
            textBoxAverageDiskQueueLength.Text = computerSummary.AverageDiskQueueLength.ToString();

            timerChartUsage.Start();
        }

        private void timerChartUsage_Tick(object sender, EventArgs e)
        {
            var usageData = dataManager.GetUsageData();
            chartUsage.Series[CpuUsage].Points.AddXY(string.Format($"{DateTime.Now.Minute}:{DateTime.Now.Second}"), usageData.CpuUsage);
            chartUsage.Series[RamUsage].Points.AddXY(string.Format($"{DateTime.Now.Minute}:{DateTime.Now.Second}"), usageData.RamUsage);
            chartAverageDiskQueueLength.Series[AverageDiskQueueLength].Points.AddXY(
                string.Format($"{DateTime.Now.Minute}:{DateTime.Now.Second}"), usageData.AverageDiskQueueLength);
            textBoxAverageDiskQueueLength.Text = usageData.AverageDiskQueueLength.ToString();
            textBoxCpuUsage.Text = usageData.CpuUsage.ToString();
            textBoxRamUsage.Text = usageData.RamUsage.ToString();
            databaseHandler.AddUsageData(usageData);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            databaseHandler.AddComputerDetail(dataManager);
        }
    }
}
