using ClownProgram.Forms;
using ClownProgram.Models;
using OxyPlot;
using OxyPlot.Legends;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ClownProgram
{
    public partial class MainForm : Form
    {
        private readonly FormModel _formModel;
        private readonly FileModel _fileModel;
        public MainForm()
        {
            InitializeComponent();

            _formModel = new FormModel(CoordinateLbl);
            _fileModel = new FileModel();

            CoordinateLbl.Text = "X координата: \nY координата: \nT значение: ";

            SetEvents();
        }

        #region Установка событий
        private void SetEvents()
        {
            SettingsBtn.MouseClick += new MouseEventHandler(SettingsBtnClick);
            OpenFileBtn.MouseClick += new MouseEventHandler(OpenFileBtnClick);
            CreateChartBtn.MouseClick += new MouseEventHandler(CreateChartBtnClick);

            EventForAllControls(this);
        }

        private void EventForAllControls(Control parent)
        {
            foreach(Control control in parent.Controls)
            {
                control.MouseUp += new MouseEventHandler(_formModel.GetCursorPosition);

                EventForAllControls(control);
            }
        }

        #endregion

        private void SettingsBtnClick(object sender, MouseEventArgs mevents)
        {
            Settings set = new Settings(_formModel);
            set.ShowDialog();
        }

        private void OpenFileBtnClick(object sender, MouseEventArgs mevents)
        {
            _fileModel.GetData();
        }

        private void CreateChartBtnClick(object sender, System.EventArgs e)
        {
            if (!CheckInputData())
                return;

            _formModel.AllLineSeries.Clear();

            PlotModel model = new PlotModel();
            model.Legends.Add(new Legend()
            {
                LegendTitle = "Legend",
                LegendPosition = LegendPosition.RightBottom,
            });

            var lineSeries = CreateLineSeries("Первый график");
            var lineSeries2 = CreateLineSeries("Второй график");
            _formModel.AllLineSeries.Add(lineSeries);
            _formModel.AllLineSeries.Add(lineSeries2);

            for (int i = 0; i < 100; i++)
            {
                lineSeries.Points.Add(new DataPoint(i, Math.Cos(i) + Math.Sin(i)));
                lineSeries2.Points.Add(new DataPoint(i, Math.Sqrt(i) + Math.Sqrt(i)));
            }

            model.Series.Add(lineSeries);
            model.Series.Add(lineSeries2);
            OxyPlotChart.Model = model;
        }

        private LineSeries CreateLineSeries(string title)
        {
            return new LineSeries
            {
                Title = title
            };
        }

        private bool CheckInputData()
        {
            if (!int.TryParse(FirstTB.Text, out _))
            {
                MessageBox.Show($"Невозможно преобразовать в число {FirstTB.Text}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(SecondTB.Text, out _))
            {
                MessageBox.Show($"Невозможно преобразовать в число {SecondTB.Text}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(ThirdTB.Text, out _))
            {
                MessageBox.Show($"Невозможно преобразовать в число {ThirdTB.Text}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        } 
    }
}
