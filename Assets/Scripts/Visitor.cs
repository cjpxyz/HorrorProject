using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Visitor : MonoBehaviour
{
    // Start is called before the first frame update
    public abstract void Visit(ItemAcceptor acceptor);
    public abstract void Visit(DoorAcceptor acceptor);
    public abstract void Visit(NoteAcceptor acceptor);
}
