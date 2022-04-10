
using ClownProgram.Models;
using System.Windows.Forms;

namespace ClownProgram
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LeftPnl = new System.Windows.Forms.Panel();
            this.CreateChartBtn = new System.Windows.Forms.Button();
            this.OpenFileBtn = new System.Windows.Forms.Button();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.BottomPnl = new System.Windows.Forms.Panel();
            this.ThirdTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SecondTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CoordinateLbl = new System.Windows.Forms.Label();
            this.Splitter = new System.Windows.Forms.Splitter();
            this.MainPnl = new System.Windows.Forms.Panel();
            this.OxyPlotChart = new OxyPlot.WindowsForms.PlotView();
            this.LeftPnl.SuspendLayout();
            this.BottomPnl.SuspendLayout();
            this.MainPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPnl
            // 
            this.LeftPnl.Controls.Add(this.CreateChartBtn);
            this.LeftPnl.Controls.Add(this.OpenFileBtn);
            this.LeftPnl.Controls.Add(this.SettingsBtn);
            this.LeftPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPnl.Location = new System.Drawing.Point(0, 0);
            this.LeftPnl.Name = "LeftPnl";
            this.LeftPnl.Padding = new System.Windows.Forms.Padding(5);
            this.LeftPnl.Size = new System.Drawing.Size(200, 618);
            this.LeftPnl.TabIndex = 0;
            // 
            // CreateChartBtn
            // 
            this.CreateChartBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateChartBtn.FlatAppearance.BorderSize = 0;
            this.CreateChartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateChartBtn.Location = new System.Drawing.Point(5, 85);
            this.CreateChartBtn.Name = "CreateChartBtn";
            this.CreateChartBtn.Size = new System.Drawing.Size(190, 90);
            this.CreateChartBtn.TabIndex = 2;
            this.CreateChartBtn.Text = "Построить графики";
            this.CreateChartBtn.UseVisualStyleBackColor = true;
            // 
            // OpenFileBtn
            // 
            this.OpenFileBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.OpenFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenFileBtn.Location = new System.Drawing.Point(5, 5);
            this.OpenFileBtn.Name = "OpenFileBtn";
            this.OpenFileBtn.Size = new System.Drawing.Size(190, 80);
            this.OpenFileBtn.TabIndex = 1;
            this.OpenFileBtn.Text = "Открыть файл";
            this.OpenFileBtn.UseVisualStyleBackColor = true;
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SettingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsBtn.Location = new System.Drawing.Point(5, 533);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(190, 80);
            this.SettingsBtn.TabIndex = 0;
            this.SettingsBtn.Text = "Настройки";
            this.SettingsBtn.UseVisualStyleBackColor = true;
            // 
            // BottomPnl
            // 
            this.BottomPnl.Controls.Add(this.ThirdTB);
            this.BottomPnl.Controls.Add(this.label3);
            this.BottomPnl.Controls.Add(this.SecondTB);
            this.BottomPnl.Controls.Add(this.label2);
            this.BottomPnl.Controls.Add(this.FirstTB);
            this.BottomPnl.Controls.Add(this.label1);
            this.BottomPnl.Controls.Add(this.CoordinateLbl);
            this.BottomPnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.BottomPnl.Location = new System.Drawing.Point(969, 0);
            this.BottomPnl.Name = "BottomPnl";
            this.BottomPnl.Padding = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.BottomPnl.Size = new System.Drawing.Size(217, 618);
            this.BottomPnl.TabIndex = 1;
            // 
            // ThirdTB
            // 
            this.ThirdTB.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThirdTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThirdTB.Location = new System.Drawing.Point(5, 175);
            this.ThirdTB.Name = "ThirdTB";
            this.ThirdTB.Size = new System.Drawing.Size(207, 27);
            this.ThirdTB.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(5, 133);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.label3.Size = new System.Drawing.Size(76, 42);
            this.label3.TabIndex = 10;
            this.label3.Text = "Условно T";
            // 
            // SecondTB
            // 
            this.SecondTB.Dock = System.Windows.Forms.DockStyle.Top;
            this.SecondTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondTB.Location = new System.Drawing.Point(5, 106);
            this.SecondTB.Name = "SecondTB";
            this.SecondTB.Size = new System.Drawing.Size(207, 27);
            this.SecondTB.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(5, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.label2.Size = new System.Drawing.Size(76, 42);
            this.label2.TabIndex = 8;
            this.label2.Text = "Условно Y";
            // 
            // FirstTB
            // 
            this.FirstTB.Dock = System.Windows.Forms.DockStyle.Top;
            this.FirstTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstTB.Location = new System.Drawing.Point(5, 37);
            this.FirstTB.Name = "FirstTB";
            this.FirstTB.Size = new System.Drawing.Size(207, 27);
            this.FirstTB.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.label1.Size = new System.Drawing.Size(76, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Условно Х";
            // 
            // CoordinateLbl
            // 
            this.CoordinateLbl.AutoSize = true;
            this.CoordinateLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CoordinateLbl.Location = new System.Drawing.Point(5, 591);
            this.CoordinateLbl.Name = "CoordinateLbl";
            this.CoordinateLbl.Size = new System.Drawing.Size(0, 17);
            this.CoordinateLbl.TabIndex = 3;
            // 
            // Splitter
            // 
            this.Splitter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Splitter.Dock = System.Windows.Forms.DockStyle.Right;
            this.Splitter.Location = new System.Drawing.Point(966, 0);
            this.Splitter.Name = "Splitter";
            this.Splitter.Size = new System.Drawing.Size(3, 618);
            this.Splitter.TabIndex = 2;
            this.Splitter.TabStop = false;
            // 
            // MainPnl
            // 
            this.MainPnl.Controls.Add(this.OxyPlotChart);
            this.MainPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPnl.Location = new System.Drawing.Point(200, 0);
            this.MainPnl.Name = "MainPnl";
            this.MainPnl.Size = new System.Drawing.Size(766, 618);
            this.MainPnl.TabIndex = 3;
            // 
            // OxyPlotChart
            // 
            this.OxyPlotChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OxyPlotChart.Location = new System.Drawing.Point(0, 0);
            this.OxyPlotChart.Name = "OxyPlotChart";
            this.OxyPlotChart.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.OxyPlotChart.Size = new System.Drawing.Size(766, 618);
            this.OxyPlotChart.TabIndex = 0;
            this.OxyPlotChart.Text = "plotView1";
            this.OxyPlotChart.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.OxyPlotChart.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.OxyPlotChart.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 618);
            this.Controls.Add(this.MainPnl);
            this.Controls.Add(this.Splitter);
            this.Controls.Add(this.BottomPnl);
            this.Controls.Add(this.LeftPnl);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.LeftPnl.ResumeLayout(false);
            this.BottomPnl.ResumeLayout(false);
            this.BottomPnl.PerformLayout();
            this.MainPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPnl;
        private System.Windows.Forms.Button SettingsBtn;
        private Button CreateChartBtn;
        private Button OpenFileBtn;
        private Panel BottomPnl;
        private Splitter Splitter;
        private Label CoordinateLbl;
        private Panel MainPnl;
        private OxyPlot.WindowsForms.PlotView OxyPlotChart;
        private TextBox FirstTB;
        private Label label1;
        private TextBox SecondTB;
        private Label label2;
        private TextBox ThirdTB;
        private Label label3;
    }
}

