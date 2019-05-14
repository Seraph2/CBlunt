using System;
using System.Collections.Generic;
using System.Text;

namespace CBlunt.ANTLR
{
    public static class SymbolTable
    {
        // Store for variables in the class scope or "global" scope
        //public static Dictionary<string, VariableProperties> _classScopeVariablesDictionary = new Dictionary<string, VariableProperties>();

        // Linked list to handle scoping
        //public static LinkedList<Dictionary<string, VariableProperties>> _methodScopeLinkedList = new LinkedList<Dictionary<string, VariableProperties>>();

        // Dictionary for methods to store their properties
        public static Dictionary<string, MethodProperties> MethodDictionary = new Dictionary<string, MethodProperties>();
    }

    /*
     * Store for a method's properties
     */
    public class MethodProperties
    {
        // The (return) type of the function
        public string Type { get; set; }

        // The list of parameter types this method takes (number, bool, text)
        public List<string> ParameterTypes = new List<string>();
    }

    /*
    * Store for expression
    */
    public class ExpressionStore
    {
        // The current type of the expression
        public string Type { get; set; }

        // The list of parameter types for the expression
        public LinkedList<string> ExpressionTypes = new LinkedList<string>();
    }
}
