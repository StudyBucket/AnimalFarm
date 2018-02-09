using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]

public class Interaction : MonoBehaviour {
    public GameObject obj,player;
    private bool looking ;
    public float minDistance = 10.0f;
    private float distance;

    bool isOpen;

    // Use this for initialization
    void Start () {
        looking = false;	
	}

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(player.transform.position, obj.transform.position);
  
        if (looking)
        {
            if (distance <= minDistance)
            {

                
                if (Input.GetButtonDown("Fire1"))
                {
                    
                    if (isOpen == false)
                    {
                        GetComponent<Animator>().SetTrigger("open");
                        isOpen = true;
                    }
                    else
                    {
                        GetComponent<Animator>().SetTrigger("close");
                        isOpen = false;
                    }
                }
            }
        } 
    }
        
    #region IGvrGazeResponder implementation

    public void OnGazeEnter()
    {
        looking = true;       
    }
    public void OnGazeExit()
    {
        looking = false;
    }
    public void OnGazeTrigger()
    {
        looking = true;

    }
    #endregion
}
