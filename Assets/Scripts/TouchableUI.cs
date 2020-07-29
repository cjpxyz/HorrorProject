using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace EPOOutline
{
    public class TouchableUI : MonoBehaviour
    {
        // Start is called before the first frame update

        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("KeyItem"))
            {
                /*DoorScript doorScript = other.GetComponent<DoorScript>();
                Outlinable outlinable = other.GetComponent<Outlinable>();*/
                //other.GetComponent<Outlinable>().enabled = true;
            }
        }

        void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("KeyItem"))
            {
                /*DoorScript doorScript = other.GetComponent<DoorScript>();
                Outlinable outlinable = other.GetComponent<Outlinable>();*/
                //other.GetComponent<Outlinable>().enabled = false;
            }
        }
    }
}
