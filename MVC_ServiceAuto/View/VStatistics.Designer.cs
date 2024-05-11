using System.Drawing;
using System.Windows.Forms;

namespace MVC_ServiceAuto.View
{
    partial class VStatistics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonShowStatistics = new System.Windows.Forms.Button();
            this.chartCarStatistics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartCarStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Montserrat", 9F);
            this.buttonBack.Location = new System.Drawing.Point(237, 511);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(138, 29);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Back to Manager";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonShowStatistics
            // 
            this.buttonShowStatistics.Font = new System.Drawing.Font("Montserrat", 9F);
            this.buttonShowStatistics.Location = new System.Drawing.Point(471, 511);
            this.buttonShowStatistics.Name = "buttonShowStatistics";
            this.buttonShowStatistics.Size = new System.Drawing.Size(138, 29);
            this.buttonShowStatistics.TabIndex = 2;
            this.buttonShowStatistics.Text = "Show Statistics";
            this.buttonShowStatistics.UseVisualStyleBackColor = true;
            // 
            // chartCarStatistics
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCarStatistics.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCarStatistics.Legends.Add(legend1);
            this.chartCarStatistics.Location = new System.Drawing.Point(22, 21);
            this.chartCarStatistics.Name = "chartCarStatistics";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartCarStatistics.Series.Add(series1);
            this.chartCarStatistics.Size = new System.Drawing.Size(781, 474);
            this.chartCarStatistics.TabIndex = 3;
            this.chartCarStatistics.Text = "chartCarStatistics";
            // 
            // VStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 569);
            this.Controls.Add(this.chartCarStatistics);
            this.Controls.Add(this.buttonShowStatistics);
            this.Controls.Add(this.buttonBack);
            this.Name = "VStatistics";
            this.Text = "VStatistics";
            ((System.ComponentModel.ISupportInitialize)(this.chartCarStatistics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonBack;
        private Button buttonShowStatistics;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCarStatistics;
    }
}