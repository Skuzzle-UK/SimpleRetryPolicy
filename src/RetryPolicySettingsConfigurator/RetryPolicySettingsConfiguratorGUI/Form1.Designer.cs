using System.Drawing;
using System.Windows.Forms;

namespace RetryPolicySettingsConfiguratorUIFramework
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MidpointValDisplay = new System.Windows.Forms.Label();
            this.ShapeValDisplay = new System.Windows.Forms.Label();
            this.SteepnessValDisplay = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Midpoint = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.Shape = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MaxDelay = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.MinDelay = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.MaxRetries = new System.Windows.Forms.NumericUpDown();
            this.Steepness = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ValuesListView = new System.Windows.Forms.DataGridView();
            this.ChartView = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Midpoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxRetries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Steepness)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValuesListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MidpointValDisplay);
            this.groupBox1.Controls.Add(this.ShapeValDisplay);
            this.groupBox1.Controls.Add(this.SteepnessValDisplay);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Midpoint);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Shape);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MaxDelay);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MinDelay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MaxRetries);
            this.groupBox1.Controls.Add(this.Steepness);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1392, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // MidpointValDisplay
            // 
            this.MidpointValDisplay.AutoSize = true;
            this.MidpointValDisplay.Location = new System.Drawing.Point(1028, 105);
            this.MidpointValDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MidpointValDisplay.Name = "MidpointValDisplay";
            this.MidpointValDisplay.Size = new System.Drawing.Size(51, 20);
            this.MidpointValDisplay.TabIndex = 14;
            this.MidpointValDisplay.Text = "label7";
            // 
            // ShapeValDisplay
            // 
            this.ShapeValDisplay.AutoSize = true;
            this.ShapeValDisplay.Location = new System.Drawing.Point(796, 105);
            this.ShapeValDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ShapeValDisplay.Name = "ShapeValDisplay";
            this.ShapeValDisplay.Size = new System.Drawing.Size(51, 20);
            this.ShapeValDisplay.TabIndex = 13;
            this.ShapeValDisplay.Text = "label7";
            // 
            // SteepnessValDisplay
            // 
            this.SteepnessValDisplay.AutoSize = true;
            this.SteepnessValDisplay.Location = new System.Drawing.Point(592, 105);
            this.SteepnessValDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SteepnessValDisplay.Name = "SteepnessValDisplay";
            this.SteepnessValDisplay.Size = new System.Drawing.Size(51, 20);
            this.SteepnessValDisplay.TabIndex = 12;
            this.SteepnessValDisplay.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1014, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mid point:";
            // 
            // Midpoint
            // 
            this.Midpoint.Location = new System.Drawing.Point(951, 65);
            this.Midpoint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Midpoint.Maximum = 300;
            this.Midpoint.Name = "Midpoint";
            this.Midpoint.Size = new System.Drawing.Size(201, 69);
            this.Midpoint.TabIndex = 5;
            this.Midpoint.Value = 30;
            this.Midpoint.Scroll += new System.EventHandler(this.Midpoint_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(792, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Shape:";
            // 
            // Shape
            // 
            this.Shape.Location = new System.Drawing.Point(729, 65);
            this.Shape.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Shape.Maximum = 500;
            this.Shape.Name = "Shape";
            this.Shape.Size = new System.Drawing.Size(201, 69);
            this.Shape.TabIndex = 4;
            this.Shape.Value = 40;
            this.Shape.Scroll += new System.EventHandler(this.Shape_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(579, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Steepness:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Max delay:";
            // 
            // MaxDelay
            // 
            this.MaxDelay.Location = new System.Drawing.Point(375, 80);
            this.MaxDelay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaxDelay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.MaxDelay.Name = "MaxDelay";
            this.MaxDelay.Size = new System.Drawing.Size(120, 26);
            this.MaxDelay.TabIndex = 2;
            this.MaxDelay.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.MaxDelay.ValueChanged += new System.EventHandler(this.RangeExtentsChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Min delay:";
            // 
            // MinDelay
            // 
            this.MinDelay.Location = new System.Drawing.Point(375, 42);
            this.MinDelay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinDelay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MinDelay.Name = "MinDelay";
            this.MinDelay.Size = new System.Drawing.Size(120, 26);
            this.MinDelay.TabIndex = 1;
            this.MinDelay.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.MinDelay.ValueChanged += new System.EventHandler(this.RangeExtentsChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Max retries:";
            // 
            // MaxRetries
            // 
            this.MaxRetries.Location = new System.Drawing.Point(139, 42);
            this.MaxRetries.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaxRetries.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MaxRetries.Name = "MaxRetries";
            this.MaxRetries.Size = new System.Drawing.Size(119, 26);
            this.MaxRetries.TabIndex = 0;
            this.MaxRetries.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.MaxRetries.ValueChanged += new System.EventHandler(this.MaxRetries_ValueChanged);
            // 
            // Steepness
            // 
            this.Steepness.Location = new System.Drawing.Point(516, 65);
            this.Steepness.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Steepness.Maximum = 50;
            this.Steepness.Minimum = -50;
            this.Steepness.Name = "Steepness";
            this.Steepness.Size = new System.Drawing.Size(201, 69);
            this.Steepness.TabIndex = 3;
            this.Steepness.Value = 7;
            this.Steepness.Scroll += new System.EventHandler(this.Steepness_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ValuesListView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 154);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(394, 752);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Values";
            // 
            // ValuesListView
            // 
            this.ValuesListView.AllowUserToAddRows = false;
            this.ValuesListView.AllowUserToDeleteRows = false;
            this.ValuesListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ValuesListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ValuesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValuesListView.Location = new System.Drawing.Point(4, 24);
            this.ValuesListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ValuesListView.Name = "ValuesListView";
            this.ValuesListView.RowHeadersWidth = 62;
            this.ValuesListView.RowTemplate.Height = 25;
            this.ValuesListView.Size = new System.Drawing.Size(386, 723);
            this.ValuesListView.TabIndex = 0;
            this.ValuesListView.TabStop = false;
            // 
            // ChartView
            // 
            chartArea6.Name = "ChartArea1";
            this.ChartView.ChartAreas.Add(chartArea6);
            this.ChartView.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.BorderColor = System.Drawing.Color.Black;
            legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend6.Name = "Legend1";
            legend6.ShadowOffset = 3;
            this.ChartView.Legends.Add(legend6);
            this.ChartView.Location = new System.Drawing.Point(4, 24);
            this.ChartView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChartView.Name = "ChartView";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.ChartView.Series.Add(series6);
            this.ChartView.Size = new System.Drawing.Size(990, 723);
            this.ChartView.TabIndex = 2;
            this.ChartView.TabStop = false;
            this.ChartView.Text = "chart1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ChartView);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(394, 154);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(998, 752);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chart";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 906);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Retry Policy Settings Configurator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Midpoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxRetries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Steepness)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ValuesListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView ValuesListView;
        private Label label6;
        private TrackBar Midpoint;
        private Label label5;
        private TrackBar Shape;
        private Label label4;
        private Label label3;
        private NumericUpDown MaxDelay;
        private Label label2;
        private NumericUpDown MinDelay;
        private Label label1;
        private NumericUpDown MaxRetries;
        private TrackBar Steepness;
        private Label SteepnessValDisplay;
        private Label MidpointValDisplay;
        private Label ShapeValDisplay;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartView;
        private GroupBox groupBox3;
    }
}

