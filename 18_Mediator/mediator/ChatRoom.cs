using System;
using System.Collections.Generic;

namespace ChatRoom
{

    public interface IChatRoom
    {
        void onUserJoined(User user);
        void onUserLeave(User user);
        void onUserSentMessage(User user, string message);
    }

    public class ChatMessage
    {
        public User User { get; protected set; }
        public string Message { get; protected set; }
        public DateTime Time { get; protected set; }

        public ChatMessage(User user, string message)
        {
            this.User = user;
            this.Message = message;
            this.Time = DateTime.Now;
        }

        public override string ToString()
        {
            return $"[{this.Time.ToString("hh:mm:ss tt")}] {this.User.Name}".PadRight(30) + ":".PadRight(5) + this.Message;
        }
    }

    public class ConcreteChatRoom : IChatRoom
    {
        public string RoomName { get; protected set; }
        protected List<User> users;
        protected List<ChatMessage> messages;

        public ConcreteChatRoom()
        {
            this.users = new List<User>();
            this.messages = new List<ChatMessage>();
        }
        public void onUserJoined(User user)
        {
            if (this.users.Contains(user))
            {
                return;
            }
            this.users.Add(user);
            Console.WriteLine($"{user.Name} joined room");
        }

        public void onUserLeave(User user)
        {
            bool success = this.users.Remove(user);
            if (!success)
            {
                return;
            }
            Console.WriteLine($"{user.Name} left room");
        }

        public void onUserSentMessage(User user, string message)
        {
            if (!this.users.Contains(user))
            {
                return;
            }
            var chatMessage = new ChatMessage(user, message);
            this.messages.Add(chatMessage);
            Console.WriteLine(chatMessage.ToString());
        }
    }

    public class User
    {
        public string Name { get; protected set; }
        protected IChatRoom chatRoom;


        public User(IChatRoom room, string username)
        {
            this.Name = username;
            this.chatRoom = room;
            this.chatRoom.onUserJoined(this);
        }

        public void JoinRoom(IChatRoom room)
        {
            this.chatRoom = room;
            this.chatRoom.onUserJoined(this);
        }

        public void LeaveRoom()
        {
            this.chatRoom.onUserLeave(this);
            this.chatRoom = null;
        }

        public void SendMessage(string message)
        {
            this.chatRoom.onUserSentMessage(this, message);
        }
    }
}