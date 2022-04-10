using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClownProgram.Forms
{
    public partial class ToolBox : Form
    {
        public ToolBox(string data)
        {
            InitializeComponent();

            this.Height = 40;
            this.InfoLbl.Text = data;
            ShowForm();
        }

        private void ShowForm()
        {
            Opacity = 0;
            Timer timerOpen = new Timer();
            Timer timerClose = new Timer();
            timerOpen.Interval = 50;
            timerClose.Interval = 50;
            timerOpen.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.05d) >= 0.85)
                {
                    timerOpen.Stop();
                    timerClose.Start();
                }
            });
            timerOpen.Start();

            timerClose.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity -= 0.05d) <= 0d)
                {
                    timerClose.Stop();
                    this.Close();
                }
            });
        }
    }
}
