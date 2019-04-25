using System;
using System.Collections.Generic;
using System.Text;

namespace CBlunt.ANTLR
{
    class SymbolTable
    {
        // Store for variables in the class scope or "global" scope
        private Dictionary<string, VariableProperties> _classScopeVariablesDictionary = new Dictionary<string, VariableProperties>();

        // Linked list to handle scoping
        private LinkedList<Dictionary<string, VariableProperties>> _methodScopeLinkedList = new LinkedList<Dictionary<string, VariableProperties>>();

        // Dictionary for methods to store their properties
        private Dictionary<string, MethodProperties> _methodDictionary = new Dictionary<string, MethodProperties>();


    }
}
