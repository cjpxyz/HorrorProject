using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<KeyItem.KeyType> keyList;

    void Start()
    {
        keyList = new List<KeyItem.KeyType>();
        keyList.Add(KeyItem.KeyType.zero);　//鍵を入手しなくても開けられるドアはKeyTypeをzeroに設定しておくこと
    }
}
