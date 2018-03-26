using System;
using System.Collections.Generic;
using Libraries.IO.Text.Reader.Sources;

namespace Libraries.IO.Text.Reader.Reads
{
    public enum READ_UNTIL { EndOfLine, EndOfStream};

    public abstract class Read
    {
        protected readonly Source _source;

        protected Read(Source source)
        {
            _source = source;
        }

        protected CollectionType RepeatReadFunction<FunctionType, CollectionType>(Func<FunctionType> function, uint count) where CollectionType : ICollection<FunctionType>
        {
            ICollection<FunctionType> collection = Activator.CreateInstance<CollectionType>();
                
            for (ulong i = 0; i < count; i++)
            {
                collection.Add(function());
            }

            return (CollectionType) collection;
        }

        protected CollectionType RepeatReadFunction<FunctionType, CollectionType>(Func<string[], FunctionType> function, string[] arguments, uint count) where CollectionType : ICollection<FunctionType>
        {
            ICollection<FunctionType> collection = Activator.CreateInstance<CollectionType>();

            for (ulong i = 0; i < count; i++)
            {
                collection.Add(function(arguments));
            }

            return (CollectionType) collection;
        }

        protected CollectionType RepeatReadFunction<FunctionType, CollectionType>(Func<FunctionType> function, READ_UNTIL until) where CollectionType : ICollection<FunctionType>
        {
            ICollection<FunctionType> collection = Activator.CreateInstance<CollectionType>();
                
            throw new NotImplementedException();

            return (CollectionType) collection;
        }

        protected CollectionType RepeatReadFunction<FunctionType, CollectionType>(Func<string[], FunctionType> function, string[] arguments, READ_UNTIL until) where CollectionType : ICollection<FunctionType>
        {
            ICollection<FunctionType> collection = Activator.CreateInstance<CollectionType>();
                
            throw new NotImplementedException();

            return (CollectionType) collection;
        }




        protected void RepeatReadVoid<FunctionType>(Func<FunctionType> function, uint count, ICollection<FunctionType> collection)
        {
            throw new NotImplementedException();
        }
        

    }
}
