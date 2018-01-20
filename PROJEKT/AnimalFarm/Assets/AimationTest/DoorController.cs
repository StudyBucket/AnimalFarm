using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour {

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player1")
        {
            this.GetComponent<Animator>().SetTrigger("open");
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player1")
        {
            this.GetComponent<Animator>().SetTrigger("close");
        }
    }

}
