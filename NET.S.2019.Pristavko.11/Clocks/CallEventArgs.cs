namespace NET.S._2019.Pristavko._11
{
    using System;

    /// <summary>
    /// Provides data for the <see cref="Clock.Call"/> events.
    /// </summary>
    public sealed class CallEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallEventArgs"/> class.
        /// </summary>
        /// <param name="initial">The initial.</param>
        /// <param name="milliseconds">The milliseconds.</param>
        public CallEventArgs(DateTime initial, int milliseconds)
        {
            this.Initial = initial;
            this.Milliseconds = milliseconds;
        }

        /// <summary>
        /// Gets the initial time.
        /// </summary>
        /// <value>
        /// The initial time.
        /// </value>
        public DateTime Initial { get; }

        /// <summary>
        /// Gets the milliseconds.
        /// </summary>
        /// <value>
        /// The milliseconds.
        /// </value>
        public int Milliseconds { get; }
    }
}
