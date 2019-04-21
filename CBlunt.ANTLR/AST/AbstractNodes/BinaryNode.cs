namespace CBlunt.ANTLR.AST.AbstractNodes
{
    public abstract class BinaryNode<L, R> : Node where L : Node where R : Node
    {
        public L LeftChild { get; set; }
        public R RightChild { get; set; }
    }
}