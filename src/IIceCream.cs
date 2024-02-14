namespace VisitorDesignPattern.src
{
    interface IIceCream
    {
        void Accept(IVisitor visitor);
    }

}