﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using CBlunt.ANTLR.Parser;

namespace CBlunt.ANTLR
{
    class Program
    {
        private static string GetInput()
        {
            Console.Write("Enter a value to evaluate: ");
            return Console.ReadLine();
        }

        private static int EvaluateInput(string input)
        {
            CalculatorLexer lexer = new CalculatorLexer(new AntlrInputStream(input));

            lexer.RemoveErrorListeners();
            lexer.AddErrorListener(new ThrowingErrorListener<int>());

            CalculatorParser parser = new CalculatorParser(new CommonTokenStream(lexer));

            parser.RemoveErrorListeners();
            parser.AddErrorListener(new ThrowingErrorListener<IToken>());

            return new CalculatorVisitor().Visit(parser.expression());
        }

        private static void DisplayResult(int result)
        {
            Console.WriteLine($"Result: {result}");
        }

        private static void DisplayError(Exception ex)
        {
            Console.WriteLine("Something didn't go as expected:");
            Console.WriteLine(ex.Message);
        }

        public static void Main()
        {
            try
            {
                string input = GetInput();
                int result = EvaluateInput(input);

                DisplayResult(result);
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }

            Console.Write($"{Environment.NewLine}Press ENTER to exit: ");
            Console.ReadKey();
        }
    }
}
