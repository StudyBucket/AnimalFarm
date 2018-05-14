using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class jumpingWell : MonoBehaviour {

    public PlayableDirector director;
    public GameObject obj, player, well;
    public bool jumpW;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            director = well.GetComponent<PlayableDirector>();
            if (director != null)
            {
                director.Play();
            }
        }
    }
}
