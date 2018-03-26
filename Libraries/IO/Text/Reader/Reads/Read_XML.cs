using System;
using System.Collections.Generic;
using System.Xml;
using Libraries.IO.Text.Reader.Sources;

namespace Libraries.IO.Text.Reader.Reads
{
    public class Read_Xml : Read
    {
        public Read_Xml(Source source) : base(source) {}

        #region Public Methods
            
            public XmlElement Element()
            {
                 throw new NotImplementedException();
            }

            public ICollection<XmlElement> Elements<CollectionType>(uint count) where CollectionType : ICollection<XmlElement>
            {
                return RepeatReadFunction<XmlElement, CollectionType>(Element, count);
            }

        #endregion
    }
}
