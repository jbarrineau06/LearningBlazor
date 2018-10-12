using LearningBlazor.Chat;
using System;
using System.Linq;
using System.Collections.Generic;

namespace LearningBlazor.BrowserState
{
  public class StateManager
  {
    public List<Response> CommunicationLog { get { return _conversationState.CommunicationLog.OrderByDescending(x => x.TimeDelivered).ToList(); } }
    private Conversation _conversationState { get; set; }

    public StateManager()
    {
      _conversationState = new Conversation();
    }

    public void AcceptResponse(string response)
    {
      Console.WriteLine($"Adding {response}");
      _conversationState.CommunicationLog.Add(new Response(response));
    }
  }
}
