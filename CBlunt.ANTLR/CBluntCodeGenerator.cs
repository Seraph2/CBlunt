﻿using System;
using System.Collections.Generic;
using System.Linq;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using CBlunt.ANTLR.AutoGeneratedParser;
using System.Reflection;
using System.IO;

namespace CBlunt.ANTLR
{
    class CBluntCodeGenerator : CBluntBaseVisitor<int>
    {
        string filepath;
        string filecontent;
        List<string> imports;


        public override int VisitStart([NotNull] CBluntParser.StartContext context)
        {
#if DEBUG
            Console.WriteLine("Beginning code generation");
            Console.WriteLine("VisitStart");
#endif
            this.imports.Add("using System;\n");
            this.AddText("namespace CBCode { \n class Program { \n");

            //We visit all children to initiate their translations
            for (int count = 0; count < context.ChildCount; ++count)
            {
                Visit(context.GetChild(count));
                if (context.GetChild(count).GetText() == ";")
                {
                    this.AddSemicolon();
                }
            }
            this.filecontent += "} }";
            //TODO: Rewrite to loop through the list for each entry instead.
            this.filecontent = this.imports.ToString() + this.filecontent;

            //After translation is done, the contents are saved to a file
            using (StreamWriter stream = File.CreateText(this.filepath))
            {
                stream.WriteLine(this.filecontent);
            }
#if DEBUG
                Console.WriteLine("Finished code generation");
#endif
            return 0;
        }

        public override int VisitDeclaration([NotNull] CBluntParser.DeclarationContext context)
        {
#if DEBUG
            Console.WriteLine("VisitDeclaration");
#endif
            this.ConvertVariableType(context.variabletype().GetText());

            this.AddText(context.ID().GetText());
            if (context.children.Count() > 2)
            {
                this.AddText("=");
                Visit(context.expression());
            }
            return 0;
        }

        public override int VisitFunction([NotNull] CBluntParser.FunctionContext context)
        {
#if DEBUG
            Console.WriteLine("VisitFunction");
#endif

            if (context.ID(0).GetText() == "Main")
            {
                this.filecontent += "static void Main()\n";
            } else
            {
                this.ConvertFunctionType(context.functiontype().GetText());
                this.AddText(context.ID(0).GetText() + "(");
                
                for (int counter = 0; counter < context.variabletype().Count(); ++counter)
                {
                    Visit(context.variabletype(counter));
                    this.AddText(context.ID(counter + 1).GetText());
                    if (counter < context.variabletype().Count() - 1) {
                        this.AddText(",");
                    }
                }

                this.AddText(")");

                
            }
            Visit(context.block());

            return 0;
        }

        public override int VisitVariabletype([NotNull] CBluntParser.VariabletypeContext context)
        {
            this.ConvertVariableType(context.GetChild(0).GetText());
            return 0;
        }

        //Update after merging Jakob's branch with the updated functioncall rules.
        //Fix multicommas reee
        public override int VisitFunctioncall([NotNull] CBluntParser.FunctioncallContext context)
        {
#if DEBUG
            Console.WriteLine("VisitFunctioncall");
#endif
            this.filecontent += context.ID().GetText() + " (";
            for (int count = 1; count < context.ChildCount; ++count)
            {
                Visit(context.GetChild(count));
                if (context.GetChild(count).GetText() != "(" && context.GetChild(count).GetText() != ")")
                {
                    this.filecontent += ", ";
                }
            }
            this.filecontent += ")";
            return 0;
        }

        public override int VisitStatement([NotNull] CBluntParser.StatementContext context)
        {
#if DEBUG
            Console.WriteLine("VisitStatement");
#endif
            for (int counter = 0; counter < context.children.Count; ++counter)
            {
                Visit(context.GetChild(counter));
                if (context.GetChild(counter).GetText() == ";")
                {
                    this.AddSemicolon();
                }
            }
            return 0;
        }

        public override int VisitParameter([NotNull] CBluntParser.ParameterContext context)
        {
#if DEBUG
            Console.WriteLine("VisitParameter");
#endif
            if (context.children.Count() > 1)
            {
                Visit(context.functioncall());
            } else
            {
                this.AddText(context.GetChild(0).GetText());
            }
            return 0;
        }

        public override int VisitVariableedit([NotNull] CBluntParser.VariableeditContext context)
        {
#if DEBUG
            Console.WriteLine("VisitVariableedit");

#endif
            this.AddText(context.ID().GetText());
            Visit(context.equals());
            Visit(context.expression());
            return 0;
        }

        public override int VisitEquals([NotNull] CBluntParser.EqualsContext context)
        {
#if DEBUG
            Console.WriteLine("VisitEquals");
#endif
            this.AddText(context.GetText());
            return base.VisitEquals(context);
        }

        public override int VisitExpression([NotNull] CBluntParser.ExpressionContext context)
        {
#if DEBUG
            Console.WriteLine("VisitExpression");
#endif
            Visit(context.parameter());
            for(int counter = 0; counter < context.calculation().Count(); ++counter)
            {
                Visit(context.calculation(counter));
            }
            return 0;
        }

        public override int VisitCalculation([NotNull] CBluntParser.CalculationContext context)
        {
#if DEBUG
            Console.WriteLine("VisitCalculation");
#endif
            //operator has @ because operator is normally a reserved keyword
            Visit(context.@operator());
            //Visits either a parameter or expression
            Visit(context.GetChild(1));
            return 0;
        }

        //TODO: MAKE
        public override int VisitOperator([NotNull] CBluntParser.OperatorContext context)
        {
#if DEBUG
            Console.WriteLine("VisitOperator");
#endif
            return base.VisitOperator(context);
        }

        public override int VisitIterative([NotNull] CBluntParser.IterativeContext context)
        {
#if DEBUG
            Console.WriteLine("VisitIterative");
#endif
            if (context.GetChild(0).GetText() == "while")
            {
                this.AddText("while (");
                Visit(context.condition());
                this.AddText(")");
                Visit(context.block());
            } 
            else if (context.GetChild(0).GetText() == "for")
            {
                this.AddText("for (");
                for (int counter = 2; counter < 8; ++counter) {
                    if (context.GetChild(counter).GetText() == ";")
                    {
                        this.AddSemicolon(false);
                    } else { Visit(context.GetChild(counter)); }
                }
                this.AddText(")");
                Visit(context.block());
            }
            return 0;
        }

        public override int VisitSelective([NotNull] CBluntParser.SelectiveContext context)
        {
            this.AddText(context.GetChild(0).GetText());
            this.AddText(context.GetChild(1).GetText());
            Visit(context.condition());
            this.AddText(context.GetChild(3).GetText());
            Visit(context.block());
            return 0;
        }

        public override int VisitCondition([NotNull] CBluntParser.ConditionContext context)
        {
#if DEBUG
            Console.WriteLine("VisitCondition");
#endif
            return base.VisitCondition(context);
        }

        public override int VisitBlock([NotNull] CBluntParser.BlockContext context)
        {
#if DEBUG
            Console.WriteLine("VisitBlock");
#endif
            AddText("{\n");
            for (int count = 0; count < context.ChildCount; ++count)
            {
                Visit(context.GetChild(count));
            }
            AddText("}\n");
            return 0;
        }

        public CBluntCodeGenerator() {
            string temppath = "Test";
            int count;
            for(count = 0; File.Exists(temppath); ++count){
                temppath = "Test" + count;
            }
            this.filepath = temppath;
            this.filecontent = "";
            imports = new List<string>();
        }

        private void ConvertFunctionType(string functiontype)
        {
            if (functiontype == "number")
            {
                this.filecontent += "double ";
            } else if (functiontype == "text ")
            {
                this.filecontent += "string";
            } else if (functiontype == "bool ")
            {
                this.filecontent += "Boolean";
            } else if (functiontype == "void")
            {
                this.filecontent += "void ";
            }
        }

        private void ConvertVariableType(string variabletype)
        {
            if (variabletype == "number")
            {
                this.filecontent += "double ";
            } else if (variabletype == "text")
            {
                this.filecontent += "string ";
            } else if (variabletype == "bool")
            {
                this.filecontent += "Boolean ";
            }
        }

        private void AddText(string text)
        {
            this.filecontent += text + " ";
        }

        private void AddSemicolon(Boolean withnewline = true)
        {
            this.filecontent += ";";
            if (withnewline) { this.filecontent += "\n"; } else { this.AddText(""); }
        }
    }
}