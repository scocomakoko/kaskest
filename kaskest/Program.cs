using kaskest.Chats;
using kaskest.Displayer;
using kaskest.MessageDispatcher;
using kaskest.MessageReceiver;

var dispacher = new MessageDispatcher();
var chat = new TemporaryMessagesChat();
dispacher.Subscribe(chat);
var receiver = new ConsoleMessageReceiver();
receiver.Subscribe(dispacher);
Console.WriteLine($"current chat id: {chat.ChatId}");
var displayer = new ConsoleDisplayer();

while (true)
{
    receiver.Start();
    displayer.DisplayChat(chat);
}
