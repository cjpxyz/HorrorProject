using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class NoteAcceptor : Acceptor
{
    public GameObject noteImage;

    GameObject player;
    //FirstPersonController controller;

    void Start()
    {
        player = GameObject.Find("PlayerController");
        //controller = player.GetComponent<FirstPersonController>();
        noteImage.SetActive(false);
    }

    public override void Accept(Visitor visitor)
    {
        noteImage.SetActive(true);
        player.GetComponent<FirstPersonController>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void HideNote()
    {
        noteImage.SetActive(false);
        player.GetComponent<FirstPersonController>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Destroy(gameObject, 0.1f);
    }
}
