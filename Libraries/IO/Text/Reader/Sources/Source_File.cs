using System;
using System.IO;

namespace Libraries.IO.Text.Reader.Sources
{
    public class Source_File : Source
    {

        public Source_File(string path)
        {
            _stream = new FileStream(path, FileMode.Open);
            createStreamReader();
        }

        public override void Change(Source source)
        {
            throw new NotImplementedException();
        }
    }
}
