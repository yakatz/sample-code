// Install the C# / .NET helper library from twilio.com/docs/csharp/install

using System;
using Twilio;
using Twilio.Rest.Preview.DeployedDevices.Fleet;


class Program 
{
    static void Main(string[] args)
    {
        // Find your Account Sid and Token at twilio.com/console
        const string accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        const string authToken = "your_auth_token";

        TwilioClient.Init(accountSid, authToken);

        var device = DeviceResource.Update(
            friendlyName: "My New Device",
            identity: "bob@twilio.com",
            pathFleetSid: "FLXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
            pathSid: "THXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        );

        Console.WriteLine(device.UniqueName);
    }
}