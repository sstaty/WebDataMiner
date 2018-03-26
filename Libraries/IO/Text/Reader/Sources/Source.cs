using System.IO;

namespace Libraries.IO.Text.Reader.Sources
{
    public abstract class Source
    {
        #region Variables 

            protected Stream _stream;

            internal StreamReader _streamReader;

            protected bool _isStarted;
            protected bool _isFinished;

        #endregion

        #region Properties

            public bool IsStarted { get; }

            public bool IsFinished { get; }

        #endregion

        #region Protected Methods

            protected void createStreamReader()
            {
                _streamReader = new StreamReader(_stream);

                _isStarted = true;
                _isFinished = false;
            }

        #endregion

        #region Public Methods

            public void Close()
            {
                _streamReader.Close();

                _isStarted = false;
            }

            public abstract void Change(Source source);

        #endregion
    } 
}
