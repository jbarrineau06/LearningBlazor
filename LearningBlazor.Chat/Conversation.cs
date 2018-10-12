using System.Collections.Generic;

namespace LearningBlazor.Chat
{
  public class Conversation
  {
    public List<Response> CommunicationLog { get; set; }

    public Conversation()
    {
      CommunicationLog = new List<Response>();
    }
  }
}
