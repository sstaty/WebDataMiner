using System;
using System.Collections.Generic;
using Libraries.IO.Text.Reader.Sources;

namespace Libraries.IO.Text.Reader.Reads
{ 
    public class Read_Type : Read
    {
        public Read_Type(Source source) : base(source) {}

        #region Read Single
            
            #region Direct Use Of StreamReader

                public char? Char()
                {
                    throw new NotImplementedException();
                }

            #endregion

            #region Using Char()

                public byte? Byte(bool autoFind = false)
                {
                    throw new NotImplementedException();
                }

                public sbyte? SByte(bool autoFind = false)
                {
                    throw new NotImplementedException();
                }

                public short? Short(bool autoFind = false)
                {
                    throw new NotImplementedException();
                }

                public ushort? UShort(bool autoFind = false)
                {
                    throw new NotImplementedException();
                }

                public int? Int(bool autoFind = false)
                {
                    throw new NotImplementedException();
                }

                public uint? UInt(bool autoFind = false)
                {
                    throw new NotImplementedException();
                }

                public long? Long(bool autoFind = false)
                {
                    throw new NotImplementedException();
                }

                public ulong? ULong(bool autoFind = false)
                {
                    throw new NotImplementedException();
                }

                public float? Float(bool autoFind = false)
                {
                    throw new NotImplementedException();
                }

                public double? Double(bool autoFind = false)
                {
                    throw new NotImplementedException();
                }

                public Decimal? Decimal(bool autoFind = false)
                {
                    throw new NotImplementedException();
                }

                public DateTime? DateTime(bool autoFind = false)
                {
                    throw new NotImplementedException();
                }

                public TimeSpan? TimeSpan(bool autoFind = false)
                {
                    throw new NotImplementedException();
                }

            #endregion

        #region Read Multiple
            
            #region COUNT

                #region DEFAULT = List

                    public List<char> Chars(uint count)
                    {
                        return Chars<List<char>>(count);
                    }

                    public List<byte> Bytes(uint count)
                    {
                        return Bytes<List<byte>>(count);
                    }

                    public List<sbyte> SBytes(uint count)
                    {
                        return SBytes<List<sbyte>>(count);
                    }

                    public List<short> Shorts(uint count)
                    {
                        return Shorts<List<short>>(count);
                    }

                    public List<ushort> UShorts(uint count)
                    {
                        return UShorts<List<ushort>>(count);
                    }

                    public List<int> Ints(uint count)
                    {
                        return Ints<List<int>>(count);
                    }

                    public List<uint> UInts(uint count)
                    {
                        return UInts<List<uint>>(count);
                    }

                    public List<long> Longs(uint count)
                    {
                        return Longs<List<long>>(count);
                    }

                    public List<ulong> ULongs(uint count)
                    {
                        return ULongs<List<ulong>>(count);
                    }

                    public List<float> Floats(uint count)
                    {
                        return Floats<List<float>>(count);
                    }

                    public List<double> Doubles(uint count)
                    {
                        return Doubles<List<double>>(count);
                    }

                    public List<decimal> Decimals(uint count)
                    {
                        return Decimals<List<decimal>>(count);
                    }

                    public List<DateTime> DateTimes(uint count)
                    {
                        return DateTimes<List<DateTime>>(count);
                    }

                    public List<TimeSpan> TimeSpans(uint count)
                    {
                        return TimeSpans<List<TimeSpan>>(count);
                    }

                #endregion

                #region GENERIC

                    public CollectionType Chars<CollectionType>(uint count) where CollectionType : ICollection<char>
                    {
                        return RepeatReadFunction<char, CollectionType>(Char, count);
                    }

                    public CollectionType Bytes<CollectionType>(uint count) where CollectionType : ICollection<byte>
                    {
                        return RepeatReadFunction<byte, CollectionType>(Byte, count);
                    }

                    public CollectionType SBytes<CollectionType>(uint count) where CollectionType : ICollection<sbyte>
                    {
                        return RepeatReadFunction<sbyte, CollectionType>(SByte, count);
                    }

                    public CollectionType Shorts<CollectionType>(uint count) where CollectionType : ICollection<short>
                    {
                        return RepeatReadFunction<short, CollectionType>(Short, count);
                    }

                    public CollectionType UShorts<CollectionType>(uint count) where CollectionType : ICollection<ushort>
                    {
                        return RepeatReadFunction<ushort, CollectionType>(UShort, count);
                    }

                    public CollectionType Ints<CollectionType>(uint count) where CollectionType : ICollection<int>
                    {
                        return RepeatReadFunction<int, CollectionType>(Int, count);
                    }

                    public CollectionType UInts<CollectionType>(uint count) where CollectionType : ICollection<uint>
                    {
                        return RepeatReadFunction<uint, CollectionType>(UInt, count);
                    }

                    public CollectionType Longs<CollectionType>(uint count) where CollectionType : ICollection<long>
                    {
                        return RepeatReadFunction<long, CollectionType>(Long, count);
                    }

                    public CollectionType ULongs<CollectionType>(uint count) where CollectionType : ICollection<ulong>
                    {
                        return RepeatReadFunction<ulong, CollectionType>(ULong, count);
                    }

                    public CollectionType Floats<CollectionType>(uint count) where CollectionType : ICollection<float>
                    {
                        return RepeatReadFunction<float, CollectionType>(Float, count);
                    }

                    public CollectionType Doubles<CollectionType>(uint count) where CollectionType : ICollection<double>
                    {
                        return RepeatReadFunction<double, CollectionType>(Double, count);
                    }

                    public CollectionType Decimals<CollectionType>(uint count) where CollectionType : ICollection<decimal>
                    {
                        return RepeatReadFunction<decimal, CollectionType>(Decimal, count);
                    }

                    public CollectionType DateTimes<CollectionType>(uint count) where CollectionType : ICollection<DateTime>
                    {
                        return RepeatReadFunction<DateTime, CollectionType>(DateTime, count);
                    }

                    public CollectionType TimeSpans<CollectionType>(uint count) where CollectionType : ICollection<TimeSpan>
                    {
                        return RepeatReadFunction<TimeSpan, CollectionType>(TimeSpan, count);
                    }

                #endregion

                #region ARGUMENT

                    public void Chars(uint count, ICollection<char> collection) 
                    {
                        RepeatReadVoid<char>(Char, count, collection);
                    }

                    public void Bytes(uint count, ICollection<byte> collection)
                    {
                        RepeatReadVoid<byte>(Byte, count, collection);
                    }

                    public void SBytes(uint count, ICollection<sbyte> collection)
                    {
                        RepeatReadVoid<sbyte>(SByte, count, collection);
                    }

                    public void Shorts(uint count, ICollection<short> collection)
                    {
                        RepeatReadVoid<short>(Short, count, collection);
                    }

                    public void UShorts(uint count, ICollection<ushort> collection)
                    {
                        RepeatReadVoid<ushort>(UShort, count, collection);
                    }

                    public void Ints(uint count, ICollection<int> collection)
                    {
                        RepeatReadVoid<int>(Int, count, collection);
                    }

                    public void UInts(uint count, ICollection<uint> collection)
                    {
                        RepeatReadVoid<uint>(UInt, count, collection);
                    }

                    public void Longs(uint count, ICollection<long> collection) 
                    {
                        RepeatReadVoid<long>(Long, count, collection);
                    }

                    public void ULongs(uint count, ICollection<ulong> collection)
                    {
                        RepeatReadVoid<ulong>(ULong, count, collection);
                    }

                    public void Floats(uint count, ICollection<float> collection)
                    {
                        RepeatReadVoid<float>(Float, count, collection);
                    }

                    public void Doubles(uint count, ICollection<double> collection)
                    {
                        RepeatReadVoid<double>(Double, count, collection);
                    }

                    public void Decimals(uint count, ICollection<decimal> collection) 
                    {
                        RepeatReadVoid<decimal>(Decimal, count, collection);
                    }

                    public void DateTimes(uint count, ICollection<DateTime> collection) 
                    {
                        RepeatReadVoid<DateTime>(DateTime, count, collection);
                    }

                    public void TimeSpans(uint count, ICollection<TimeSpan> collection)
                    {
                        RepeatReadVoid<TimeSpan>(TimeSpan, count, collection);
                    }

                #endregion

            #endregion
            
            #region UNTIL

                #region DEFAULT = List

                    public List<char> Chars(READ_UNTIL until)
                    {
                        return Chars<List<char>>(until);
                    }

                    public List<byte> Bytes(READ_UNTIL until)
                    {
                        return Bytes<List<byte>>(until);
                    }

                    public List<sbyte> SBytes(READ_UNTIL until)
                    {
                        return SBytes<List<sbyte>>(until);
                    }

                    public List<short> Shorts(READ_UNTIL until)
                    {
                        return Shorts<List<short>>(until);
                    }

                    public List<ushort> UShorts(READ_UNTIL until)
                    {
                        return UShorts<List<ushort>>(until);
                    }

                    public List<int> Ints(READ_UNTIL until)
                    {
                        return Ints<List<int>>(until);
                    }

                    public List<uint> UInts(READ_UNTIL until)
                    {
                        return UInts<List<uint>>(until);
                    }

                    public List<long> Longs(READ_UNTIL until)
                    {
                        return Longs<List<long>>(until);
                    }

                    public List<ulong> ULongs(READ_UNTIL until)
                    {
                        return ULongs<List<ulong>>(until);
                    }

                    public List<float> Floats(READ_UNTIL until)
                    {
                        return Floats<List<float>>(until);
                    }

                    public List<double> Doubles(READ_UNTIL until)
                    {
                        return Doubles<List<double>>(until);
                    }

                    public List<decimal> Decimals(READ_UNTIL until)
                    {
                        return Decimals<List<decimal>>(until);
                    }

                    public List<DateTime> DateTimes(READ_UNTIL until)
                    {
                        return DateTimes<List<DateTime>>(until);
                    }

                    public List<TimeSpan> TimeSpans(READ_UNTIL until)
                    {
                        return TimeSpans<List<TimeSpan>>(until);
                    }

                #endregion

                #region GENERIC

                    public CollectionType Chars<CollectionType>(READ_UNTIL until) where CollectionType : ICollection<char>
                    {
                        return RepeatReadFunction<char, CollectionType>(Char, until);
                    }

                    public CollectionType Bytes<CollectionType>(READ_UNTIL until) where CollectionType : ICollection<byte>
                    {
                        return RepeatReadFunction<byte, CollectionType>(Byte, until);
                    }

                    public CollectionType SBytes<CollectionType>(READ_UNTIL until) where CollectionType : ICollection<sbyte>
                    {
                        return RepeatReadFunction<sbyte, CollectionType>(SByte, until);
                    }

                    public CollectionType Shorts<CollectionType>(READ_UNTIL until) where CollectionType : ICollection<short>
                    {
                        return RepeatReadFunction<short, CollectionType>(Short, until);
                    }

                    public CollectionType UShorts<CollectionType>(READ_UNTIL until) where CollectionType : ICollection<ushort>
                    {
                        return RepeatReadFunction<ushort, CollectionType>(UShort, until);
                    }

                    public CollectionType Ints<CollectionType>(READ_UNTIL until) where CollectionType : ICollection<int>
                    {
                        return RepeatReadFunction<int, CollectionType>(Int, until);
                    }

                    public CollectionType UInts<CollectionType>(READ_UNTIL until) where CollectionType : ICollection<uint>
                    {
                        return RepeatReadFunction<uint, CollectionType>(UInt, until);
                    }

                    public CollectionType Longs<CollectionType>(READ_UNTIL until) where CollectionType : ICollection<long>
                    {
                        return RepeatReadFunction<long, CollectionType>(Long, until);
                    }

                    public CollectionType ULongs<CollectionType>(READ_UNTIL until) where CollectionType : ICollection<ulong>
                    {
                        return RepeatReadFunction<ulong, CollectionType>(ULong, until);
                    }

                    public CollectionType Floats<CollectionType>(READ_UNTIL until) where CollectionType : ICollection<float>
                    {
                        return RepeatReadFunction<float, CollectionType>(Float, until);
                    }

                    public CollectionType Doubles<CollectionType>(READ_UNTIL until) where CollectionType : ICollection<double>
                    {
                        return RepeatReadFunction<double, CollectionType>(Double, until);
                    }

                    public CollectionType Decimals<CollectionType>(READ_UNTIL until) where CollectionType : ICollection<decimal>
                    {
                        return RepeatReadFunction<decimal, CollectionType>(Decimal, until);
                    }

                    public CollectionType DateTimes<CollectionType>(READ_UNTIL until) where CollectionType : ICollection<DateTime>
                    {
                        return RepeatReadFunction<DateTime, CollectionType>(DateTime, until);
                    }

                    public CollectionType TimeSpans<CollectionType>(READ_UNTIL until) where CollectionType : ICollection<TimeSpan>
                    {
                        return RepeatReadFunction<TimeSpan, CollectionType>(TimeSpan, until);
                    }

                #endregion

                #region ARGUMENT

                #endregion

            #endregion

        #endregion
    }
}
