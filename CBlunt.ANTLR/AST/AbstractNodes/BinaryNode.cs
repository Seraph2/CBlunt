namespace CBlunt.ANTLR.AST.AbstractNodes
{
    public abstract class BinaryNode
    {
        public BinaryNode LeftChild { get; set; }
        public BinaryNode RightChild { get; set; }
    }
}