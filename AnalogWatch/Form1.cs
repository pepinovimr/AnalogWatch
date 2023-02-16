using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace AnalogWatch
{
    public partial class Form1 : Form
    {
        Pen _secondsPen = new Pen(Color.Red);
        Pen _minutePen = new Pen(Color.Gray);
        Pen _hourPen = new Pen(Color.Black);
        readonly Point _middlePB;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = WatchPB.CreateGraphics();
            _middlePB = new Point(WatchPB.Width/2, WatchPB.Height/2);
            SecondsTimer.Start();
        }

        private void SecondsTimer_Tick(object sender, EventArgs e)
        {

            g = WatchPB.CreateGraphics();
            g.Clear(Color.White);
            DrawWatch();
            var now = DateTime.Now;
            label1.Text = now.ToString();
            MoveSecondsHand(now.Second);
            MoveMinuteHand(now.Minute);
            MoveHourHand(now.Hour);
        }

        private void MoveSecondsHand(int seconds)
        {
            g.TranslateTransform(_middlePB.X, _middlePB.Y);
            g.RotateTransform(6 * seconds);
            g.DrawLine(_secondsPen, 0, 0, 0, -160);
            g.ResetTransform();
        }

        private void MoveMinuteHand(int minutes)
        {
            g.TranslateTransform(_middlePB.X, _middlePB.Y);
            g.RotateTransform(6 * minutes);
            g.DrawLine(_minutePen, 0, 0, 0, -125);
            g.ResetTransform();
        }

        private void MoveHourHand(int hours)
        {
            g.TranslateTransform(_middlePB.X, _middlePB.Y);
            g.RotateTransform(6 * hours);
            g.DrawLine(_hourPen, 0, 0, 0, -90);
            g.ResetTransform();
        }
        private void DrawWatch()
        {
            g.DrawEllipse(_hourPen, 0, 0, WatchPB.Width, WatchPB.Height);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (ActiveForm == null)
                return;
            if(ActiveForm.FormBorderStyle != FormBorderStyle.FixedDialog && ActiveForm.ContainsFocus)
                ActiveForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            SecondsTimer_Tick(sender, e);
        }

        private void Form1_SetNoneHandle(object sender, EventArgs e)
        {
            if (ActiveForm == null)
                return;
            if (ActiveForm.FormBorderStyle != FormBorderStyle.None && ActiveForm.ContainsFocus)
                ActiveForm.FormBorderStyle = FormBorderStyle.None;
            SecondsTimer_Tick(sender, e);
        }
    }
}
