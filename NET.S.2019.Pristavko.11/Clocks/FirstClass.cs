namespace NET.S._2019.Pristavko._11.Clocks
{
    using System;

    public class FirstClass : Subscriber
    {
        protected override void Message(object sender, CallEventArgs e)
        {
            Console.WriteLine($"FirstClass initial time: {e.Initial} and time spend: {e.Milliseconds} millisecond.");
        }
    }
}
