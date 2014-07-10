
namespace Texty
{
    public class TextyForm : System.Windows.Forms.Form
    {
        private System.ComponentModel.IContainer components = null;
        protected System.Timers.Timer FadeInTimer;
        private System.Timers.Timer FadeOutTimer;

        protected double OPACITY_CHANGE = 0.1;
        protected double TIMER_INTERVAL = 20.0;

        public TextyForm()
        {
            this.FadeInTimer = new System.Timers.Timer();
            this.FadeInTimer.SynchronizingObject = this;
            this.FadeInTimer.Interval = TIMER_INTERVAL;
            this.FadeInTimer.Elapsed += FadeInTimer_Elapsed;
            this.FadeInTimer.Enabled = true;

            this.FadeOutTimer = new System.Timers.Timer();
            this.FadeOutTimer.SynchronizingObject = this;
            this.FadeOutTimer.Interval = TIMER_INTERVAL;
            this.FadeOutTimer.Elapsed += FadeOutTimer_Elapsed;
            this.FadeOutTimer.Enabled = false;

            this.Opacity = 0.0;
        }

        protected override void OnFormClosing(System.Windows.Forms.FormClosingEventArgs e)
        {
            if (this.Opacity > OPACITY_CHANGE)
            {
                e.Cancel = true;
                System.Diagnostics.Debug.WriteLine("form closing...");
                this.FadeOutTimer.Enabled = true;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        void FadeOutTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("fade out : " + this.Opacity + " " + OPACITY_CHANGE);
            this.Opacity -= OPACITY_CHANGE;
            if (this.Opacity <= OPACITY_CHANGE)
            {
                this.Opacity = 0.0;
                this.FadeOutTimer.Enabled = false;
                this.Close();
            }
        }

        void FadeInTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("fade in : " + this.Opacity + " " + OPACITY_CHANGE);
            this.Opacity += this.OPACITY_CHANGE;
            if (this.Opacity >= 1.0)
            {
                this.Opacity = 1.0;
                this.FadeInTimer.Enabled = false;
            }
        }
    }
}
