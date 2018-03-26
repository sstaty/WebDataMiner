using System;
using System.Collections.Generic;
using Libraries.IO.Text.Reader.Automatons;
using Libraries.IO.Text.Reader.Sources;

namespace Libraries.IO.Text.Reader.Reads
{
    public class Read_Text : Read
    {
        public readonly Automaton_Text WhiteSpacesAutomaton = new Automaton_Text(' ', '\t', '\n');
        public readonly Automaton_Text EndLineAutomaton = new Automaton_Text('\n');

        public Read_Text(Source source) : base(source) {}

        #region Read Single
            
            #region Direct Use Of StreamReader

                public String ToEnd()
                {
                    return _source._streamReader.ReadToEnd();
                }

                public char? Letter()
                {
                    return (char)_source._streamReader.Read();
                }

            #endregion

            #region Using Letter()
                
                public String Line(bool skipBeginDeviders)
                {
                    return Segment(skipBeginDeviders, EndLineAutomaton);
                }

                public String Word(bool skipBeginDeviders = true)
                {
                    return Segment(skipBeginWhiteSpaces, WhiteSpacesAutomaton);
                }

                public String Segment(bool skipBeginDeviders, params char[] deviders)
                {
                    return Segment(skipBeginDeviders, new Automaton_Text(deviders));
                }

                public String Segment(bool skipBeginDeviders, params String[] deviders)
                {
                    return Segment(skipBeginDeviders, new Automaton_Text(deviders));
                }

                public String Segment(bool skipBeginDeviders, char[] charDeviders, String[] stringDeviders)
                {
                    return Segment(skipBeginDeviders, new Automaton_Text(charDeviders, stringDeviders));
                }
            
                public String Segment(bool skipBeginDeviders, Automaton_Text automaton)
                {
                    while (automaton.ProccessCharacter(Letter())) {}
                    return automaton.GetResultAndRestart();
                }

            #endregion

        #endregion

        #region Read Multiple

            #region COUNT - DEFAULT = List<>

                public List<String> Lines(uint count)
                {
                    return (List<String>) Lines<List<String>>(count);
                }

                public List<String> Words(uint count)
                {
                    return (List<String>)Words<List<String>>(count);
                }

                public List<String> Segments(uint count, params String[] deviders)
                {
                    return (List<String>)Segments<List<String>>(count, deviders);
                }

                public List<char> Letters(uint count)
                {
                    return (List<char>)Letters<List<char>>(count);
                }

            #endregion

            #region COUNT - GENERIC

                public ICollection<String> Lines<CollectionType>(uint count) where CollectionType : ICollection<String>
                {
                    return RepeatReadFunction<String, CollectionType>(Line, count);
                }

                public ICollection<String> Words<CollectionType> (uint count) where  CollectionType : ICollection<String>
                {
                    return RepeatReadFunction<String, CollectionType>(Word, count);
                }

                public ICollection<String> Segments<CollectionType>(uint count, params String[] deviders) where CollectionType : ICollection<String>
                {
                    return RepeatReadFunction<String, CollectionType>(Segment, deviders, count);
                }

                public ICollection<char> Letters<CollectionType>(uint count) where CollectionType : ICollection<char>
                {
                    return RepeatReadFunction<char, CollectionType>(Letter, count);
                }

            #endregion

            #region UNTIL - DEFAULT = List<>
                
                public List<String> Lines(READ_UNTIL until)
                {
                    return (List<String>) Lines<List<String>>(until);
                }

                public List<String> Words(READ_UNTIL until)
                {
                    return (List<String>)Words<List<String>>(until);
                }

                public List<String> Segments(READ_UNTIL until, params String[] deviders)
                {
                    return (List<String>)Segments<List<String>>(until, deviders);
                }

                public List<char> Letters(READ_UNTIL until)
                {
                    return (List<char>)Letters<List<char>>(until);
                }

            #endregion

            #region GENERIC

                public ICollection<String> Lines<CollectionType>(READ_UNTIL until) where CollectionType : ICollection<String>
                {
                    return RepeatReadFunction<String, CollectionType>(Line, until);
                }

                public ICollection<String> Words<CollectionType> (READ_UNTIL until) where  CollectionType : ICollection<String>
                {
                    return RepeatReadFunction<String, CollectionType>(Word, until);
                }

                public ICollection<String> Segments<CollectionType>(READ_UNTIL until, params String[] deviders) where CollectionType : ICollection<String>
                {
                    return RepeatReadFunction<String, CollectionType>(Segment, deviders, until);
                }

                public ICollection<char> Letters<CollectionType>(READ_UNTIL until) where CollectionType : ICollection<char>
                {
                    return RepeatReadFunction<char, CollectionType>(Letter, until);
                } 

            #endregion

        #endregion  

    }


}
