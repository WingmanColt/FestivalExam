namespace FestivalManager.Core.IO
{
    using System.IO;
    public class StringReader 
	{
		private readonly StringReader reader;

		public StringReader(string contents)
		{
			this.reader = new StringReader(contents);
		}

		public string ReadLine() => this.reader.ReadLine();
	}
}