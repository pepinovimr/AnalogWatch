using System;
using System.Drawing;
using System.Windows.Forms;

namespace AnalogWatch
{
    public partial class Watch : Form
    {
        readonly Pen _secondsPen = new Pen(Color.Red);
        readonly Pen _minutePen = new Pen(Color.Gray);
        readonly Pen _hourPen = new Pen(Color.Black);
        readonly Image _clockImg;
        readonly Point _middlePB;
        readonly Graphics _g;
        public Watch()
        {
            InitializeComponent();
            _clockImg = Properties.Resources.ClockImg;
            DoubleBuffered = true;
            DigitalWatch.Text = DateTime.Now.ToString("h:m:ss");
            _g = WatchPB.CreateGraphics();
            _middlePB = new Point(WatchPB.Width/2, WatchPB.Height/2);
            SecondsTimer.Start();
        }

        private void SecondsTimer_Tick(object sender, EventArgs e)
        {
            DrawWatch();
            var now = DateTime.Now;
            DigitalWatch.Text = now.ToString("h:m:ss");
            MoveSecondsHand(now.Second);
            MoveMinuteHand(now.Minute);
            MoveHourHand(now.Hour);
            _g.FillEllipse(Brushes.Black, _middlePB.X - 5, _middlePB.Y - 5, 10, 10);
        }

        private void MoveSecondsHand(int seconds)
        {
            _g.TranslateTransform(_middlePB.X, _middlePB.Y);
            _g.RotateTransform(6 * seconds);
            _g.DrawLine(_secondsPen, 0, 0, 0, -160);
            _g.ResetTransform();
        }

        private void MoveMinuteHand(int minutes)
        {
            _g.TranslateTransform(_middlePB.X, _middlePB.Y);
            _g.RotateTransform(6 * minutes/60);
            _g.DrawLine(_minutePen, 0, 0, 0, -125);
            _g.ResetTransform();
        }

        private void MoveHourHand(int hours)
        {
            _g.TranslateTransform(_middlePB.X, _middlePB.Y);
            _g.RotateTransform(6 * hours);
            _g.DrawLine(_hourPen, 0, 0, 0, -90);
            _g.ResetTransform();
        }
        private void DrawWatch()
        {
            _g.DrawImage(_clockImg, 0, 0, WatchPB.Width, WatchPB.Height);
        }

        private void Form1_SetBorderFixed(object sender, EventArgs e)
        {
            if (FormBorderStyle != FormBorderStyle.FixedDialog)
                FormBorderStyle = FormBorderStyle.FixedDialog;
            SecondsTimer_Tick(sender, e);
        }

        private void Form1_SetBorderNone(object sender, EventArgs e)
        {
            if (FormBorderStyle != FormBorderStyle.None)
                FormBorderStyle = FormBorderStyle.None;
            SecondsTimer_Tick(sender, e);
        }

        private void VisibilityTB_ValueChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.Form.ActiveForm.Opacity = ((double)(VisibilityTB.Value) / 100.0);
        }

        private void AllwaysOnTopCB_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = AllwaysOnTopCB.Checked;
        }
    }
}
