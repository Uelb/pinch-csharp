using System;
using pinch;

public class Class1
{
	public Class1()
	{
        var client = new PinchClient('MY_API_KEY','toto');
        client.Webhook.List();
	}
}
