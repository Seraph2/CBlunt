﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime.Tree;
using CBlunt.ANTLR;
using static CBlunt.ANTLR.SpeakParser;

namespace CBlunt.ANTLR
{    
    public class SpeakVisitor : SpeakBaseVisitor<object>
    {
        public List<SpeakLine> Lines = new List<SpeakLine>();

        public override object VisitLine(SpeakParser.LineContext context)
        {            
            NameContext name = context.name();
            OpinionContext opinion = context.opinion();

            SpeakLine line = new SpeakLine() { Person = name.GetText(), Text = opinion.GetText().Trim('"') };
            Lines.Add(line);

            return line;
        }
    }
}
