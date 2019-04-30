using CBlunt.ANTLR.AST.AbstractNodes;

namespace CBlunt.ANTLR.AST.String
{
    public class StringExpression<L, R> : BinaryNode<L, R>, StringNode where L : StringNode where R : StringNode
    {
        
    }
}