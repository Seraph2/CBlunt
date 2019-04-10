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
using System.Threading;

namespace CBlunt.ANTLR
{
    class Program
    {
        private static FileSystemWatcher _watcher;

        private static string GetInput()
        {
            Console.Write("Enter a value to evaluate: ");
            return Console.ReadLine();
        }

        private static void EvaluateInput(string input)
        {
            CBluntLexer lexer = new CBluntLexer(new AntlrInputStream(input));

            lexer.RemoveErrorListeners();
            lexer.AddErrorListener(new ThrowingErrorListener<int>());

            CBluntParser parser = new CBluntParser(new CommonTokenStream(lexer));

            parser.RemoveErrorListeners();
            parser.AddErrorListener(new ThrowingErrorListener<IToken>());

            // Check semantics
            new CBluntSemanticChecker().Visit(parser.start());

            // Generate code
            //new CBluntCodeGenerator().Visit(parser.start());
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
            InitializeFileSystemWatcher();
            LoadFile("SampleCode.txt");

             // Continually loop forever as the program should not stop
            while (true)
            {
                // Reduce CPU usage marginally
                Thread.Sleep(1);
            }
        }

        static void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            LoadFile(e.FullPath);
        }

        private static void LoadFile(string filePath)
        {
            // Clear console for clean output
            Console.Clear();

            // Write out timestamp
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff"));

            // Try-catch is used because an exception can be thrown
            try
            {
                // Read text from the changed file
                string fileText = File.ReadAllText(filePath);

                // Give result if success, display error when failed to parse
                EvaluateInput(fileText);
            }
            catch (Exception exception)
            {
                DisplayError(exception);
            }
        }

        private static void InitializeFileSystemWatcher()
        {
             // Initialize watcher in current directory
            _watcher = new FileSystemWatcher(".");
            
             // Add the method to execute when a file is changed
            _watcher.Changed += new FileSystemEventHandler(Watcher_Changed);
            _watcher.EnableRaisingEvents = true;
            _watcher.IncludeSubdirectories = true;
        }
    }
}
