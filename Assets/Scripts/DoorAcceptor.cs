using UnityEngine;

public class DoorAcceptor : Acceptor
{
    public bool open = false;
    public float doorOpenAngle = 90f;
    public float doorCloseAngle = 0f;
    public float smooth = 2f;

    /*追々追加予定
    public AudioClip OpenSound;
    public AudioClip CloseSound;
    public AudioClip LockedSound;
    */

    [SerializeField] private KeyItem.KeyType keyType;
    GameObject player;
    Inventory inventory;

    void Start()
    {
        player = GameObject.Find("FirstPersonCharacter");
        inventory = player.GetComponent<Inventory>();
    }

    public override void Accept(Visitor visitor)
    {
        if (inventory.keyList.Contains(keyType))//プレイヤーがドアに対応した鍵を持っていれば
        {
            open = !open;
        }
        else
        {
            //鍵がないというメッセージを表示する機能を追々追加したい
            Debug.Log("BAKAME");
            //GetComponent<AudioSource>().PlayOneShot(LockedSound);
        }

    }

    void Update()
    {
        if (open)
        {
            Quaternion targetRotation = Quaternion.Euler(0, doorOpenAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);
            //GetComponent<AudioSource>().PlayOneShot(OpenSound);
        }
        else
        {
            Quaternion targetRotation2 = Quaternion.Euler(0, doorCloseAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation2, smooth * Time.deltaTime);
            //GetComponent<AudioSource>().PlayOneShot(CloseSound);
        }
    }
}



/*using UnityEngine;    没スクリプト

public class DoorAcceptor : Acceptor
{
    public bool open = false;
    public float doorOpenAngle = 90f;
    public float doorCloseAngle = 0f;
    public float smooth = 2f;


    GameObject player;
    Inventory inventory;

    void Start()
    {
        player = GameObject.Find("FirstPersonCharacter");
        inventory = player.GetComponent<Inventory>();
    }

    public bool ContainsKey(KeyItem.KeyType keyType)
    {
        return inventory.keyList.Contains(keyType);
    }

    public override void Accept(Visitor visitor)
    {
        KeyDoor keyDoor = GetComponent<KeyDoor>();
        if (keyDoor != null)
        {
            if (ContainsKey(KeyDoor.GetKeyType()))
            {
                open = !open;
            }
            else
            {
                Debug.Log("BAKAME");
            }
        }


    }

    void Update()
    {
        if (open)
        {
            Quaternion targetRotation = Quaternion.Euler(0, doorOpenAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);
        }
        else
        {
            Quaternion targetRotation2 = Quaternion.Euler(0, doorCloseAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation2, smooth * Time.deltaTime);
        }
    }
}*/