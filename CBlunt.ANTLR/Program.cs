﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using CBlunt.ANTLR.AutoGeneratedParser;

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


            CBluntLexer lexer = new CBluntLexer(new AntlrInputStream(input));

            lexer.RemoveErrorListeners();
            lexer.AddErrorListener(new ThrowingErrorListener<int>());

            CBluntParser parser = new CBluntParser(new CommonTokenStream(lexer));

            parser.RemoveErrorListeners();
            parser.AddErrorListener(new ThrowingErrorListener<IToken>());

            return new CBluntVisitor().Visit(parser.start());
        }

        private static void DisplayResult(int result)
        {
            Console.WriteLine($"Result: {result}");
        }

        private static void DisplayError(Exception ex)
        {
            Console.WriteLine("Parser error:");
            Console.WriteLine(ex.Message);
        }

        public static void Main()
        {
            try
            {
                //string input = "void Main() { tarwaeawrwer } int cool = \"123\"; void test(int a) { }";

                string input = "void Main() { number a = 123; string b = \"hello\";  if(1 > 5){ number d = 3; } while(a > b){ number array rawass = { 5, 13, 25 }; rawass[2] = 5; } } void Method(void a, void b) { number testing = 12345; } void Method2() { Call(123,456,\"hello\"); }";
                int result = EvaluateInput(input);
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
