using System;

namespace LearningBlazor.Chat
{
  public class Response
  {
    public string Text { get; set; }
    public DateTime TimeDelivered { get; set; }
    public Participant By { get; set; }

    public Response(string text)
    {
      Text = text;
      TimeDelivered = DateTime.Now;
    }
  }
}
