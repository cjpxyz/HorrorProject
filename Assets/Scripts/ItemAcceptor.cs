using UnityEngine;

public class ItemAcceptor : Acceptor
{
    public override void Accept(Visitor visitor)
    {
        Destroy(gameObject, 0.1f);
    }
}