using AbstractNodes;

namespace CBlunt.ANTLR.AST.Arithmetics
{
    public class Number : Node
    {
        public decimal Value { get; set; }
    }
}