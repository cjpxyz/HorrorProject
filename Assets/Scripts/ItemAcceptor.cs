using UnityEngine;

public class ItemAcceptor : Acceptor
{
    GameObject player;
    Inventory inventory;

    void Start()
    {
        player = GameObject.Find("FirstPersonCharacter"); 
        inventory = player.GetComponent<Inventory>(); 
    }
    public void AddKey(KeyItem.KeyType keytype)
    {
        Debug.Log("鍵げっちゅ" + keytype);
        inventory.keyList.Add(keytype);
    }
    public override void Accept(Visitor visitor)
    {
        KeyItem keyItem = GetComponent<KeyItem>();
        if(keyItem != null)
        {
            AddKey(keyItem.GetKeyType());
        }
        Destroy(gameObject, 0.1f);
    }
}