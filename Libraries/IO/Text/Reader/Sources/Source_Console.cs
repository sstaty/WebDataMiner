using System;

namespace Libraries.IO.Text.Reader.Sources
{
    public class Source_Console : Source
    {

        public Source_Console()
        {
            _stream = System.Console.OpenStandardInput();
            createStreamReader();
        }

        public override void Change(Source source)
        {
            throw new NotImplementedException();
        }
    }
}
