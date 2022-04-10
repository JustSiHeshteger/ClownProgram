using ClownProgram.Forms;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ClownProgram.Models
{
    public class FormModel
    {
        #region поля

        private Color _formColor;
        private Color _buttonColor;
        private Color _splitterColor;
        private Color _buttonForeColor;
        private Color _labelForeColor;
        private Color _textboxColor;
        private Color _textboxForeColor;

        private Font _labelFont;
        private Font _buttonFont;
        private Font _textboxFont;

        private Point _cursorPosition;

        private readonly Label _coordinateLbl;

        #endregion

        #region Свойства

        public Color FormColor 
        { 
            get => _formColor; 
            set 
            { 
                _formColor = value; 
                SetSettings(); 
            } 
        }
        public Color ButtonColor
        {
            get => _buttonColor;
            set
            {
                _buttonColor = value;
                SetSettings();
            }
        }
        public Color ButtonForeColor
        {
            get => _buttonForeColor;
            set
            {
                _buttonForeColor = value;
                SetSettings();
            }
        }
        public Color SplitterColor
        {
            get => _splitterColor;
            set
            {
                _splitterColor = value;
                SetSettings();
            }
        }
        public Color LabelForeColor
        {
            get => _labelForeColor;
            set
            {
                _labelForeColor = value;
                SetSettings();
            }
        }
        public Color TextBoxColor
        {
            get => _textboxColor;
            set
            {
                _textboxColor = value;
                SetSettings();
            }
        }
        public Color TextBoxForeColor
        {
            get => _textboxForeColor;
            set
            {
                _textboxForeColor = value;
                SetSettings();
            }
        }

        public Font ButtonFont
        {
            get => _buttonFont;
            set
            {
                _buttonFont = value;
                SetSettings();
            }
        }
        public Font LabelFont
        {
            get => _labelFont;
            set
            {
                _labelFont = value;
                SetSettings();
            }
        }
        public Font TextBoxFont
        {
            get => _textboxFont;
            set
            {
                _textboxFont = value;
                SetSettings();
            }
        }

        public Point CursorPosition
        {
            get => _cursorPosition;
            set => _cursorPosition = value;
        }

        public ICollection<LineSeries> AllLineSeries = new List<LineSeries>();

        #endregion

        #region Методы

        public FormModel(Label coordLbl)
        {
            this._coordinateLbl = coordLbl;
        }

        public void SetSettings()
        {
            foreach (Form form in Application.OpenForms)
            {
                form.BackColor = FormColor;
                SettingsForAllControls(form);
            }
        }

        public void SetSettings(Form form)
        {
            form.BackColor = FormColor;
            SettingsForAllControls(form);
        }

        private void SettingsForAllControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = ButtonColor;
                    control.Font = ButtonFont;
                    control.ForeColor = ButtonForeColor;
                }
                            
                if (control is Splitter)
                    control.BackColor = SplitterColor;

                if (control is Label)
                {
                    control.ForeColor = LabelForeColor;
                    control.Font = LabelFont;
                }

                if (control is TextBox)
                {
                    control.BackColor = TextBoxColor;
                    control.ForeColor = TextBoxForeColor;
                    control.Font = TextBoxFont;
                }

                if (control is PlotView)
                    control.Refresh();
                
                SettingsForAllControls(control);
            }
        }

        public void GetCursorPosition(object sender, MouseEventArgs mevent)
        {
            if (mevent.Button != MouseButtons.Right)
                return;

            CursorPosition = Cursor.Position;

            ToolBox toolbox = new ToolBox($"X: {CursorPosition.X} \nY: {CursorPosition.Y} \nT: wega")
            {
                TopMost = true
            };
            toolbox.Show();
            toolbox.Location = new Point(CursorPosition.X - 52, CursorPosition.Y - 40);

            _coordinateLbl.Text = $"X координата: {CursorPosition.X} \nY координата: {CursorPosition.Y} \nT значение:";
        }
        #endregion
    }
}
