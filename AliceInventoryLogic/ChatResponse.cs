using System;
using System.Collections.Generic;
using System.Text;

namespace TestLogic
{
    public class ChatResponse: Entry
    {
        public UserAction userAction { get; set; }

        public enum UserAction
        {
            Add,
            deleteLast,
            readAll,
            clearAll
        }

        // Copy constructor
        public ChatResponse(ChatResponse newChatResponse): 
            this(newChatResponse.userAction, newChatResponse.ItemName, 
            newChatResponse.ItemCount, newChatResponse.Unit)
        {
        }

        // Instance constructor
        public ChatResponse(UserAction action, string itemName, double itemCount, Unit unit)
        {
            userAction = action;
            base.ItemName = itemName;
            base.ItemCount = itemCount;
            base.Unit = unit;
        }
    }
    
}
