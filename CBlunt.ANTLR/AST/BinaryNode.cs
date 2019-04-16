namespace CBlunt.ANTLR.AST
{
    public abstract class BinaryNode<L, R> : Node where L : Node where R : Node
    {
        public L LeftChild { get; set; }
        public R RightChild { get; set; }
    }
}