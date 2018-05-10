using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorClick : MonoBehaviour {

	public GameObject obj,player;
    private bool looking ;
    public float minDistance = 10.0f;
    private float distance;

	public Animator animator;

	public bool open;
	public bool close;
	private bool isOpen;

	// Use this for initialization
	void Start () {
		animator.enabled = false;
		open = false;
		close = false;
		looking = false;
	}
	
	// Update is called once per frame
	void Update () {
		distance = Vector3.Distance(player.transform.position, obj.transform.position);
  
        if (looking)
        {
            if (distance <= minDistance)
            {

                
                if (Input.GetButtonDown("Fire1"))
                {
                    
                    if (isOpen == false)
                    {
                        animator.enabled = true;
						open = true;
						close = false;
						isOpen = true;
                    }
                    else
                    {
                        animator.enabled = true;
						close = true;
						open = false;
						isOpen = false;
                    }

					if(open == true) {
						animator.SetBool("open", true);
						animator.SetBool("close", false);
					}
					if(close == true) {
						animator.SetBool("close", true);
						animator.SetBool("open", false);
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
