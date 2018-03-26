using System;
using System.IO;

namespace Libraries.IO.Text.Reader.Sources
{
    public class Source_String : Source
    {
        
        public Source_String(string value)
        {
            _stream = CreateStreamFromString(value);
            createStreamReader();
        }

        public override void Change(Source source)
        {
            throw new NotImplementedException();
        }

        private Stream CreateStreamFromString(string value)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(value);
            writer.Flush();
            stream.Position = 0;
            writer.Close();
            return stream;
        }
    }
}
