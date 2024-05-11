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
            chartCarStatistics = new FastReport.DataVisualization.Charting.Chart();
            buttonBack = new Button();
            buttonShowStatistics = new Button();
            ((System.ComponentModel.ISupportInitialize)chartCarStatistics).BeginInit();
            SuspendLayout();
            // 
            // chartCarStatistics
            // 
            chartCarStatistics.Location = new Point(12, 12);
            chartCarStatistics.Name = "chartCarStatistics";
            chartCarStatistics.Size = new Size(941, 532);
            chartCarStatistics.TabIndex = 0;
            chartCarStatistics.Text = "chart1";
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Montserrat", 9F);
            buttonBack.Location = new Point(277, 590);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(161, 34);
            buttonBack.TabIndex = 1;
            buttonBack.Text = "Back to Manager";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonShowStatistics
            // 
            buttonShowStatistics.Font = new Font("Montserrat", 9F);
            buttonShowStatistics.Location = new Point(550, 590);
            buttonShowStatistics.Name = "buttonShowStatistics";
            buttonShowStatistics.Size = new Size(161, 34);
            buttonShowStatistics.TabIndex = 2;
            buttonShowStatistics.Text = "Show Statistics";
            buttonShowStatistics.UseVisualStyleBackColor = true;
            // 
            // VStatistics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 657);
            Controls.Add(buttonShowStatistics);
            Controls.Add(buttonBack);
            Controls.Add(chartCarStatistics);
            Name = "VStatistics";
            Text = "VStatistics";
            ((System.ComponentModel.ISupportInitialize)chartCarStatistics).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FastReport.DataVisualization.Charting.Chart chartCarStatistics;
        private Button buttonBack;
        private Button buttonShowStatistics;
    }
}