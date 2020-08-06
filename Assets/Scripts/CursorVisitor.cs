using EPOOutline;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorVisitor : Visitor
{
    private Ray ray;
    public Camera MainCamera;
    public float InteractDistance = 5f;

    public override void Visit(ItemAcceptor acceptor)
    {
        acceptor.Accept(this);
        Debug.Log("アイテムを取得");
    }

    public override void Visit(DoorAcceptor acceptor)
    {
        acceptor.Accept(this);
        Debug.Log("ドア開閉");
    }

    public override void Visit(NoteAcceptor acceptor)
    {
        acceptor.Accept(this);
        Debug.Log("ノートゲット");
    }

    // Start is called before the first frame update
    void Start()
    {
        ray = new Ray();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * InteractDistance, Color.red, 1);
        RaycastHit hit;


        if (Physics.Raycast(ray, out hit, InteractDistance))
        {
            if (hit.collider.CompareTag("KeyItem"))
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    {
                        GameObject game = hit.collider.gameObject;

                        ItemAcceptor item = game.GetComponent<ItemAcceptor>();
                        if (item != null) Visit(item);//対象オブジェクトにitemが含まれていればitemにアクセス

                        DoorAcceptor door = game.GetComponent<DoorAcceptor>();
                        if (door != null) Visit(door);//対象オブジェクトにdoorが含まれていればdoorにアクセス

                        NoteAcceptor note = game.GetComponent<NoteAcceptor>();
                        if (note != null) Visit(note);//対象オブジェクトにnoteが含まれていればnoteにアクセス
                    }
                }
            }
        }
    }
}
