using System.Diagnostics;

namespace WinFormsApp1
{
    public class Engine
    {
        public bool SendMessage(string message)
        {
            Debug.WriteLine("Message Sent!");
            return true;
        }
    }
}