using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrigger : MonoBehaviour
{
    AudioSource audioSource;
    public GameObject next;
    public AudioClip sound1;

    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GetComponent<BoxCollider>().enabled = false;
            audioSource.PlayOneShot(sound1);
            next.SetActive(true);　//次のイベントトリガーを有効化
        }
        
    }
}
