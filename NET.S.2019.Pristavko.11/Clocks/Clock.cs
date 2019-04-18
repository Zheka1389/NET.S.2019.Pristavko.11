namespace NET.S._2019.Pristavko._11
{
    using System;
    using System.Threading;

    /// <summary>
    /// Provides methods for work with timer.
    /// </summary>
    public class Clock
    {
        /// <summary>
        /// Occurs when [clock countdown].
        /// </summary>
        public event EventHandler<CallEventArgs> ClockCountdown;

        /// <summary>
        /// Countdowns the specified milliseconds.
        /// </summary>
        /// <param name="milliseconds">The milliseconds.</param>
        public void Countdown(int milliseconds)
        {
            var initialTime = DateTime.Now;
            Thread.Sleep(milliseconds);
            this.OnClockCountdown(this, new CallEventArgs(initialTime, milliseconds));
        }

        /// <summary>
        /// Called when [clock countdown].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="TimeEventArgs"/> instance containing the event data.</param>
        private void OnClockCountdown(object sender, CallEventArgs e)
        {
            this.ClockCountdown?.Invoke(this, e);
        }
    }
}
