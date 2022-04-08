using FirebaseAdmin;
using FirebaseAdmin.Messaging;
using Google.Apis.Auth.OAuth2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;


var defaultApp = FirebaseApp.Create(new AppOptions()
{
    Credential = GoogleCredential.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "keys.json")),
});
Console.WriteLine(defaultApp.Name); // "[DEFAULT]"
var message = new Message()
{
    Data = new Dictionary<string, string>()
    {
        ["FirstName"] = "John",
        ["LastName"] = "Doe"
    },
    Notification = new Notification
    {
        Title = "Fire Base Cloud Messanging",
        Body = "Las pizzas estan listas."
    },

    Token = "c1j_QKtoSzOak6P7Gsjm6W:APA91bHVQHk7LDvodpWgQJrSuHG0oqcVsYA6FF_L4ba1Do2j0GWg9Z2M8_gO-pBoZK1_0J4S7hQAKh0xMVrEBbamQ7V2MDuxJHZdQVQZV-9Bfaoq7QHG8h2ENUE_mZFEDuhUiBVunEh7"
};
var messaging = FirebaseMessaging.DefaultInstance;
var result = await messaging.SendAsync(message);
Console.WriteLine(result); //projects/myapp/messages/2492588335721724324