namespace CBlunt.ANTLR.AST
{
    public abstract class UnaryNode<C> : Node where C : Node
    {
        public C Child { get; set; }
    }
}