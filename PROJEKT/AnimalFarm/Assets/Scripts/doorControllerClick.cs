using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorControllerClick : MonoBehaviour {

    bool isOpen;

    void OnMouseDown()
    {
        if (isOpen == false)
        {
            this.GetComponent<Animator>().SetTrigger("open");
            isOpen = true;
        } else
        {
            this.GetComponent<Animator>().SetTrigger("close");
            isOpen = false;
        }
    }

}
