using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float InteractDistance = 5f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Ray ray = new Ray(transform.position, transform.forward);
            Debug.DrawRay(ray.origin, ray.direction * InteractDistance, Color.red, 1);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, InteractDistance))
            {
                if (hit.collider.CompareTag("Door"))
                {
                    DoorScript doorScript = hit.collider.transform.parent.GetComponent<DoorScript>();
                    if (doorScript == null) return;

                    if (Inventory.keyCount > 0)
                    {
                        doorScript.ChangeDoorState();
                    }
                    else
                    {
                        Debug.Log("プギャー9(^@^)wwww");
                    }
                }
                else if (hit.collider.CompareTag("KeyItem"))
                {
                    Inventory.keyCount += 2;
                    Debug.Log("鍵ゲット！");
                }
                else if (hit.collider.CompareTag("NextLevelDoor"))
                    {   
                        Application.LoadLevel(1);
                    }
            }
        }
    }
}
