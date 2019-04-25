using System;
using System.Collections.Generic;
using System.Text;

namespace CBlunt.ANTLR
{
    class SymbolTable
    {
        private Dictionary<string, VariableProperties> _classScopeVariablesDictionary = new Dictionary<string, VariableProperties>();
        private LinkedList<Dictionary<string, VariableProperties>> _methodScopeLinkedList = new LinkedList<Dictionary<string, VariableProperties>>();
        private Dictionary<string, MethodProperties> _methodDictionary = new Dictionary<string, MethodProperties>();


    }
}
