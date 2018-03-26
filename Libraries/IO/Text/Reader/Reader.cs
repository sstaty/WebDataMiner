using Libraries.IO.Text.Reader.Reads;
using Libraries.IO.Text.Reader.Sources;

namespace Libraries.IO.Text.Reader
{
    public class Reader
    {
        #region Properties

            public Source Source { get; set; }

            public Read_Text Read_Text { get; }

            public Read_Type Read_Type { get; }

            public Read_Xml Read_XML { get; }

        #endregion

        #region Constructor
            
            public Reader(Source source)
            {
                Source = source;

                Read_Text = new Read_Text(source);
                Read_Type = new Read_Type(source);
                Read_XML = new Read_Xml(source);
            }

        #endregion
    }
}
