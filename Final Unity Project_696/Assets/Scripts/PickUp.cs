using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform destination; 

    private void OnMouseDown()
    {
        GetComponent<Rigidbody>().useGravity = false;
        transform.position = destination.position;
        transform.parent = GameObject.Find("Destination").transform; 
    }

    private void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true; 
    }
}
