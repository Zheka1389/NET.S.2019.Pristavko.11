namespace NET.S._2019.Pristavko._11.Clocks
{
    using System;

    public class SecondClass : Subscriber
    {
        protected override void Message(object sender, CallEventArgs e)
        {
            Console.WriteLine($"SecondClass initial time: {e.Initial} and time spend: {e.Milliseconds} millisecond.");
        }
    }
}
