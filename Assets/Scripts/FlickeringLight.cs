using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLight : MonoBehaviour
{
    public float minTime = 0.05f;
    public float maxTime = 1.2f;

    private float timer;
    private Light l;


    void Start()
    {
        l = GetComponent<Light>();
        timer = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            l.enabled = !l.enabled;
            //audio.Play();
            timer = Random.Range(minTime, maxTime);
        }
    }
}
