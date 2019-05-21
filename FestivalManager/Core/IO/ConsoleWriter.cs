using System;
using System.Text;
using FestivalManager.Core.IO.Contracts;

namespace FestivalManager.Core.IO
{
    public class ConsoleWriter : IWriter
    {
        private StringBuilder sb;

        public ConsoleWriter()
        {
            this.sb = new StringBuilder();
        }

        public string StoredMessage
        {
            get => this.sb.ToString();
        }

        public void WriteLine(string contents)
        {
            Console.WriteLine(contents);
        }

        public void Write(string contents)
        {
            Console.WriteLine(contents);
        }

        public void StoreMessage(string message)
        {
            this.sb.AppendLine(message.Trim());
        }
    }
}