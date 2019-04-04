using System;
using System.IO;
using Antlr4.Runtime;

namespace CBlunt.ANTLR
{
    internal class ThrowingErrorListener<TSymbol> : IAntlrErrorListener<TSymbol>
    {
        public void SyntaxError(TextWriter output, IRecognizer recognizer, TSymbol offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
        {
            throw new Exception($"line {line}:{charPositionInLine} {msg}");
        }
    }
}