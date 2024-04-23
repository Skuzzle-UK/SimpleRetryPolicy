using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RetryPolicySettingsConfiguratorUIFramework
{
    public partial class Form1 : Form
    {
        private List<RetryValue> retryValueList = new List<RetryValue>();
        private BindingSource bindingSource = new BindingSource();

        private double SteepnessVal;
        private double ShapeVal;
        private double MidpointVal;

        private const string CHART_SERIES_NAME = "Retry Delay Time";

        public Form1()
        {
            InitializeComponent();

            ValuesListView.AutoGenerateColumns = true;

            MaxRetries_ValueChanged(this, new EventArgs());
            Steepness_ValueChanged(this, new EventArgs());
            Shape_ValueChanged(this, new EventArgs());
            Midpoint_ValueChanged(this, new EventArgs());
            GenerateValues();
            DrawChart();
            DrawDataView();
        }

        private void GenerateValues()
        {
            retryValueList = new List<RetryValue>();

            for (int retryCount = 0; retryCount < (int)MaxRetries.Value; retryCount++)
            {
                var calculatedTtt = ((double)MinDelay.Value + ((double)MaxDelay.Value - (double)MinDelay.Value) * Math.Pow(1 + Math.Exp(-SteepnessVal * (retryCount - MidpointVal)), -ShapeVal));

                retryValueList.Add(new RetryValue()
                {
                    Retry = retryCount + 1,
                    Value = (int)calculatedTtt
                });
            }
        }

        private void DrawDataView()
        {
            bindingSource.DataSource = retryValueList;
            ValuesListView.DataSource = bindingSource;
        }

        private void DrawChart()
        {
            var chart = ChartView.ChartAreas[0];

            chart.AxisX.IntervalType = DateTimeIntervalType.Number;
            chart.AxisX.Minimum = 0;
            chart.AxisX.Maximum = (int)MaxRetries.Value;

            chart.AxisY.IntervalType = DateTimeIntervalType.Number;
            chart.AxisY.Minimum = (int)MinDelay.Value;
            chart.AxisY.Maximum = (int)MaxDelay.Value;

            ChartView.Series.Clear();
            ChartView.Series.Add(CHART_SERIES_NAME);
            ChartView.Series[CHART_SERIES_NAME].Color = Color.DarkBlue;
            ChartView.Series[CHART_SERIES_NAME].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            ChartView.Series[CHART_SERIES_NAME].Points.Clear();

            for (int i = 0; i < retryValueList.Count; i++)
            {
                ChartView.Series[CHART_SERIES_NAME].Points.AddXY(retryValueList[i].Retry, retryValueList[i].Value);
            }
        }

        private void Steepness_ValueChanged(object sender, EventArgs e)
        {
            SteepnessVal = (double)Steepness.Value / 10;
            SteepnessValDisplay.Text = SteepnessVal.ToString();
            GenerateValues();
            DrawChart();
            DrawDataView();
        }

        private void Shape_ValueChanged(object sender, EventArgs e)
        {
            ShapeVal = (double)Shape.Value / 10;
            ShapeValDisplay.Text = ShapeVal.ToString();
            GenerateValues();
            DrawChart();
            DrawDataView();
        }

        private void Midpoint_ValueChanged(object sender, EventArgs e)
        {
            MidpointVal = (double)Midpoint.Value / 10;
            MidpointValDisplay.Text = MidpointVal.ToString();
            GenerateValues();
            DrawChart();
            DrawDataView();
        }

        private void MaxRetries_ValueChanged(object sender, EventArgs e)
        {
            Midpoint.Maximum = (int)MaxRetries.Value * 10;
            GenerateValues();
            DrawChart();
            DrawDataView();
        }

        public struct RetryValue
        {
            public int Retry { get; set; }
            public int Value { get; set; }
        }

        private void RangeExtentsChanged(object sender, EventArgs e)
        {
            GenerateValues();
            DrawChart();
            DrawDataView();
        }
    }
}
