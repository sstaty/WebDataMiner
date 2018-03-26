using System;
using System.IO;

namespace Libraries.IO.Text.Reader.Sources
{
    public class Source_Web : Source
    { 

        public Source_Web(string url)
        {
            _stream = CreateStreamFromUrl(url);
            createStreamReader();
        }

        public override void Change(Source source)
        {
            throw new NotImplementedException();
        }

        private Stream CreateStreamFromUrl(string url)
        {
            byte[] imageData = null;

            using (var wc = new System.Net.WebClient())
                imageData = wc.DownloadData(url);

            return new MemoryStream(imageData);
        }
    }
}
