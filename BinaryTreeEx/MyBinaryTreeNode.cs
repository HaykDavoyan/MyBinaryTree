namespace BinaryTreeEx;

class MyBinaryTreeNode<T> : IComparable<T>
        where T : IComparable
{
    public T Data { get; private set; }
    public MyBinaryTreeNode<T> Left { get; private set; }
    public MyBinaryTreeNode<T> Right { get; private set; }

    public MyBinaryTreeNode(T data)
    {
        Data = data;
    }

    public MyBinaryTreeNode(T data, MyBinaryTreeNode<T> left, MyBinaryTreeNode<T> right)
    {
        Data = data;
        Left = left;
        Right = right;
    }

    public void Add(T data)
    {
        var node = new MyBinaryTreeNode<T>(data);

        if (node.Data.CompareTo(Data) == -1)
        {
            if (Left == null)
            {
                Left = node;
            }
            else
            {
                Left.Add(data);
            }
        }
        else
        {
            if (Right == null)
            {
                Right = node;
            }
            else
            {
                Right.Add(data);
            }
        }
    }

    public int CompareTo(object obj)
    {
        if (obj is MyBinaryTreeNode<T> item)
        {
            return Data.CompareTo(item);
        }
        else
        {
            throw new ArgumentException("Types are not the same");
        }
    }

    public int CompareTo(T other)
    {
        return Data.CompareTo(other);
    }

    public override string ToString()
    {
        return Data.ToString();
    }
}
