using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItem : MonoBehaviour
{
    [SerializeField] private KeyType keyType;

    public enum KeyType
    {
        zero, 
        one, 
        two, 
        three,
    }

    public KeyType GetKeyType()
    {
        return keyType;　//鍵の種類を返す
    }
}
