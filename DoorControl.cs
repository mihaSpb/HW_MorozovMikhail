using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoorControl : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {

        if (other.transform.tag == "Door")
        {
            other.transform.GetComponent<Door>().enabled = true;
            other.transform.GetComponent<Door>().Invert(transform);
            //other.transform.GetComponent<Door>().isOpen = true;
        }
    }
}
