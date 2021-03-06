// --------------------------------------------------
// ThemeEditor.Common - StreamTooShortException.cs
// --------------------------------------------------

using System.IO;

namespace ThemeEditor.Common.Compression
{
    //  Taken from YATA Project
    //  https://github.com/Reisyukaku/YATA/blob/master/LZ11.cs
    //  That may have been taken from pk3DS
    //  https://github.com/kwsch/pk3DS/blob/master/pk3DS/3DS/LZSS.cs
    //  That was a possible port of the DSDecmp Code
    //  https://github.com/Barubary/dsdecmp/tree/master/CSharp/DSDecmp
    //  Credits for all those guys

    /// <summary>
    ///     An exception thrown by the compression or decompression function, indicating that the
    ///     given input length was too large for the given input stream.
    /// </summary>
    public class StreamTooShortException : EndOfStreamException
    {
        /// <summary>
        ///     Creates a new exception that indicates that the stream was shorter than the given input length.
        /// </summary>
        public StreamTooShortException()
            : base("The end of the stream was reached "
                   + "before the given amout of data was read.") {}
    }
}
