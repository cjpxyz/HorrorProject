using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{
    [SerializeField] private KeyItem.KeyType keyType;

    public KeyItem.KeyType GetKeyType()
    {
        return keyType;
    }
}
