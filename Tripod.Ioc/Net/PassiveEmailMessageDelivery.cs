﻿namespace Tripod.Ioc.Net
{
    public class PassiveEmailMessageDelivery : IDeliverEmailMessage
    {
        public void Deliver(int emailMessageId)
        {
            // don't do anything, let another app like a worker role do the sending
        }
    }
}