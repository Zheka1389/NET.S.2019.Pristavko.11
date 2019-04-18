namespace NET.S._2019.Pristavko._11.Clocks
{
    using System;

    public abstract class Subscriber
    {
        /// <summary>
        /// Registers the specified Subscriber.
        /// </summary>
        /// <param name="clock">The clock.</param>
        public void Register(Clock clock)
        {
            clock.ClockCountdown += this.Message;
            Console.WriteLine($"The subscriber {this.GetType()} registered.");
        }

        /// <summary>
        /// Unregisters the specified Subscriber.
        /// </summary>
        /// <param name="clock">The clock.</param>
        public void Unregister(Clock clock)
        {
            clock.ClockCountdown -= this.Message;
            Console.WriteLine($"The subscriber {this.GetType()} unregistered.");
        }

        /// <summary>
        /// Message for the specified sender.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="CallEventArgs"/> instance containing the event data.</param>
        protected abstract void Message(object sender, CallEventArgs e);
    }
}
