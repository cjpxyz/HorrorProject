using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class UISwitcher : MonoBehaviour
    {
        public GameObject icon;
        public GameObject touchable;
        private Outline outline;
        void Start()
        {
            //outline = GetComponent<Outline>();
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("PlayerEye"))
            {
                icon.SetActive(false);
                touchable.SetActive(true);
                GetComponent<Outline>().enabled = true;
            }
        }

        void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("PlayerEye"))
            {
                icon.SetActive(true);
                touchable.SetActive(false);
                GetComponent<Outline>().enabled = false;
            }
        }
    }