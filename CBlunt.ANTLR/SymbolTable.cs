using System;
using System.Collections.Generic;
using System.Text;

namespace CBlunt.ANTLR
{
    public static class SymbolTable
    {
        // Store for variables in the class scope or "global" scope
        public static Dictionary<string, VariableProperties> ClassScopeVariablesDictionary = new Dictionary<string, VariableProperties>();

        // Linked list to handle method scoping
        public static LinkedList<Dictionary<string, VariableProperties>> MethodScopeLinkedList = new LinkedList<Dictionary<string, VariableProperties>>();

        // Dictionary for methods to store their properties
        public static Dictionary<string, MethodProperties> MethodDictionary = new Dictionary<string, MethodProperties>();

        // Linked List for handling expressions
        public static LinkedList<ExpressionStore> ExpressionStoreLinkedList = new LinkedList<ExpressionStore>();

        // Storage of the current method type for returning
        public static string CurrentMethodType = "";
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

    /*
     * Store for a variable's properties
     */
    public class VariableProperties
    {
        // The type of the variable (number, text, bool etc.)
        public string Type { get; set; }

        // Determine whether the variable has been initialized or not (aka null)
        // It is impossible to initialize a variable with null in CBlunt, therefore this only applies to ex:
        // number a;
        public bool Initialized { get; set; }

        // If not specified, the value of the variable is null
        public VariableProperties(string type, string value = null)
        {
            // Set the variable's type
            Type = type;

            if (value != null)
                Initialized = true;
        }
    }
}
