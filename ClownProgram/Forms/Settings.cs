using ClownProgram.Models;
using OxyPlot.WindowsForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClownProgram.Forms
{
    public partial class Settings : Form
    {
        private readonly FormModel _formModel;
        private Color _color;
        private Font _font;

        public Settings(FormModel formModel)
        {
            InitializeComponent();

            _formModel = formModel;
            _formModel.SetSettings(this);
        }

        private void ChangeColorBtn_Click(object sender, EventArgs e)
        {
            switch (ChangeColorElementCB.SelectedIndex)
            {
                case 0: //Цвет формы
                    ChangeObjectColor();
                    _formModel.FormColor = _color;
                    break;

                case 1: //Цвет кнопки
                    ChangeObjectColor();
                    _formModel.ButtonColor = _color;
                    break;

                case 2: //Цвет шрифта кнопки
                    ChangeObjectColor();
                    _formModel.ButtonForeColor = _color;
                    break;

                case 3: //Шрифт кнопки
                    ChangeObjectFont();
                    _formModel.ButtonFont = _font;
                    break;

                case 4: //Цвет разделителя
                    ChangeObjectColor();
                    _formModel.SplitterColor = _color;
                    break;

                case 5: //Цвет шрифта label
                    ChangeObjectColor();
                    _formModel.LabelForeColor = _color;
                    break;

                case 6: //Шрифт label
                    ChangeObjectFont();
                    _formModel.LabelFont = _font;
                    break;

                case 7: //Цвет текстового поля
                    ChangeObjectColor();
                    _formModel.TextBoxColor = _color;
                    break;

                case 8: //Цвет шрифта текстового поля
                    ChangeObjectColor();
                    _formModel.TextBoxForeColor = _color;
                    break;

                case 9: //Шрифт текстового поля
                    ChangeObjectFont();
                    _formModel.TextBoxFont = _font;
                    break;

                case 10: //Цвет линий графика
                    foreach (var line in _formModel.AllLineSeries)
                    {
                        ChangeObjectColor();
                        line.Color = _color.ToOxyColor();
                    }
                    _formModel.SetSettings();
                    break;

                default:
                    MessageBox.Show("Не удалось найти элемент", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void ChangeObjectColor()
        {
            try
            {
                using (ColorDialog colorDialog = new ColorDialog())
                {
                    colorDialog.FullOpen = true;

                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {
                         _color = colorDialog.Color;
                    }
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeObjectFont()
        {
            try
            {
                using (FontDialog fontDialog = new FontDialog())
                {
                    if (fontDialog.ShowDialog() == DialogResult.OK)
                    {
                        _font = fontDialog.Font;
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
